using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Generales;

namespace FormBase
{
    public partial class frmListado : Form
    {
        Estados _estado = Estados.SinFiltrar;

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

        public frmListado()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;
            Width = 950;
            Height = 650;
            InicializarGrid();
            InicilizarFiltro();
        }

        private void InicilizarFiltro()
        {
            this.TextBox1.Width = this.DataGridView1.RowHeadersWidth;
            this.txtHCF.Width = this.DataGridView1.Columns[0].Width;
            this.FNombre.Width = this.DataGridView1.Columns[1].Width;
            this.cboProc.Width = this.DataGridView1.Columns[2].Width;

            this.cboTipoProc.Width = this.DataGridView1.Columns[3].Width;
            txtFprocFin.Width = DataGridView1.Columns[4].Width;
            txtFFObitoFin.Width = DataGridView1.Columns[5].Width;
            txtFFObitoIni.Width = DataGridView1.Columns[5].Width;
            this.FFNacFin.Width = this.DataGridView1.Columns[6].Width;
            this.FTel.Width = this.DataGridView1.Columns[7].Width;
            Point locFn = new Point
            {
                X = this.FFNacFin.Location.X,
                Y = 3
            };
            txtFNacIni.Location = locFn;
            txtFNacIni.Width = this.FFNacFin.Width;
            txtFProcIni.Location = new Point {X = txtFprocFin.Location.X, Y = 3};
            txtFFObitoIni.Location = new Point(txtFFObitoFin.Location.X, 3);
            txtFProcIni.Width = txtFprocFin.Width;
            ToolStrip1.Location = new Point(txtFNacIni.Location.X + txtFNacIni.Width + 15, 1);
        }

        private void InicializarGrid()
        {
        }

        private void InicializarDesplegables()
        {
        }


        protected virtual void CargarGrid()
        {
            throw new NotImplementedException();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        void CargarArbol(int procId, int pacId)
        {

        }

        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "FNac" || e.Column.Name == "FProc")
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
            Filtrar();
        }
        private string _where;

        public string Where
        {
            get { return _where; }
            set { _where = value; }
        }

        private string Nombre { get; set; }
        
        private void Filtrar()
        {
        }

        private void btnqFiltro_Click(object sender, EventArgs e)
        {
            QuitarFiltro();
        }

        private void QuitarFiltro()
        {
            foreach (Control c in this.Panel2.Controls)
            {
                c.ResetText();
            }
            Where = null;
            CargarGrid();
            Estado= Estados.SinFiltrar;
        }

        private void DataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void btnExportarAExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ExportadorDatos.ExportarDataGridAExcel(DataGridView1);
            Cursor.Current = Cursors.Default;
        }


    }
}
