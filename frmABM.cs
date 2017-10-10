using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DrawFlat;
using Generales;
using Common.BLL;
using System.Reflection;
using PetaPoco;

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

        protected virtual bool Cargado { get; set; }

        public int Id { get; set; }
        public virtual object Registro { get; set; }
        private void frmABM_Load(object sender, EventArgs e)
        {
        }

        protected virtual void CargarCabecera()
        {
            throw new NotImplementedException();
        }
        protected virtual void InicializarDesplegables()
        {
            throw new NotImplementedException();
        }
        protected virtual ITablaBuss TablaBuss{get; set;}
        

        protected virtual bool Alta()
        {
            try
            {
                if (!TablaBuss.Insertar(Registro))
                    Mensajes.msgError("Error al Insertar registro");
                return true;
            }
            catch(Exception ex)
            {
                Mensajes.msgError("Alta", ex);
                return false;
            }
        }

        protected virtual bool Baja()
        {
            return TablaBuss.Eliminar(Registro);
        }

        protected virtual bool Modif()
        {
            return TablaBuss.Modificar(Registro);
        }

        protected virtual void OcultarControles()
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
                        Text = Titulo + " Nuevo";
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
        
        protected virtual bool LeerRegistro()
        {
            try
            {
                Registro = TablaBuss.Leer(Id);
                return true;
            }
            catch(Exception ex)
            {
                Mensajes.msgError(ex);
                return false;
            }

        }
        protected Boolean CargarRegistro()
        {
            if (!LeerRegistro())
                return false;
            return true;
        }

        protected virtual bool ActualizarRegistro()
        {
            throw new NotImplementedException();
        }

        protected Boolean ControlACampo(Control c, PropertyInfo campo)
        {
            try
            {
                //if (string.IsNullOrEmpty(c.Text))
                //    return true;
                if (EsClavePrimaria(campo))
                    return true;
                if (campo.Name == "Ingr_HTA_T")
                    c.Name = c.Name;
                String tipoCont = c.GetType().Name;
                if (c.Name.Length > 3)
                {
                    if (c.Name.Substring(3).ToLower() == campo.Name.ToLower())
                    {
                        if (campo.Name == "Evol_Obs")
                            c.Name = c.Name;
                        var box = c as MaskedTextBox;
                        if ((box is MaskedTextBox ))
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
                                    if (campo.PropertyType == typeof(Int16) || campo.PropertyType == typeof(Int16?))
                                        campo.SetValue(Registro, Convert.ToInt16(valor2), null);
                                    else if (campo.PropertyType == typeof(Int32) || campo.PropertyType == typeof(Int32?))
                                        campo.SetValue(Registro, Convert.ToInt32(valor2), null);
                                }
                                catch(Exception ex)
                                {
                                    throw (ex);
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

        private bool EsClavePrimaria(PropertyInfo campo)
        {
            var obj = Registro;

            var pkAttribute = obj.GetType().GetCustomAttributes(typeof(PrimaryKeyAttribute), true)[0] as PrimaryKeyAttribute;
            if (pkAttribute != null)
            {
                if (pkAttribute.Value == campo.Name)
                    return true;
            }
            return false;
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
                    Mensajes.msgError("Error al actualizar registro en Guardar()");
                    return;
                }

                if (accion == TipoAccion.Baja)
                {
                    if (Mensajes.msgEliminarResgistro() == DialogResult.Yes)
                    {
                        if (Baja())
                        {
                            Mensajes.msgRegistroBorrado();
                            ActualizarListado();
                            Modificado = false;
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
                        Mensajes.msgRegistroActualizado();
                        if (padre != null)
                            padre.Actualizar();
                        Modificado = false;
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
                        AbrirFormSig();
                        //Mensajes.msgRegistroInsertado();
                        if (padre != null)
                            padre.Actualizar();
                        Modificado = false;
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

        protected virtual void ActualizarListado()
        {
            throw new NotImplementedException();
        }

        protected virtual void AbrirFormSig()
        {
            return;
        }
        protected void LimpiarControl(Control c)
        {

            if (c is CheckBox )
            {
                var box = (CheckBox)c;
                box.Checked = false;
                return;
            }
            if (c is icbaCheckBox)
            {
                var box = (icbaCheckBox)c;
                box.Checked = false;
                //return;
            }
            var comboBox = c as ComboBox;
            if (comboBox != null)
            {
                if (c.Name == "cboAnt_Arr_ExtrSistol_Tip_D")
                    c.Name = c.Name;
                if (!String.IsNullOrEmpty(comboBox.ValueMember))
                    comboBox.SelectedValue = 1;
                ((FlatComboBox)c).Visible = false;
                return;
            }
            var textBox = c as TextBox;
            if (textBox != null)
                textBox.Text = null;
            c.Visible = false;
        }
    }
}
