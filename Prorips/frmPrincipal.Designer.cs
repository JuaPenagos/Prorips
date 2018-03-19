namespace Prorips
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlPaginas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInformes = new System.Windows.Forms.Button();
            this.menuStripInformes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informeErroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCorregir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreCompañia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStripInformes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlPaginas
            // 
            this.pnlPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaginas.AutoSize = true;
            this.pnlPaginas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPaginas.Location = new System.Drawing.Point(0, 63);
            this.pnlPaginas.Name = "pnlPaginas";
            this.pnlPaginas.Size = new System.Drawing.Size(923, 457);
            this.pnlPaginas.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnInformes);
            this.panel1.Controls.Add(this.btnCargarArchivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnCorregir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 60);
            this.panel1.TabIndex = 4;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Teal;
            this.btnInformes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInformes.BackgroundImage")));
            this.btnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInformes.ContextMenuStrip = this.menuStripInformes;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInformes.Location = new System.Drawing.Point(128, 2);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(58, 57);
            this.btnInformes.TabIndex = 12;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInformes.UseVisualStyleBackColor = false;
            // 
            // menuStripInformes
            // 
            this.menuStripInformes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem1,
            this.informeErroresToolStripMenuItem});
            this.menuStripInformes.Name = "menuStripInformes";
            this.menuStripInformes.Size = new System.Drawing.Size(156, 48);
            // 
            // StripMenuItem1
            // 
            this.StripMenuItem1.Name = "StripMenuItem1";
            this.StripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.StripMenuItem1.Text = "Informe Diario";
            // 
            // informeErroresToolStripMenuItem
            // 
            this.informeErroresToolStripMenuItem.Name = "informeErroresToolStripMenuItem";
            this.informeErroresToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.informeErroresToolStripMenuItem.Text = "Informe Errores";
            this.informeErroresToolStripMenuItem.Click += new System.EventHandler(this.informeErroresToolStripMenuItem_Click);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnCargarArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarArchivo.BackgroundImage")));
            this.btnCargarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarArchivo.Location = new System.Drawing.Point(0, 2);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(58, 57);
            this.btnCargarArchivo.TabIndex = 10;
            this.btnCargarArchivo.Text = "Cargar";
            this.btnCargarArchivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(578, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Centro de salud la colina";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAyuda.BackColor = System.Drawing.Color.Teal;
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAyuda.Location = new System.Drawing.Point(866, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(54, 54);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnCorregir
            // 
            this.btnCorregir.BackColor = System.Drawing.Color.Teal;
            this.btnCorregir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorregir.BackgroundImage")));
            this.btnCorregir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCorregir.Enabled = false;
            this.btnCorregir.FlatAppearance.BorderSize = 0;
            this.btnCorregir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorregir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorregir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCorregir.Location = new System.Drawing.Point(64, 2);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(58, 57);
            this.btnCorregir.TabIndex = 6;
            this.btnCorregir.Text = "Corregir";
            this.btnCorregir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorregir.UseVisualStyleBackColor = false;
            this.btnCorregir.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblNombreCompañia);
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 20);
            this.panel2.TabIndex = 9;
            // 
            // lblNombreCompañia
            // 
            this.lblNombreCompañia.AutoSize = true;
            this.lblNombreCompañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompañia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreCompañia.Location = new System.Drawing.Point(538, 0);
            this.lblNombreCompañia.Name = "lblNombreCompañia";
            this.lblNombreCompañia.Size = new System.Drawing.Size(176, 13);
            this.lblNombreCompañia.TabIndex = 9;
            this.lblNombreCompañia.Text = "Nombre de la compañia S.A.S";
            // 
            // frmPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(921, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPaginas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProRips";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStripInformes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Panel pnlPaginas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCorregir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombreCompañia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.ContextMenuStrip menuStripInformes;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informeErroresToolStripMenuItem;
    }
}

