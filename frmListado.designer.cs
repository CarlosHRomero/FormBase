namespace FormBase
{
    partial class frmListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRoll2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stlEstado = new System.Windows.Forms.Label();
            this.gridNavigator1 = new GridNavigator.GridNavigator();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.txtPad = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdmFrm = new System.Windows.Forms.ToolStripButton();
            this.btnExportarAExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAbm = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnVer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModif = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.btnqFiltro = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoll2
            // 
            this.btnRoll2.FlatAppearance.BorderSize = 0;
            this.btnRoll2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll2.Image = ((System.Drawing.Image)(resources.GetObject("btnRoll2.Image")));
            this.btnRoll2.Location = new System.Drawing.Point(415, 117);
            this.btnRoll2.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoll2.Name = "btnRoll2";
            this.btnRoll2.Size = new System.Drawing.Size(20, 19);
            this.btnRoll2.TabIndex = 28;
            this.btnRoll2.Text = "\r\n";
            this.btnRoll2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stlEstado);
            this.panel3.Controls.Add(this.gridNavigator1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 22);
            this.panel3.TabIndex = 27;
            // 
            // stlEstado
            // 
            this.stlEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stlEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.stlEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlEstado.ForeColor = System.Drawing.Color.Maroon;
            this.stlEstado.Location = new System.Drawing.Point(207, 0);
            this.stlEstado.Name = "stlEstado";
            this.stlEstado.Size = new System.Drawing.Size(125, 22);
            this.stlEstado.TabIndex = 2;
            this.stlEstado.Text = "label1";
            this.stlEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridNavigator1
            // 
            this.gridNavigator1.DataSource = this.DataGridView1;
            this.gridNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridNavigator1.Location = new System.Drawing.Point(0, 0);
            this.gridNavigator1.Name = "gridNavigator1";
            this.gridNavigator1.Size = new System.Drawing.Size(207, 22);
            this.gridNavigator1.TabIndex = 0;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(100, 62);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(564, 150);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.DataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseDoubleClick);
            this.DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            this.DataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.DataGridView1_SortCompare);
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.panelFiltro);
            this.panelHeader.Controls.Add(this.ToolStrip1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(906, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.txtPad);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFiltro.Location = new System.Drawing.Point(0, 27);
            this.panelFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(904, 21);
            this.panelFiltro.TabIndex = 22;
            // 
            // txtPad
            // 
            this.txtPad.BackColor = System.Drawing.SystemColors.Control;
            this.txtPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPad.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPad.Enabled = false;
            this.txtPad.Location = new System.Drawing.Point(0, 0);
            this.txtPad.Margin = new System.Windows.Forms.Padding(2);
            this.txtPad.Name = "txtPad";
            this.txtPad.Size = new System.Drawing.Size(31, 21);
            this.txtPad.TabIndex = 16;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdmFrm,
            this.btnExportarAExcel,
            this.btnAbm,
            this.btnFiltrar,
            this.btnqFiltro,
            this.ToolStripButton3,
            this.ToolStripButton5,
            this.btnSalir});
            this.ToolStrip1.Location = new System.Drawing.Point(671, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(235, 27);
            this.ToolStrip1.TabIndex = 0;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnAdmFrm
            // 
            this.btnAdmFrm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdmFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmFrm.Image")));
            this.btnAdmFrm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdmFrm.Name = "btnAdmFrm";
            this.btnAdmFrm.Size = new System.Drawing.Size(24, 24);
            this.btnAdmFrm.Text = "ToolStripButton4";
            this.btnAdmFrm.ToolTipText = "Configuración";
            this.btnAdmFrm.Visible = false;
            // 
            // btnExportarAExcel
            // 
            this.btnExportarAExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportarAExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarAExcel.Image")));
            this.btnExportarAExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarAExcel.Name = "btnExportarAExcel";
            this.btnExportarAExcel.Size = new System.Drawing.Size(24, 24);
            this.btnExportarAExcel.Text = "ToolStripButton1";
            this.btnExportarAExcel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExportarAExcel.ToolTipText = "Exportar a Excel";
            this.btnExportarAExcel.Click += new System.EventHandler(this.btnExportarAExcel_Click);
            // 
            // btnAbm
            // 
            this.btnAbm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVer,
            this.btnAlta,
            this.btnBaja,
            this.btnModif});
            this.btnAbm.Image = ((System.Drawing.Image)(resources.GetObject("btnAbm.Image")));
            this.btnAbm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(33, 24);
            this.btnAbm.Text = "toolStripDropDownButton1";
            this.btnAbm.ToolTipText = "ABM";
            // 
            // btnVer
            // 
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(184, 26);
            this.btnVer.Text = "Ver";
            // 
            // btnAlta
            // 
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(184, 26);
            this.btnAlta.Text = "Altas";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(184, 26);
            this.btnBaja.Text = "Bajas";
            // 
            // btnModif
            // 
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(184, 26);
            this.btnModif.Text = "Modificaciones";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.DarkBlue;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(24, 24);
            this.btnFiltrar.Text = "ToolStripButton1";
            this.btnFiltrar.ToolTipText = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnqFiltro
            // 
            this.btnqFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnqFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnqFiltro.Image")));
            this.btnqFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnqFiltro.Name = "btnqFiltro";
            this.btnqFiltro.Size = new System.Drawing.Size(24, 24);
            this.btnqFiltro.Text = "ToolStripButton2";
            this.btnqFiltro.ToolTipText = "Quitar filtro";
            this.btnqFiltro.Click += new System.EventHandler(this.btnqFiltro_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton3.Enabled = false;
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.ToolStripButton3.Text = "ToolStripButton3";
            this.ToolStripButton3.ToolTipText = "Imprimir";
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton5.Image")));
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.ToolStripButton5.Text = "ToolStripButton5";
            this.ToolStripButton5.ToolTipText = "Ayuda";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(24, 24);
            this.btnSalir.Text = "ToolStripButton3";
            this.btnSalir.ToolTipText = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 217);
            this.Controls.Add(this.btnRoll2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmATCsinSg30";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFiltro.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton btnAdmFrm;
        internal System.Windows.Forms.ToolStripButton btnExportarAExcel;
        internal System.Windows.Forms.ToolStripButton btnFiltrar;
        internal System.Windows.Forms.ToolStripButton btnqFiltro;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label stlEstado;
        protected System.Windows.Forms.DataGridView DataGridView1;
        protected GridNavigator.GridNavigator gridNavigator1;
        protected System.Windows.Forms.Panel panelHeader;
        internal System.Windows.Forms.Label txtPad;
        protected System.Windows.Forms.Button btnRoll2;
        protected System.Windows.Forms.Panel panelFiltro;
        protected System.Windows.Forms.ToolStripDropDownButton btnAbm;
        protected System.Windows.Forms.ToolStripMenuItem btnVer;
        protected System.Windows.Forms.ToolStripMenuItem btnAlta;
        protected System.Windows.Forms.ToolStripMenuItem btnBaja;
        protected System.Windows.Forms.ToolStripMenuItem btnModif;
        public System.Windows.Forms.ToolStrip ToolStrip1;
    }
}