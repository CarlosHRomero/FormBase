using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Generales;
using DrawFlat;
using System.Reflection;


namespace FormBase
{
    public partial class frmListado : frmBase
    {
        Estados _estado = Estados.SinFiltrar;

        protected string _where, _order;
//        protected virtual List<T> Lista{get; set;}

        protected string _Titulo;

        private Estados Estado
        {
            set
            {
                if (value == 0)
                    stlEstado.Text = "Sin filtrar";
                else
                {
                    stlEstado.Text = "Filtrado";
                    _estado = value;
                }
            }
        }


        protected void AgregarControlesFiltro()
        {
            txtPad.Width = DataGridView1.RowHeadersWidth;
            int x = txtPad.Width-1;
            foreach (DataGridViewColumn column in DataGridView1.Columns)
            {
                if (!column.Visible)
                    continue;
                if (column.CellType == typeof(DataGridViewTextBoxCell))
                {
                    if (column.DefaultCellStyle.Format == "d")
                    {
                        MaskedTextBox txtBox = new MaskedTextBox();
                        txtBox.Name = string.Format("{0}Fin", column.Name);
                        AjustarFechaFiltro(txtBox, x, column);
                        panelFiltro.Controls.Add(txtBox);
                        txtBox = new MaskedTextBox();
                        txtBox.Name = string.Format("{0}Ini", column.Name);
                        AjustarFechaFiltro(txtBox, x, column);
                        txtBox.Location = new Point(txtBox.Location.X, panelHeader.Height - panelFiltro.Height - txtBox.Height-1);
                        panelHeader.Controls.Add(txtBox);
                        x += column.Width;
                    }
                    else
                    {
                        TextBox txtBox = new TextBox();
                        txtBox.BorderStyle = BorderStyle.FixedSingle;
                        AjustarControlFiltro(txtBox, x, column);
                        x += column.Width;
                        txtBox.TextAlign = HorizontalAlignment.Center;
                    }
                }
                if (column.CellType == typeof(DataGridViewComboBoxCell))
                {
                    FlatComboBox cboBox = new FlatComboBox();
                    cboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    cboBox.FlatStyle = FlatStyle.Flat;
                    cboBox.Filtro = true;
                    AjustarControlFiltro(cboBox, x, column);
                    x+= column.Width;
                }
                if(column.CellType ==typeof(DataGridViewCheckBoxCell))
                {
                    icbaCheckBox chk = new icbaCheckBox();
                    chk.CheckAlign = ContentAlignment.MiddleCenter;
                    chk.Text = "";
                    chk.Height = 20;
                    AjustarControlFiltro(chk,x, column);
                }
            }
        }
        public void AjustarControlFiltro(Control c, int x, DataGridViewColumn column)
        {
            c.Location = new Point(x, 0);
            c.Width = column.Width+1;
            c.Name = string.Format("{0}Fil", column.Name);
            c.BackColor = Color.SkyBlue;
            panelFiltro.Controls.Add(c);
        }
        public void AjustarFechaFiltro(MaskedTextBox c, int x, DataGridViewColumn column)
        {
            c.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.Mask = "00/00/0000";
            c.BorderStyle = BorderStyle.FixedSingle;
            c.Location = new Point(x, 0);
            c.Width = column.Width + 1;
            c.BackColor = Color.SkyBlue;
            c.TextAlign = HorizontalAlignment.Center;
        }

        public frmListado()
        {
            InitializeComponent();
        }
        private void InicializarForm()
        {
            Width = DataGridView1.Width + 20;
            Height = DataGridView1.Height + panelHeader.Height +panel3.Height + 40;
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            ToolStrip1.Left = Width - ToolStrip1.Width - 50;
        }
        private void InicilizarFiltro()
        {
            AgregarControlesFiltro();
        }

        protected virtual void InicializarGrid()
        {
            DataGridView1.Location = new Point(0, panelHeader.Height);
        }

        protected virtual void InicializarDesplegables()
        {
            return;
        }


        protected virtual void CargarGrid()
        {
            throw new NotImplementedException();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.DefaultCellStyle.Format == "d")
            {
                DateTime f1;
                DateTime f2;
                DateTime.TryParse(e.CellValue1.ToString(), out f1);
                DateTime.TryParse(e.CellValue2.ToString(), out f2);
                e.SortResult = System.DateTime.Compare(f1, f2);
                e.Handled = true;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarLista();
        }

        protected virtual void FiltrarLista()
        {
            throw new NotImplementedException();
        }

        public string Where
        {
            get { return _where; }
            set { _where = value; }
        }

        private string Nombre { get; set; }
        
