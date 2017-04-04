using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DrawFlat;
using Generales;
using System.Reflection;

namespace FormBase
{
    public partial class frmABM : FormBase.frmBase
    {
        public frmABM()
        {
            InitializeComponent();
        }
        protected bool _validado;
        protected bool _modificado;
        protected frmBase padre { get; set; }

        protected virtual bool Validado
        {
            get { return _validado;}
            set
            {
                _validado = value;
            }
        }

        protected virtual bool Modificado
        {
            get { return _modificado; }
            set
            {
                _modificado = value;
            }
        }



        protected TipoAccion _accion;

        protected Boolean cargado;

        private void frmABM_Load(object sender, EventArgs e)
        {

        }
        protected virtual bool Alta()
        {
            throw new NotImplementedException();
        }

        protected virtual bool Baja()
        {
            throw new NotImplementedException();
        }

        protected virtual bool Modif()
        {
            throw new NotImplementedException();
        }

        protected virtual void Display()
        {
            return;
        }

        protected virtual Boolean Validar()
        {
            throw new NotImplementedException();
        }
        public TipoAccion accion
        {
            get
            {
                return _accion;
            }
            set
            {
                _accion = value;
                switch (_accion)
                {
                    case TipoAccion.Alta:
                        Text = Titulo + " Alta";
                        break;
                    case TipoAccion.Baja:
                        Text = Titulo + " Baja";
                        break;
                    case TipoAccion.Modif:
                        Text = Titulo + " Modif";
                        break;
                    case TipoAccion.Ver:
                        Text = Titulo + " Ver";
                        break;
                }
            }
        }
        public virtual object Registro { get; set; }
        protected virtual bool LeerRegistro()
        {
            throw new NotImplementedException();
        }
        protected Boolean CargarRegistro()
        {
            throw new NotImplementedException();
        }

