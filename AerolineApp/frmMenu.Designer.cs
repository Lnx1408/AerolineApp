namespace AerolineApp
{
    partial class frmMenu
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lbDestinos = new System.Windows.Forms.Label();
            this.lbFlotaAviones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDestinos = new System.Windows.Forms.PictureBox();
            this.pbFlota = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDestinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelContainer.Controls.Add(this.lbDestinos);
            this.panelContainer.Controls.Add(this.lbFlotaAviones);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.pbDestinos);
            this.panelContainer.Controls.Add(this.pbFlota);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.panelContainer.Location = new System.Drawing.Point(2, 1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(509, 590);
            this.panelContainer.TabIndex = 1;
            // 
            // lbDestinos
            // 
            this.lbDestinos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(145)))));
            this.lbDestinos.Location = new System.Drawing.Point(225, 480);
            this.lbDestinos.Name = "lbDestinos";
            this.lbDestinos.Size = new System.Drawing.Size(96, 23);
            this.lbDestinos.TabIndex = 12;
            this.lbDestinos.Text = "Destinos";
            this.lbDestinos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDestinos.Click += new System.EventHandler(this.label3_Click);
            this.lbDestinos.MouseEnter += new System.EventHandler(this.lbDestinos_MouseEnter);
            this.lbDestinos.MouseLeave += new System.EventHandler(this.lbDestinos_MouseLeave);
            // 
            // lbFlotaAviones
            // 
            this.lbFlotaAviones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFlotaAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFlotaAviones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlotaAviones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(145)))));
            this.lbFlotaAviones.Location = new System.Drawing.Point(210, 276);
            this.lbFlotaAviones.Name = "lbFlotaAviones";
            this.lbFlotaAviones.Size = new System.Drawing.Size(193, 23);
            this.lbFlotaAviones.TabIndex = 11;
            this.lbFlotaAviones.Text = "Flota de aviones";
            this.lbFlotaAviones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFlotaAviones.Click += new System.EventHandler(this.label2_Click);
            this.lbFlotaAviones.MouseEnter += new System.EventHandler(this.lbFlotaAviones_MouseEnter);
            this.lbFlotaAviones.MouseLeave += new System.EventHandler(this.lbFlotaAviones_MouseLeave);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(210, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comprar boleto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pbDestinos
            // 
            this.pbDestinos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDestinos.Image = global::AerolineApp.Properties.Resources.destino;
            this.pbDestinos.Location = new System.Drawing.Point(84, 450);
            this.pbDestinos.Name = "pbDestinos";
            this.pbDestinos.Size = new System.Drawing.Size(96, 96);
            this.pbDestinos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDestinos.TabIndex = 8;
            this.pbDestinos.TabStop = false;
            this.pbDestinos.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pbDestinos.MouseEnter += new System.EventHandler(this.pbDestinos_MouseEnter);
            this.pbDestinos.MouseLeave += new System.EventHandler(this.pbDestinos_MouseLeave);
            // 
            // pbFlota
            // 
            this.pbFlota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlota.Image = global::AerolineApp.Properties.Resources.flota;
            this.pbFlota.Location = new System.Drawing.Point(84, 251);
            this.pbFlota.Name = "pbFlota";
            this.pbFlota.Size = new System.Drawing.Size(96, 96);
            this.pbFlota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFlota.TabIndex = 7;
            this.pbFlota.TabStop = false;
            this.pbFlota.Click += new System.EventHandler(this.pbFlota_Click);
            this.pbFlota.MouseEnter += new System.EventHandler(this.pbFlota_MouseEnter);
            this.pbFlota.MouseLeave += new System.EventHandler(this.pbFlota_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AerolineApp.Properties.Resources.compra;
            this.pictureBox1.Location = new System.Drawing.Point(84, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pbFlota_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(509, 582);
            this.Controls.Add(this.panelContainer);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de opciones";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDestinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbDestinos;
        private System.Windows.Forms.Label lbFlotaAviones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDestinos;
        private System.Windows.Forms.PictureBox pbFlota;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}