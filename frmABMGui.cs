using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DrawFlat;
using icbaTextBox;
using Generales;

namespace FormBase
{
    public partial class frmABMGui : frmABM
    {
        protected virtual TabPage TpValidar { get; set; }
        public frmABMGui()
        {
            InitializeComponent();
        }

        protected override bool Modificado
        {
            get { return _modificado; }
            set
            {
                _modificado = value;
                if (_modificado)
                {
                    btnCancelar.Enabled = true;
                    Validado = false;
                }
                else
                {
                    btnCancelar.Enabled = false;
                    btnValidar.Enabled = false;
                }
            }
        }
        protected bool Validado
        {
            get { return _validado; }
            set
            {
                _validado = value;
                if (_validado)
                    btnGuardar.Enabled = true;
                else
                {
                    btnValidar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (accion == TipoAccion.Baja)
            {
                btnGuardar.Enabled = true;
                return;
            }
            if (Validar())
            {
                btnGuardar.Enabled = true;

            }
            if (TabControl1.TabPages["_tpValidar"] == null)
                TabControl1.TabPages.Add(TpValidar);
            TabControl1.SelectedTab = TabControl1.TabPages["_tpValidar"];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        protected Boolean CargarRegistro()
        {
            if (!LeerRegistro())
                return false;
            try
            {
                foreach (TabPage tp in TabControl1.TabPages)
                {
                    foreach (Control c in tp.Controls)
                    {
                        String tipoCont = c.GetType().Name;
                        if ((tipoCont == "TextBox") || (tipoCont == "MaskedTextBox") || (tipoCont == "icbaTextBox"))
                        {
                            c.Text = null;
                        }
                        if ((tipoCont == "ComboBox") || (tipoCont == "FlatComboBox"))
                        {
                            ((FlatComboBox)c).SelectedValue = 0;
                        }
                        if (tipoCont == "CheckBox")
                        {
                            ((CheckBox)c).Checked = false;
                        }
                        if (tipoCont == "icbaCheckBox")
                        {
                            ((icbaCheckBox)c).Checked = false;
                        }

                    }

                }
                if (Registro == null)
                    return false;
                Type tipo = Registro.GetType();
                IList<PropertyInfo> campos = new List<PropertyInfo>(tipo.GetProperties());

                foreach (PropertyInfo campo in campos)
                {
                    //if (campo.Name == "Comp_EEF_D")

                    //    throw new Exception();
                    object valor = campo.GetValue(Registro, null);
                    if (valor != null)
                    {
                        foreach (TabPage tb in TabControl1.TabPages)
                        {
                            foreach (Control c in tb.Controls)
                            {
                                CampoAControl(c, campo);
                            }
                        }
                        foreach (Control c in Panel2.Controls)
                        {
                            CampoAControl(c, campo);
                        }
                    }
                }
                cargado = true;
                return true;
            }
            catch (Exception ex)
            {
                Mensajes.msgError("Cargar registro", ex);
                cargado = true;
                return false;
            }
        }
        protected virtual Boolean ActualizarRegistro()
        {
            try
            {
                if (Registro == null)
                {
                    return false;
                }
                Type tipo = Registro.GetType();

                List<PropertyInfo> campos = new List<PropertyInfo>(tipo.GetProperties());
                foreach (PropertyInfo campo in campos)
                {
                    if (campo.Name == "Comp_CC_FEmq40_B")

                        ;//throw new Exception();
                    foreach (Control c in Panel2.Controls)
                    {
                        if (!ControlACampo(c, campo))
                            return false;
                    }
                    foreach (TabPage tb in TabControl1.TabPages)
                    {
                        foreach (Control c in tb.Controls)
                        {
                            if (!ControlACampo(c, campo))
                                return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Mensajes.msgError("ActualizarEstudiosClinicos", ex);
                return false;
            }
        }

        protected virtual void DisplayMod()
        {
            foreach (TabPage tb in TabControl1.TabPages)
            {
                foreach (Control c in tb.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is FlatComboBox)
                        c.BackColor = Colores.colorHab;
                    var textBox = c as TextBox;
                    if (textBox != null)
                        textBox.ReadOnly = false;
                    var box = c as MaskedTextBox;
                    if (box != null)
                        box.ReadOnly = false;
                    var comboBox = c as FlatComboBox;
                    if (comboBox != null)
                        comboBox.ReadOnly = false;
                    var checkBox = c as CheckBox;
                    if (checkBox != null)
                        checkBox.Enabled = true;
                    if (c is icbaCheckBox)
                        c.Enabled = true;
                }
            }
            Validado = false;
            Modificado = false;
        }
        protected virtual void DisplayVer()
        {
            foreach (TabPage tb in TabControl1.TabPages)
            {
                foreach (Control c in tb.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is FlatComboBox || c is CheckBox || c is icbaCheckBox)
                        c.BackColor = Colores.colorDes;
                    var box = c as TextBox;
                    if (box != null)
                        box.ReadOnly = true;
                    var textBox = c as MaskedTextBox;
                    if (textBox != null)
                        textBox.ReadOnly = true;

                    var comboBox = c as FlatComboBox;
                    if (comboBox != null)
                        comboBox.ReadOnly = true;
                    var checkBox = c as CheckBox;
                    if (checkBox != null)
                        checkBox.Enabled = false;
                    if (c is icbaCheckBox)
                        c.Enabled = false;

                }
            }
            this.btnModif.Enabled = true;
            Validado = false;
            Modificado = false;
        }

        protected void DisplayBaja()
        {
            foreach (TabPage tp in TabControl1.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    if (c is TextBox || c is FlatComboBox)
                        c.BackColor = Colores.colorDes;
                }
            }
            Validado = false;
            Modificado = true;
        }

        protected virtual void DisplayAlta()
        {
            foreach (TabPage tp in TabControl1.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is DrawFlat.FlatComboBox || c is CheckBox)
                        c.Enabled = true;
                    var textBox = c as TextBox;
                    if (textBox != null)
                    {
                        textBox.ReadOnly = false;
                        c.Text = "";
                        c.BackColor = Colores.colorHab;
                    }
                    var maskedTextBox = c as MaskedTextBox;
                    if (maskedTextBox != null)
                    {
                        maskedTextBox.ReadOnly = false;
                        c.Text = "";
                        c.BackColor = Colores.colorHab;
                    }

                    var box = c as FlatComboBox;
                    if (box != null)
                    {
                        try
                        {
                            box.ReadOnly = false;
                            c.BackColor = Colores.colorHab;
                            box.SelectedValue = 1;
                        }
                        catch
                        {
                            // ignored
                        }
                    }
                    var checkBox = c as CheckBox;
                    if (checkBox != null)
                    {
                        checkBox.Checked = false;
                    }
                    if (c is icbaCheckBox)
                        c.Enabled = true;
                }
            }
            btnBaja.Enabled = false;
            btnModif.Enabled = false;
            btnVer.Enabled = false;
            Validado = false;
            Modificado = false;
        }
        protected void CrearToolTip()
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            foreach (TabPage tp in TabControl1.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    if (c is MaskedTextBox || c is TextBox || c is CheckBox || c is FlatComboBox || c is ComboBox || c is icbaTextBox.icbaTextBox)
                        toolTip1.SetToolTip(c, c.Name.Substring(3));
                    if (c is icbaCheckBox)
                        toolTip1.SetToolTip(c, c.Name.Substring(3));
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            accion = TipoAccion.Ver;
            DisplayVer();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            accion = TipoAccion.Modif;
            DisplayMod();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            accion = TipoAccion.Baja;
            DisplayBaja();
        }

        private void frmABMGui_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Modificado)
                if (Mensajes.msgConfirmarSalida(Text) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            Dispose();
        }

    }
}
