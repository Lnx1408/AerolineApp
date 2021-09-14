namespace AerolineApp
{
    partial class frmFlotaAviones
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
            this.pctAvion = new System.Windows.Forms.PictureBox();
            this.pctModelo = new System.Windows.Forms.PictureBox();
            this.labelModeloText = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAvion
            // 
            this.pctAvion.Image = global::AerolineApp.Properties.Resources.plane3;
            this.pctAvion.Location = new System.Drawing.Point(-2, 0);
            this.pctAvion.Name = "pctAvion";
            this.pctAvion.Size = new System.Drawing.Size(931, 658);
            this.pctAvion.TabIndex = 0;
            this.pctAvion.TabStop = false;
            // 
            // pctModelo
            // 
            this.pctModelo.Image = global::AerolineApp.Properties.Resources.modeloAvion;
            this.pctModelo.Location = new System.Drawing.Point(928, 0);
            this.pctModelo.Name = "pctModelo";
            this.pctModelo.Size = new System.Drawing.Size(420, 658);
            this.pctModelo.TabIndex = 1;
            this.pctModelo.TabStop = false;
            // 
            // labelModeloText
            // 
            this.labelModeloText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelModeloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModeloText.Location = new System.Drawing.Point(1000, 34);
            this.labelModeloText.Name = "labelModeloText";
            this.labelModeloText.Size = new System.Drawing.Size(295, 29);
            this.labelModeloText.TabIndex = 2;
            this.labelModeloText.Text = "MODELO";
            this.labelModeloText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Orange;
            this.lblModelo.Location = new System.Drawing.Point(972, 103);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(352, 37);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.ForeColor = System.Drawing.Color.Orange;
            this.txtCapacidad.Location = new System.Drawing.Point(977, 521);
            this.txtCapacidad.Multiline = true;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(331, 30);
            this.txtCapacidad.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.Color.Orange;
            this.txtAltura.Location = new System.Drawing.Point(977, 386);
            this.txtAltura.Multiline = true;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(294, 30);
            this.txtAltura.TabIndex = 5;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVelocidad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidad.ForeColor = System.Drawing.Color.Orange;
            this.txtVelocidad.Location = new System.Drawing.Point(977, 251);
            this.txtVelocidad.Multiline = true;
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(300, 30);
            this.txtVelocidad.TabIndex = 6;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(179)))));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(967, 579);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(148, 40);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(179)))));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(1166, 579);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(148, 40);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmFlotaAviones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1347, 653);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.labelModeloText);
            this.Controls.Add(this.pctAvion);
            this.Controls.Add(this.pctModelo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFlotaAviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFlotaAvionescs";
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAvion;
        private System.Windows.Forms.PictureBox pctModelo;
        private System.Windows.Forms.Label labelModeloText;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}