        protected  void Filtrar<T>()
        {
            bool filtro = false;
            bool Fand = false;
            _where = "";
            foreach (Control c in this.panelFiltro.Controls)
            {
                if (!string.IsNullOrEmpty(c.Text))
                {
                    if (!(c is MaskedTextBox))
                        filtro = true;
                    else
                    {                        
                        if (c.Text != ((MaskedTextBox)c).Mask)
                        {
                            filtro = true;
                        }
                    }
                }
            }
            if(!filtro)
                return;
            Type tipo = typeof(T);
            List<PropertyInfo> campos = new List<PropertyInfo>(tipo.GetProperties());
            string query;
            bool fand = false;
            //Control cont = panelFiltro.Controls[1];
            //string nombreCampo = cont.Name.Substring(0, cont.Name.Length - 3);
            //query = string.Format("{0}.ToLower().Contains(@0)", nombreCampo);
            
            //if()
            //    query = campo

            PropertyInfo campoActual= null;
            foreach(Control cont in panelFiltro.Controls)
            {
                string nombreCampo = cont.Name.Substring(0, cont.Name.Length - 3);
                /*foreach(PropertyInfo campo in campos)
                {
                    if(campo.Name == nombreCampo)
                        campoActual = campo;
                }*/
                campoActual = campos.Find(x => x.Name == nombreCampo);
                if(campoActual == null)
                    continue;
                if (string.IsNullOrEmpty(cont.Text))
                    continue;
                if (campoActual.PropertyType == typeof(string))
                {
                    var texto = Cadenas.RemplazaApostrofos(cont.Text);
                    texto = Cadenas.ReemplazarAcentos(texto);
                    texto = Cadenas.ReemplazarComodines(texto);
                    if (fand)
                        _where += string.Format(" and {0} like '{1}%'", nombreCampo, texto);
                    else
                    {
                        _where += string.Format("{0} like '{1}%'", nombreCampo, texto);
                        fand = true;
                    }
                }
                if(cont is FlatComboBox || cont is ComboBox)
                {
                    if (fand)
                        _where += string.Format(" and {0} = {1}", nombreCampo, ((ComboBox)cont).SelectedValue);
                    else
                    {
                        _where += string.Format(" {0} = {1}", nombreCampo, ((ComboBox)cont).SelectedValue);
                        fand = true;
                    }
                }
                if(cont is TextBox && (campoActual.PropertyType == typeof(int) ||campoActual.PropertyType == typeof(short) ||campoActual.PropertyType == typeof(long)))
                {
                    if (fand)
                        _where += string.Format(" and {0} = {1}", nombreCampo, ((TextBox)cont).Text);
                    else
                    {
                        _where += string.Format(" {0} = {1}", nombreCampo, ((TextBox)cont).Text);
                        fand = true;
                    }
                }
                if (cont is MaskedTextBox && (campoActual.PropertyType == typeof(DateTime)|| campoActual.PropertyType == typeof(DateTime?)))
                {
                    var contIni = panelHeader.Controls[nombreCampo + "Ini"];
                    string fi = ((MaskedTextBox)contIni).MaskedTextProvider.ToDisplayString(); 
                    string ff = ((MaskedTextBox)cont).MaskedTextProvider.ToDisplayString(); 
                    if(contIni == null)
                        throw new Exception("No se encontro control de fecha inicial");
                    if(fand)
                    {
                        _where += string.Format(" and {0} between '{1}' and '{2}'", nombreCampo, fi, ff);
                    }
                    else
                    {
                        _where += string.Format("{0} between '{1}' and '{2}'", nombreCampo, fi, ff);
                    }
                }

                /*                
                   if(cont is MaskedTextBox)
                    ((MaskedTextBox)cont).TextMaskFormat= MaskFormat.ExcludePromptAndLiterals;

                 * if(!string.IsNullOrEmpty(cont.Text))
                {
                    if(campoActual.PropertyType == typeof(string))
                    {
                        query = string.Format("{0}.ToLower().Contains(@0)", nombreCampo);
                        IQueryable<T> x =l.AsQueryable<T>().Where(query, cont.Text.ToLower());
                        x=l.Where(x=>x.)
                        if (x == null || x. == 0)
                            l = null;
                        l = x.ToList();
                    }                    
                }*/


            }
            if (!string.IsNullOrEmpty(_where))
            {
                CargarGrid();
                Estado = Estados.Filtrado;
            }
            return;
        }

        private void btnqFiltro_Click(object sender, EventArgs e)
        {
            QuitarFiltro();
        }

        private void QuitarFiltro()
        {
            foreach (Control c in this.panelFiltro.Controls)
            {
                c.ResetText();
            }
            foreach (Control c in this.panelHeader.Controls)
            {
                c.ResetText();
            }
            _where = null;
            CargarGrid();
            Estado = Estados.SinFiltrar;
        }

        private void DataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            ExportadorDatos.ExportarDataGridAExcel(DataGridView1);
            Cursor.Current = Cursors.Default;         

        }


        private void btnExportarAExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ExportadorDatos.ExportarDataGridAExcel(DataGridView1);
            Cursor.Current = Cursors.Default;
        }

        protected override void CargarFormulario()
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;
            base.CargarFormulario();
            InicializarGrid();
            InicilizarFiltro();
            InicializarForm();
            InicializarDesplegables();
            CargarGrid();
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString() + e.ColumnIndex.ToString());
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlarDobleClickGrid(e);
        }

        protected virtual void ControlarDobleClickGrid(DataGridViewCellEventArgs e)
        {
            return;
            //throw new NotImplementedException();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaPacientes();
        }

        protected virtual void AltaPacientes()
        {
            throw new NotImplementedException();
        }


    }
}
