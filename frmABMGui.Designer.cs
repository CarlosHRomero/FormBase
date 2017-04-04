namespace FormBase
{
    partial class frmABMGui
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMGui));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConfig = new System.Windows.Forms.ToolStripButton();
            this.btnVer = new System.Windows.Forms.ToolStripButton();
            this.btnModif = new System.Windows.Forms.ToolStripButton();
            this.btnBaja = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.btnValidar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tpValidar = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 45);
            this.panel1.TabIndex = 0;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfig,
            this.btnVer,
            this.btnModif,
            this.btnBaja,
            this.ToolStripButton6,
            this.btnSalir});
            this.ToolStrip1.Location = new System.Drawing.Point(581, 7);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(226, 37);
            this.ToolStrip1.TabIndex = 15;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = false;
            this.btnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(30, 30);
            this.btnConfig.Text = "ToolStripButton2";
            this.btnConfig.ToolTipText = "Configuracion";
            // 
            // btnVer
            // 
            this.btnVer.AutoSize = false;
            this.btnVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(28, 28);
            this.btnVer.Text = "ToolStripButton3";
            this.btnVer.ToolTipText = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModif
            // 
            this.btnModif.AutoSize = false;
            this.btnModif.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModif.Image = ((System.Drawing.Image)(resources.GetObject("btnModif.Image")));
            this.btnModif.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModif.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(30, 30);
            this.btnModif.Text = "ToolStripButton4";
            this.btnModif.ToolTipText = "Modificar";
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.AutoSize = false;
            this.btnBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(30, 30);
            this.btnBaja.Text = "Baja";
            this.btnBaja.ToolTipText = "Borrar";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.AutoSize = false;
            this.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton6.Enabled = false;
            this.ToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton6.Image")));
            this.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(30, 30);
            this.ToolStripButton6.Text = "ToolStripButton6";
            this.ToolStripButton6.ToolTipText = "Ayuda";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.Text = "ToolStripButton7";
            this.btnSalir.ToolTipText = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.toolStrip2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 295);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(816, 47);
            this.Panel2.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.btnValidar,
            this.btnCancelar,
            this.btnGuardar});
            this.toolStrip2.Location = new System.Drawing.Point(661, 7);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(87, 31);
            this.toolStrip2.TabIndex = 66;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Visible = false;
            // 
            // btnValidar
            // 
            this.btnValidar.AutoSize = false;
            this.btnValidar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnValidar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(28, 28);
            this.btnValidar.Text = "toolStripButton9";
            this.btnValidar.ToolTipText = "Validar";
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(28, 28);
            this.btnCancelar.Text = "toolStripButton10";
            this.btnCancelar.ToolTipText = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(28, 28);
            this.btnGuardar.Text = "toolStripButton11";
            this.btnGuardar.ToolTipText = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tpValidar);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 45);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(816, 250);
            this.TabControl1.TabIndex = 3;
            // 
            // tpValidar
            // 
            this.tpValidar.Location = new System.Drawing.Point(4, 22);
            this.tpValidar.Name = "tpValidar";
            this.tpValidar.Padding = new System.Windows.Forms.Padding(3);
            this.tpValidar.Size = new System.Drawing.Size(808, 224);
            this.tpValidar.TabIndex = 0;
            this.tpValidar.Text = "Validar";
            this.tpValidar.UseVisualStyleBackColor = true;
            // 
            // frmABMGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(816, 342);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmABMGui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmABMGui_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnConfig;
        internal System.Windows.Forms.ToolStripButton btnVer;
        internal System.Windows.Forms.ToolStripButton btnModif;
        internal System.Windows.Forms.ToolStripButton btnBaja;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton btnValidar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.TabPage tpValidar;
        protected System.Windows.Forms.TabControl TabControl1;
    }
}
