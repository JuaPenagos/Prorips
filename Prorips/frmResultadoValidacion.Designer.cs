namespace Prorips
{
    partial class frmResultadoValidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadoValidacion));
            this.txtNumeroLienas = new System.Windows.Forms.TextBox();
            this.txtListaArchivos = new System.Windows.Forms.TextBox();
            this.txtListaErrores = new System.Windows.Forms.TextBox();
            this.lblListaErrores = new System.Windows.Forms.Label();
            this.lblNumeroArchivos = new System.Windows.Forms.Label();
            this.lblListaArchivos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroLienas
            // 
            this.txtNumeroLienas.Location = new System.Drawing.Point(15, 80);
            this.txtNumeroLienas.Name = "txtNumeroLienas";
            this.txtNumeroLienas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroLienas.TabIndex = 0;
            // 
            // txtListaArchivos
            // 
            this.txtListaArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtListaArchivos.Location = new System.Drawing.Point(15, 151);
            this.txtListaArchivos.Multiline = true;
            this.txtListaArchivos.Name = "txtListaArchivos";
            this.txtListaArchivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaArchivos.Size = new System.Drawing.Size(470, 245);
            this.txtListaArchivos.TabIndex = 1;
            // 
            // txtListaErrores
            // 
            this.txtListaErrores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListaErrores.Location = new System.Drawing.Point(545, 151);
            this.txtListaErrores.Multiline = true;
            this.txtListaErrores.Name = "txtListaErrores";
            this.txtListaErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaErrores.Size = new System.Drawing.Size(470, 245);
            this.txtListaErrores.TabIndex = 2;
            // 
            // lblListaErrores
            // 
            this.lblListaErrores.AutoSize = true;
            this.lblListaErrores.Location = new System.Drawing.Point(542, 118);
            this.lblListaErrores.Name = "lblListaErrores";
            this.lblListaErrores.Size = new System.Drawing.Size(92, 13);
            this.lblListaErrores.TabIndex = 3;
            this.lblListaErrores.Text = "Listado de Errores";
            // 
            // lblNumeroArchivos
            // 
            this.lblNumeroArchivos.AutoSize = true;
            this.lblNumeroArchivos.Location = new System.Drawing.Point(12, 55);
            this.lblNumeroArchivos.Name = "lblNumeroArchivos";
            this.lblNumeroArchivos.Size = new System.Drawing.Size(103, 13);
            this.lblNumeroArchivos.TabIndex = 4;
            this.lblNumeroArchivos.Text = "Numero de Archivos";
            // 
            // lblListaArchivos
            // 
            this.lblListaArchivos.AutoSize = true;
            this.lblListaArchivos.Location = new System.Drawing.Point(12, 118);
            this.lblListaArchivos.Name = "lblListaArchivos";
            this.lblListaArchivos.Size = new System.Drawing.Size(88, 13);
            this.lblListaArchivos.TabIndex = 5;
            this.lblListaArchivos.Text = "Lista de Archivos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 26);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(15, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 27);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resultado Validacion Inicial";
            // 
            // frmResultadoValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1054, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblListaArchivos);
            this.Controls.Add(this.lblNumeroArchivos);
            this.Controls.Add(this.lblListaErrores);
            this.Controls.Add(this.txtListaErrores);
            this.Controls.Add(this.txtListaArchivos);
            this.Controls.Add(this.txtNumeroLienas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultadoValidacion";
            this.Text = "frmResultadoValidacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResultadoValidacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroLienas;
        private System.Windows.Forms.TextBox txtListaArchivos;
        private System.Windows.Forms.TextBox txtListaErrores;
        private System.Windows.Forms.Label lblListaErrores;
        private System.Windows.Forms.Label lblNumeroArchivos;
        private System.Windows.Forms.Label lblListaArchivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}