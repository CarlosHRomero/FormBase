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
using Common.OBJ;
using Common.BLL;
namespace FormBase
{
    public partial class frmABMGui : frmABM
    {
        public virtual int Solapa { get; set; }
        public frmABMGui()
        {
            InitializeComponent();
        }
        // protected virtual TabControl TabControl1 { get; set; }
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
            if (TabControl1.TabPages["tpValidar"] == null)
                TabControl1.TabPages.Add(tpValidar);
            TabControl1.SelectedTab = TabControl1.TabPages["tpValidar"];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        protected override bool CargarRegistro()
        {
            if (!LeerRegistro())
                return false;
            return MostrarRegistro();
        }

        protected virtual bool MostrarRegistro()
        {
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
                    int x = 0;
                    if (campo.Name == "Ingr_Sintoma_D")
                        x = x;

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
                        //foreach (Control c in Panel2.Controls)
                        //{
                        //    CampoAControl(c, campo);
                        //}
                    }
                }
                CargarPiePagina();
                return true;
            }
            catch (Exception ex)
            {
                Mensajes.msgError("Cargar registro", ex);
                Cargado = true;
                return false;
            }

        }

        protected Boolean CampoAControl(Control c, PropertyInfo campo)
        {

            //if (campo.Name == "Comp_EEF_D")

            //    c.Name = c.Name;
            if (!(c is MaskedTextBox || c is TextBox || c is CheckBox || c is FlatComboBox || c is ComboBox || c is icbaCheckBox))
                return true;
            if (String.IsNullOrEmpty(c.Name))
                return true;
            object valor = campo.GetValue(Registro, null);
            try
            {
                if (c.Name.Substring(3).ToLower() == campo.Name.ToLower())
                {
                    if (c.Name == "cboIngr_Sintoma_D")
                        //MessageBox.Show("");
                        c.Tag = c.Tag;

                    String tipoCont = c.GetType().Name;
                    if (c is TextBox || c is MaskedTextBox)
                    {

                        switch (campo.Name.Substring(campo.Name.Length - 1))
                        {
                            case "H":
                                c.Text = ((DateTime)valor).ToString("HH:mm");
                                break;
                            case "F":
                                c.Text = ((DateTime)valor).ToString("dd/MM/yyyy");
                                break;
                            default:
                                List<string> lista = new List<string>(new string[]{ "AntC_ExF_FC_N", "AntC_FR_N",
                                "AntC_TA_N", "AntC_TAc_N"});
                                if (lista.Exists(x=> x == campo.Name))
                                {
                                    c.Text = ((float)valor).ToString("N0");
                                    return true;
                                }
                                if (campo.PropertyType == typeof(DateTime?))
                                    c.Text = ((DateTime)valor).ToString("dd/MM/yyyy");
                                else if (campo.PropertyType == typeof(double?) || campo.PropertyType == typeof(double))
                                    c.Text = ((double)valor).ToString("N2");
                                else if (campo.PropertyType == typeof(float?) || campo.PropertyType == typeof(float))
                                    c.Text = ((float)valor).ToString("N2");
                                else
                                    c.Text = valor.ToString().Trim();
                                break;
                        }
                    }
                    if (c is ComboBox)
                    {
                        ((FlatComboBox)c).SelectedValue = Convert.ToInt16(valor);
                        /*
                        var tipo = ((FlatComboBox)c).DataSource.GetType();

                        if (tipo == typeof(List<Int32>) || tipo == typeof(List<Int32?>))
                            ((FlatComboBox)c).SelectedValue = Convert.ToInt32(valor);
                        if (tipo == typeof(ListInt16) || tipo == typeof(Int16?))
                            ((FlatComboBox)c).SelectedValue = Convert.ToInt16(valor);*/
                    }
                    var box = c as CheckBox;
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = Convert.ToBoolean(valor);
                    }
                    if (c is icbaCheckBox)
                    {
                        ((icbaCheckBox)c).Checked = Convert.ToBoolean(valor);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("campo " + c.Name + " control " + c.Name + " " + ex.Message, "CampoAControl", MessageBoxButtons.OK);
                return false;
            }
        }

        protected override Boolean ActualizarRegistro()
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
                    //if (campo.Name == "Ant_Cor_Infarto_Año_N")

                    //    throw new Exception();
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
                ActualizarPie();

                return true;
            }
            catch (Exception ex)
            {
                Mensajes.msgError("ActualizarRegistro", ex);
                return false;
            }
        }

        protected virtual void ActualizarPie()
        {
            Type tipo = Registro.GetType();
            var campos = tipo.GetProperties();
            string form;
            if (campos.Length == 0)
                throw new Exception("Registro no inicializado");
            form = campos[0].Name.Split('_')[0];
            PropertyInfo usuProp = tipo.GetProperty(string.Format("{0}_Usr_Id", form));
            if (Ambiente.Usuario != null)
            {
                if(usuProp.PropertyType == typeof(int) || usuProp.PropertyType == typeof(int?))
                    usuProp.SetValue(Registro, Convert.ToInt32(Ambiente.Usuario.User_Id));
                if (usuProp.PropertyType == typeof(short) || usuProp.PropertyType == typeof(short?))
                    usuProp.SetValue(Registro, Convert.ToInt16(Ambiente.Usuario.User_Id));
            }
            PropertyInfo maquina = tipo.GetProperty(string.Format("{0}_Maq", form));
            if (maquina != null)
            {
                if (Ambiente.Maquina != null)
                {
                    maquina.SetValue(Registro, Ambiente.Maquina);
                }
            }
            PropertyInfo abm = tipo.GetProperty(string.Format("{0}_ABM", form));
            if (abm != null)
            {
                if (accion == TipoAccion.Alta)
                {
                    abm.SetValue(Registro, "Alta");
                }

                if (accion == TipoAccion.Modif)
                {
                    abm.SetValue(Registro, "Mod");
                }
            }
            PropertyInfo reg = tipo.GetProperty(string.Format("{0}_Reg_T", form));
            if (reg != null)
            {
                reg.SetValue(Registro, Convert.ToInt16(2));
            }
            PropertyInfo prop =  tipo.GetProperty(string.Format("{0}_Prop_T",form));
            if (prop != null)
            {
                if(prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int?))
                    prop.SetValue(Registro, Convert.ToInt32(3));
                if (prop.PropertyType == typeof(short) || prop.PropertyType == typeof(short?))
                    prop.SetValue(Registro, Convert.ToInt16(3));

            }
            PropertyInfo da = tipo.GetProperty(string.Format("{0}_Reg_F", form));
            if(da != null)
                da.SetValue(Registro, DateTime.Today);
            PropertyInfo ti = tipo.GetProperty(string.Format("{0}_Reg_H", form));
            if(ti != null)
                ti.SetValue(Registro, DateTime.Now);
                
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
            Modificado = true;// false;
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
            try
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
                CargarControlesAlta();
                btnBaja.Enabled = false;
                btnModif.Enabled = false;
                btnVer.Enabled = false;
                Validado = false;
                Modificado = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected virtual void CargarControlesAlta()
        {
            return;
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
        protected override bool Validar()
        {
            //TipoError flag = TipoError.SinError;
            //dgvErrores.Rows.Clear();
            //switch (flag)
            //{
            //    case TipoError.SinError:
            //        dgvErrores.Rows.Add("", "", "Validación sin errores");
            //        return true;
            //    case TipoError.Informativo:
            //        dgvErrores.Rows.Add("", "", "Validación sin errores Terminales");
            //        return true;
            //    default:
            //        return false;
            //} 
            return true;
        }

        protected virtual void CargarFormulario()
        {
            try
            {
                Layaout();
                InicializarDesplegables();
                CargarCabecera();
                switch (accion)
                {
                    case TipoAccion.Alta:
                        CrearRegistro();
                        DisplayAlta();
                        break;
                    case TipoAccion.Ver:
                        if(Id == 0)
                            Id = ObtenerId();
                        CargarRegistro();
                        DisplayVer();
                        break;
                    case TipoAccion.Modif:
                        if(Id == null)
                            Id = ObtenerId();
                        CargarRegistro();
                        DisplayMod();
                        break;
                    case TipoAccion.Baja:
                        if(Id == null)
                            Id = ObtenerId();
                        CargarRegistro();
                        DisplayBaja();
                        break;
                }
                OcultarControles();
                Cargado = true;
            }
            catch(Exception ex)
            {
                Mensajes.msgError(ex);
                Close();
            }
        }


        protected virtual int ObtenerId()
        {
            return 0;
        }

        protected virtual void CrearRegistro()
        {
            throw new NotImplementedException();
        }

        protected virtual void CargarPiePagina()
        {
            Type tipo = Registro.GetType();
            IList<PropertyInfo> campos = new List<PropertyInfo>(tipo.GetProperties());
            PropertyInfo prop;

            foreach (Control c in Panel2.Controls)
            {
                string nombre = c.Name.Substring(3);
                prop = tipo.GetProperty(nombre);
                if (prop != null)
                {
                    object valor = prop.GetValue(Registro, null);
                    if (valor != null)
                    {
                        CampoAControl(c, prop);
                    }
                }
            }
        }


        private void frmABMGui_Load(object sender, EventArgs e)
        {

        }

        protected void Layaout()
        {
            ToolStrip1.Location = new Point(Width - ToolStrip1.Width - 30, ToolStrip1.Location.Y);
            toolStrip2.Location = new Point(Width - toolStrip2.Width - 30, ToolStrip1.Location.Y);
        }

        protected void PropDesp(Control cont)
        {

            foreach (Control c in cont.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    PropDesp(c);
                }
                else
                {
                    var box = c as FlatComboBox;

                    if (box != null)
                    {
                        try
                        {
                            if(box.DataSource != null)
                            {
                                Type t = box.DataSource.GetType();
                                if(t  == typeof(List<clsDespEquiv>) || t == typeof (List<clsNoSi>))
                                {
                                    box.DisplayMember = "Eqv_Desc";
                                    box.ValueMember = "Eqv_Val";
                                }
                            }
                            //if (== typeof(List<clsCarEquiv>))
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        private void dgvErrores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cod = Convert.ToInt32(dgvErrores.Rows[e.RowIndex].Cells[0].Value);

            IrAlError(cod);
        }

        protected virtual void IrAlError(int cod)
        {
            throw new NotImplementedException();
        }
        protected override void OcultarControles()
        {
            try
            {
                foreach (TabPage tp in TabControl1.TabPages)
                {
                    foreach (Control c in tp.Controls)
                    {
                        if (c is CheckBox || c is icbaCheckBox)
                        {
                            string s;
                            if (c.Name.Length > 3)
                            {
                                s = c.Name.Substring(3, c.Name.Length - 3);
                                bool cheked = false;
                                if (c is CheckBox)
                                    cheked = ((CheckBox)c).Checked;
                                else if (c is icbaCheckBox)
                                    cheked = ((icbaCheckBox)c).Checked;
                                OcultarControlesPorTag(s, cheked);
                            }
                        }
                        if (c is ComboBox || c is FlatComboBox)
                        {
                            string s;
                            if (c.Name.Length > 3)
                            {
                                s = c.Name.Substring(3, c.Name.Length - 3);
                                bool cheked = false;
                                int n = ValorAmostrarPorDesp((ComboBox)c);
                                if(((ComboBox)c).SelectedValue != null)
                                {
                                    if (Convert.ToInt32(((ComboBox)c).SelectedValue) > n)
                                        OcultarControlesPorTag(s, true);
                                    else
                                        OcultarControlesPorTag(s, false);
                                }
                                else
                                    OcultarControlesPorTag(s, false);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Mensajes.msgError(ex);
            }
        }

        protected virtual int ValorAmostrarPorDesp(ComboBox c)
        {
            return 1;

        }

        protected void OcultarControlesPorTag(string tag, bool visible)
        {
            foreach (TabPage tb in TabControl1.TabPages)
            {
                foreach (Control c in tb.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c.Tag.ToString() == tag)
                        {
                            if (visible)
                            {
                                if (c is FlatComboBox)
                                    ((FlatComboBox)c).Visible = true;
                                else
                                    c.Visible = true;
                            }
                            else
                                LimpiarControl(c);
                        }
                    }
                }
            }
        }

    }
}