        protected Boolean CampoAControl(Control c, PropertyInfo campo)
        {
            //if (campo.Name == "ATC_Obs_T")
            //    MessageBox.Show("");
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
                    //if (c.Name == "cboATC_CCG_Vinc")
                    //    MessageBox.Show("");
                    // c.Tag = c.Tag;

                    String tipoCont = c.GetType().Name;
                    if (c is TextBox || c is MaskedTextBox)
                    {

                        switch (campo.Name.Substring(campo.Name.Length - 1))
                        {
                            case "H":
                                c.Text = ((DateTime)valor).ToString("HH:mm");
                                break;
                            case "F":
                                c.Text = ((DateTime)valor).ToShortDateString();
                                break;
                            default:
                                if (campo.PropertyType == typeof(DateTime?))
                                    c.Text = ((DateTime)valor).ToShortDateString();
                                else if (campo.PropertyType == typeof(double?) || campo.PropertyType == typeof(double))
                                    c.Text = ((double)valor).ToString("N2");
                                else if (campo.PropertyType == typeof(float?) || campo.PropertyType == typeof(float))
                                    c.Text = ((float)valor).ToString("N2");
                                else
                                    c.Text = valor.ToString();
                                break;

                        }
                    }
                    if (c is ComboBox)
                    {
                        ((FlatComboBox)c).SelectedValue = Convert.ToInt32(valor);
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
        protected virtual bool ActualizarRegistro()
        {
            throw new NotImplementedException();
        }

        protected Boolean ControlACampo(Control c, PropertyInfo campo)
        {
            try
            {
                //if (campo.Name == "Comp_EEF_D")
                //    c.Name = c.Name;
  
                String tipoCont = c.GetType().Name;
                if (c.Name.Length > 3)
                {
                    if (c.Name.Substring(3).ToLower() == campo.Name.ToLower())
                    {
                        if (campo.Name == "Est_Obs_T")
                            c.Name = c.Name;
                        var box = c as MaskedTextBox;
                        if ((box != null))
                        {

                            try
                            {
                                if (campo.PropertyType == typeof(DateTime?) || campo.PropertyType == typeof(DateTime))
                                {
                                    box.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                                    if (!String.IsNullOrEmpty(c.Text))
                                    {
                                        box.TextMaskFormat = MaskFormat.IncludeLiterals;
                                        campo.SetValue(Registro, Convert.ToDateTime(c.Text), null);
                                    }
                                    else
                                        campo.SetValue(Registro, null, null);
                                }
                            }
                            catch (Exception ex1)
                            {
                                Mensajes.msgError(ex1);
                            }

                        }
                        if ((tipoCont == "TextBox") || (tipoCont == "icbaTextBox"))
                        {
                            if (campo.PropertyType == typeof(DateTime?))
                            {
                                if (!String.IsNullOrEmpty(c.Text))
                                    campo.SetValue(Registro, Convert.ToDateTime(c.Text), null);
                                else
                                    campo.SetValue(Registro, null, null);
                            }
                            else if (campo.PropertyType == typeof(int?))
                            {
                                if (!String.IsNullOrEmpty(c.Text))
                                    campo.SetValue(Registro, Convert.ToInt32(c.Text), null);
                                else
                                    campo.SetValue(Registro, null, null);
                            }
                            else if (campo.PropertyType == typeof(short?))
                            {
                                if (!String.IsNullOrEmpty(c.Text))
                                    campo.SetValue(Registro, Convert.ToInt16(c.Text), null);
                                else
                                    campo.SetValue(Registro, null, null);
                            }

                            else if (campo.PropertyType == typeof(float?))
                            {
                                if (!String.IsNullOrEmpty(c.Text))
                                    campo.SetValue(Registro, Convert.ToSingle(c.Text), null);
                                else
                                    campo.SetValue(Registro, null, null);
                            }
                            else if (campo.PropertyType == typeof(double?))
                            {
                                if (!String.IsNullOrEmpty(c.Text))
                                {
                                    double f = Convert.ToDouble(c.Text);
                                    campo.SetValue(Registro, f, null);
                                }
                                else
                                    campo.SetValue(Registro, null, null);
                            }
                            else
                                campo.SetValue(Registro, c.Text, null);
                        }

                        if ((tipoCont == "ComboBox") || (tipoCont == "FlatComboBox"))
                        {
                            var valor2 = ((FlatComboBox)c).SelectedValue;

                            if (valor2 == null)
                                campo.SetValue(Registro, null, null);
                            else
                            {

                                try
                                {
                                    campo.SetValue(Registro, Convert.ToInt16(valor2), null);
                                }
                                catch
                                {
                                    campo.SetValue(Registro, Convert.ToInt32(valor2), null);
                                }
                            }
                        }
                        if (c is CheckBox || c is icbaCheckBox)
                        {
                            bool valor2;
                            if (c is CheckBox)
                                valor2 = ((CheckBox)c).Checked;
                            else
                                valor2 = ((icbaCheckBox)c).Checked;
                            if (campo.PropertyType == typeof(short?))
                                campo.SetValue(Registro, Convert.ToInt16(valor2), null);
                            if (campo.PropertyType == typeof(Boolean))
                                campo.SetValue(Registro, valor2, null);
                            if (campo.PropertyType == typeof(Boolean?))
                                campo.SetValue(Registro, valor2, null);

                            if (campo.PropertyType == typeof(int?))
                                campo.SetValue(Registro, Convert.ToInt32(valor2), null);
                        }

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("campo: " + campo.Name.ToString() + " control: " + c.Name + ex.Message, "ControlACampo", MessageBoxButtons.OK);
                return false;
            }
        }

        private void frmParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_modificado)
                if (Mensajes.msgConfirmarSalida(Text) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            Dispose();
        }
        protected void Cancelar()
        {
            if (Mensajes.msgCancelar() == System.Windows.Forms.DialogResult.Yes)
            {
                if (accion == TipoAccion.Alta)
                {
                    DisplayAlta();
                    return;
                }
                CargarRegistro();
                Validado = false;
                Modificado = false;
            }
        }

        protected virtual void DisplayAlta()
        {
            throw new NotImplementedException();
        }
        protected virtual void DisplayBaja()
        {
            throw new NotImplementedException();
        }
        protected virtual void DisplayVer()
        {
            throw new NotImplementedException();
        }

        protected virtual void DisplayMod()
        {
            throw new NotImplementedException();
        }
        protected virtual void Guardar()
        {
            try
            {
                if (!ActualizarRegistro())
                {
                    return;
                }

                if (accion == TipoAccion.Baja)
                {
                    if (Mensajes.msgEliminarResgistro() == DialogResult.Yes)
                    {
                        if (Baja())
                        {
                            Mensajes.msgRegistroBorrado();
                            if (padre != null)
                                padre.Actualizar();
                            this.Close();
                        }
                        else
                        {
                            Mensajes.ErrorBorrar();
                        }
                    }
                }
                if (accion == TipoAccion.Modif)
                {
                    //if (Mensajes.msgActualizarRegistro() == DialogResult.Yes)
                    //{
                    if (Modif())
                    {
                        //Mensajes.msgRegistroActualizado();
                        if (padre != null)
                            padre.Actualizar();
                        this.Close();
                    }
                    else
                    {
                        Mensajes.ErrorActualizar();
                    }
                    //}
                }
                if (accion == TipoAccion.Alta)
                {
                    if (Alta())
                    {
                        //Mensajes.msgRegistroInsertado();
                        if (padre != null)
                            padre.Actualizar();
                        this.Close();
                    }
                    else
                    {
                        Mensajes.ErrorInsertar();
                    }
                }

            }
            catch (Exception ex)
            {
                Mensajes.msgError(ex);
            }
        }

    }
}
