
namespace AerolineApp
{
    partial class FrmDestinos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtADestino = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtNDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btmGuardar = new System.Windows.Forms.Button();
            this.PboxDestino = new System.Windows.Forms.PictureBox();
            this.monthCalendarFechaLlegada = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESTINOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.monthCalendarFechaLlegada);
            this.groupBox1.Controls.Add(this.txtADestino);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.txtNDestino);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.groupBox1.Location = new System.Drawing.Point(197, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR DATOS";
            // 
            // txtADestino
            // 
            this.txtADestino.Location = new System.Drawing.Point(182, 121);
            this.txtADestino.Name = "txtADestino";
            this.txtADestino.Size = new System.Drawing.Size(248, 23);
            this.txtADestino.TabIndex = 3;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(182, 92);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(248, 23);
            this.txtCiudad.TabIndex = 2;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(182, 63);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(248, 23);
            this.txtPais.TabIndex = 1;
            // 
            // txtNDestino
            // 
            this.txtNDestino.Enabled = false;
            this.txtNDestino.Location = new System.Drawing.Point(182, 33);
            this.txtNDestino.Name = "txtNDestino";
            this.txtNDestino.Size = new System.Drawing.Size(248, 23);
            this.txtNDestino.TabIndex = 5;
            this.txtNDestino.Text = "0";
            this.txtNDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Aeropuerto Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "N° Destino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineApp.Properties.Resources.Consultar_mapas;
            this.pictureBox1.Location = new System.Drawing.Point(2, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 143);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::AerolineApp.Properties.Resources.BTVolverCU_1;
            this.btnVolver.Location = new System.Drawing.Point(770, -1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(67, 59);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.AutoSize = true;
            this.btConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Image = global::AerolineApp.Properties.Resources.ConsultarIcon;
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConsultar.Location = new System.Drawing.Point(448, 450);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(107, 74);
            this.btConsultar.TabIndex = 6;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            this.btConsultar.MouseEnter += new System.EventHandler(this.btConsultar_MouseEnter);
            this.btConsultar.MouseLeave += new System.EventHandler(this.btConsultar_MouseLeave);
            // 
            // btmGuardar
            // 
            this.btmGuardar.AutoSize = true;
            this.btmGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btmGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmGuardar.FlatAppearance.BorderSize = 0;
            this.btmGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmGuardar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGuardar.Image = global::AerolineApp.Properties.Resources.GuardarIcon;
            this.btmGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmGuardar.Location = new System.Drawing.Point(296, 450);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(105, 74);
            this.btmGuardar.TabIndex = 5;
            this.btmGuardar.Text = "REGISTRAR";
            this.btmGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmGuardar.UseVisualStyleBackColor = false;
            this.btmGuardar.Click += new System.EventHandler(this.btmGuardar_Click);
            this.btmGuardar.MouseEnter += new System.EventHandler(this.btmGuardar_MouseEnter);
            this.btmGuardar.MouseLeave += new System.EventHandler(this.btmGuardar_MouseLeave);
            // 
            // PboxDestino
            // 
            this.PboxDestino.BackColor = System.Drawing.Color.Transparent;
            this.PboxDestino.Image = global::AerolineApp.Properties.Resources.RutaIMG;
            this.PboxDestino.Location = new System.Drawing.Point(647, 357);
            this.PboxDestino.Name = "PboxDestino";
            this.PboxDestino.Size = new System.Drawing.Size(190, 188);
            this.PboxDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PboxDestino.TabIndex = 0;
            this.PboxDestino.TabStop = false;
            // 
            // monthCalendarFechaLlegada
            // 
            this.monthCalendarFechaLlegada.Location = new System.Drawing.Point(182, 151);
            this.monthCalendarFechaLlegada.MaxSelectionCount = 1;
            this.monthCalendarFechaLlegada.Name = "monthCalendarFechaLlegada";
            this.monthCalendarFechaLlegada.TabIndex = 6;
            this.monthCalendarFechaLlegada.TodayDate = new System.DateTime(2021, 9, 2, 0, 0, 0, 0);
            // 
            // FrmDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PboxDestino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btmGuardar);
            this.Name = "FrmDestinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar un nuevo lugar de destino";
            this.Shown += new System.EventHandler(this.FrmDestinos_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmGuardar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PboxDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtADestino;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtNDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaLlegada;
    }
}