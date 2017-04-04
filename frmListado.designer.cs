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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFFObitoIni = new System.Windows.Forms.MaskedTextBox();
            this.txtFNacIni = new System.Windows.Forms.MaskedTextBox();
            this.txtFProcIni = new System.Windows.Forms.MaskedTextBox();
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.FTel = new System.Windows.Forms.TextBox();
            this.FFNacFin = new System.Windows.Forms.MaskedTextBox();
            this.txtFFObitoFin = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoProc = new DrawFlat.FlatComboBox();
            this.txtFprocFin = new System.Windows.Forms.MaskedTextBox();
            this.cboProc = new DrawFlat.FlatComboBox();
            this.FNombre = new System.Windows.Forms.TextBox();
            this.txtHCF = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stlEstado = new System.Windows.Forms.Label();
            this.gridNavigator1 = new GridNavigator.GridNavigator();
            this.btnRoll2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(100, 62);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(564, 150);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseDoubleClick);
            this.DataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.DataGridView1_SortCompare);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFFObitoIni);
            this.panel1.Controls.Add(this.txtFNacIni);
            this.panel1.Controls.Add(this.txtFProcIni);
            this.panel1.Controls.Add(this.ToolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 31);
            this.panel1.TabIndex = 0;
            // 
            // txtFFObitoIni
            // 
            this.txtFFObitoIni.BackColor = System.Drawing.Color.SkyBlue;
            this.txtFFObitoIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFFObitoIni.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFFObitoIni.Location = new System.Drawing.Point(496, 2);
            this.txtFFObitoIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtFFObitoIni.Mask = "00/00/0000";
            this.txtFFObitoIni.Name = "txtFFObitoIni";
            this.txtFFObitoIni.Size = new System.Drawing.Size(64, 20);
            this.txtFFObitoIni.TabIndex = 1;
            this.txtFFObitoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFFObitoIni.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFFObitoIni.ValidatingType = typeof(System.DateTime);
            // 
            // txtFNacIni
            // 
            this.txtFNacIni.BackColor = System.Drawing.Color.SkyBlue;
            this.txtFNacIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFNacIni.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFNacIni.Location = new System.Drawing.Point(580, 2);
            this.txtFNacIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtFNacIni.Mask = "00/00/0000";
            this.txtFNacIni.Name = "txtFNacIni";
            this.txtFNacIni.Size = new System.Drawing.Size(83, 20);
            this.txtFNacIni.TabIndex = 2;
            this.txtFNacIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFNacIni.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFNacIni.ValidatingType = typeof(System.DateTime);
            // 
            // txtFProcIni
            // 
            this.txtFProcIni.BackColor = System.Drawing.Color.SkyBlue;
            this.txtFProcIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFProcIni.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFProcIni.Location = new System.Drawing.Point(348, 6);
            this.txtFProcIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtFProcIni.Mask = "00/00/0000";
            this.txtFProcIni.Name = "txtFProcIni";
            this.txtFProcIni.Size = new System.Drawing.Size(64, 20);
            this.txtFProcIni.TabIndex = 0;
            this.txtFProcIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFProcIni.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFProcIni.ValidatingType = typeof(System.DateTime);
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
            this.ToolStrip1.Location = new System.Drawing.Point(696, 2);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(147, 27);
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
            this.btnAbm.Enabled = false;
            this.btnAbm.Image = ((System.Drawing.Image)(resources.GetObject("btnAbm.Image")));
            this.btnAbm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(33, 24);
            this.btnAbm.Text = "toolStripDropDownButton1";
            this.btnAbm.ToolTipText = "ABM";
            this.btnAbm.Visible = false;
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
            // Panel2
            // 
            this.Panel2.Controls.Add(this.FTel);
            this.Panel2.Controls.Add(this.FFNacFin);
            this.Panel2.Controls.Add(this.txtFFObitoFin);
            this.Panel2.Controls.Add(this.cboTipoProc);
            this.Panel2.Controls.Add(this.txtFprocFin);
            this.Panel2.Controls.Add(this.cboProc);
            this.Panel2.Controls.Add(this.FNombre);
            this.Panel2.Controls.Add(this.txtHCF);
            this.Panel2.Controls.Add(this.TextBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 31);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(906, 25);
            this.Panel2.TabIndex = 22;
            // 
            // FTel
            // 
            this.FTel.BackColor = System.Drawing.Color.SkyBlue;
            this.FTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FTel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FTel.Location = new System.Drawing.Point(665, 0);
            this.FTel.Margin = new System.Windows.Forms.Padding(2);
            this.FTel.Name = "FTel";
            this.FTel.Size = new System.Drawing.Size(162, 20);
            this.FTel.TabIndex = 0;
            // 
            // FFNacFin
            // 
            this.FFNacFin.BackColor = System.Drawing.Color.SkyBlue;
            this.FFNacFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FFNacFin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.FFNacFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.FFNacFin.Location = new System.Drawing.Point(581, 0);
            this.FFNacFin.Margin = new System.Windows.Forms.Padding(2);
            this.FFNacFin.Mask = "00/00/0000";
            this.FFNacFin.Name = "FFNacFin";
            this.FFNacFin.Size = new System.Drawing.Size(84, 20);
            this.FFNacFin.TabIndex = 8;
            this.FFNacFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FFNacFin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.FFNacFin.ValidatingType = typeof(System.DateTime);
            // 
            // txtFFObitoFin
            // 
            this.txtFFObitoFin.BackColor = System.Drawing.Color.SkyBlue;
            this.txtFFObitoFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFFObitoFin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFFObitoFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFFObitoFin.Location = new System.Drawing.Point(497, 0);
            this.txtFFObitoFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtFFObitoFin.Mask = "00/00/0000";
            this.txtFFObitoFin.Name = "txtFFObitoFin";
            this.txtFFObitoFin.Size = new System.Drawing.Size(84, 20);
            this.txtFFObitoFin.TabIndex = 7;
            this.txtFFObitoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFFObitoFin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFFObitoFin.ValidatingType = typeof(System.DateTime);
            // 
            // cboTipoProc
            // 
            this.cboTipoProc.BackColor = System.Drawing.Color.SkyBlue;
            this.cboTipoProc.DisplayMember = "Eqv_Val";
            this.cboTipoProc.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboTipoProc.Filtro = true;
            this.cboTipoProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProc.FormattingEnabled = true;
            this.cboTipoProc.Location = new System.Drawing.Point(413, 0);
            this.cboTipoProc.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoProc.Name = "cboTipoProc";
            this.cboTipoProc.ReadOnly = false;
            this.cboTipoProc.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cboTipoProc.ReadOnlyFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProc.ReadOnlyForeColor = System.Drawing.SystemColors.ControlText;
            this.cboTipoProc.Size = new System.Drawing.Size(84, 21);
            this.cboTipoProc.TabIndex = 6;
            this.cboTipoProc.ValueMember = "Eqv_Val";
            // 
            // txtFprocFin
            // 
            this.txtFprocFin.BackColor = System.Drawing.Color.SkyBlue;
            this.txtFprocFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFprocFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFprocFin.Location = new System.Drawing.Point(329, 0);
            this.txtFprocFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtFprocFin.Mask = "00/00/0000";
            this.txtFprocFin.Name = "txtFprocFin";
            this.txtFprocFin.Size = new System.Drawing.Size(84, 20);
            this.txtFprocFin.TabIndex = 5;
            this.txtFprocFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFprocFin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtFprocFin.ValidatingType = typeof(System.DateTime);
            // 
            // cboProc
            // 
            this.cboProc.BackColor = System.Drawing.Color.SkyBlue;
            this.cboProc.DisplayMember = "Eqv_Val";
            this.cboProc.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboProc.Filtro = true;
            this.cboProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProc.FormattingEnabled = true;
            this.cboProc.Location = new System.Drawing.Point(251, 0);
            this.cboProc.Margin = new System.Windows.Forms.Padding(2);
            this.cboProc.Name = "cboProc";
            this.cboProc.ReadOnly = false;
            this.cboProc.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.cboProc.ReadOnlyFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProc.ReadOnlyForeColor = System.Drawing.SystemColors.ControlText;
            this.cboProc.Size = new System.Drawing.Size(78, 21);
            this.cboProc.TabIndex = 3;
            this.cboProc.ValueMember = "Eqv_Val";
            // 
            // FNombre
            // 
            this.FNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.FNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.FNombre.Location = new System.Drawing.Point(91, 0);
            this.FNombre.Margin = new System.Windows.Forms.Padding(2);
            this.FNombre.Name = "FNombre";
            this.FNombre.Size = new System.Drawing.Size(160, 20);
            this.FNombre.TabIndex = 2;
            this.FNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHCF
            // 
            this.txtHCF.BackColor = System.Drawing.Color.SkyBlue;
            this.txtHCF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHCF.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtHCF.Location = new System.Drawing.Point(31, 0);
            this.txtHCF.Margin = new System.Windows.Forms.Padding(2);
            this.txtHCF.Name = "txtHCF";
            this.txtHCF.Size = new System.Drawing.Size(60, 20);
            this.txtHCF.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(31, 20);
            this.TextBox1.TabIndex = 0;
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
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 217);
            this.Controls.Add(this.btnRoll2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmATCsinSg30";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.MaskedTextBox txtFNacIni;
        internal System.Windows.Forms.MaskedTextBox txtFProcIni;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnAdmFrm;
        internal System.Windows.Forms.ToolStripButton btnExportarAExcel;
        private System.Windows.Forms.ToolStripDropDownButton btnAbm;
        private System.Windows.Forms.ToolStripMenuItem btnVer;
        private System.Windows.Forms.ToolStripMenuItem btnAlta;
        private System.Windows.Forms.ToolStripMenuItem btnBaja;
        private System.Windows.Forms.ToolStripMenuItem btnModif;
        internal System.Windows.Forms.ToolStripButton btnFiltrar;
        internal System.Windows.Forms.ToolStripButton btnqFiltro;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton btnSalir;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox FTel;
        internal System.Windows.Forms.MaskedTextBox FFNacFin;
        internal DrawFlat.FlatComboBox cboTipoProc;
        internal System.Windows.Forms.MaskedTextBox txtFprocFin;
        internal DrawFlat.FlatComboBox cboProc;
        internal System.Windows.Forms.TextBox FNombre;
        internal System.Windows.Forms.TextBox txtHCF;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label stlEstado;
        internal System.Windows.Forms.Button btnRoll2;
        protected System.Windows.Forms.DataGridView DataGridView1;
        protected GridNavigator.GridNavigator gridNavigator1;
        internal System.Windows.Forms.MaskedTextBox txtFFObitoIni;
        internal System.Windows.Forms.MaskedTextBox txtFFObitoFin;
    }
}