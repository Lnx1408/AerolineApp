
namespace AerolineApp
{
    partial class frmDestinoModificar
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.pboxFotoDestino = new System.Windows.Forms.PictureBox();
            this.txtADestino = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtNDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btmConfirmar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 59);
            this.label1.TabIndex = 13;
            this.label1.Text = "MODIFICAR LUGAR DESTINO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnVolver.Location = new System.Drawing.Point(730, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(67, 59);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AerolineApp.Properties.Resources.fondoDestinos;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btModificar);
            this.panel1.Controls.Add(this.btmConfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 457);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSeleccionarFoto);
            this.groupBox1.Controls.Add(this.pboxFotoDestino);
            this.groupBox1.Controls.Add(this.txtADestino);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.txtNDestino);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.groupBox1.Location = new System.Drawing.Point(89, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 224);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR DATOS";
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnSeleccionarFoto.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarFoto.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(427, 145);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(154, 31);
            this.btnSeleccionarFoto.TabIndex = 7;
            this.btnSeleccionarFoto.Text = "Seleccionar Foto";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = false;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);
            // 
            // pboxFotoDestino
            // 
            this.pboxFotoDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxFotoDestino.Location = new System.Drawing.Point(427, 35);
            this.pboxFotoDestino.Name = "pboxFotoDestino";
            this.pboxFotoDestino.Size = new System.Drawing.Size(154, 102);
            this.pboxFotoDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFotoDestino.TabIndex = 6;
            this.pboxFotoDestino.TabStop = false;
            // 
            // txtADestino
            // 
            this.txtADestino.Location = new System.Drawing.Point(203, 153);
            this.txtADestino.Name = "txtADestino";
            this.txtADestino.Size = new System.Drawing.Size(183, 23);
            this.txtADestino.TabIndex = 3;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(203, 114);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(183, 23);
            this.txtCiudad.TabIndex = 2;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(203, 75);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(183, 23);
            this.txtPais.TabIndex = 1;
            // 
            // txtNDestino
            // 
            this.txtNDestino.Enabled = false;
            this.txtNDestino.Location = new System.Drawing.Point(203, 35);
            this.txtNDestino.Name = "txtNDestino";
            this.txtNDestino.Size = new System.Drawing.Size(183, 23);
            this.txtNDestino.TabIndex = 5;
            this.txtNDestino.Text = "0";
            this.txtNDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Aeropuerto Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "N° Destino";
            // 
            // btModificar
            // 
            this.btModificar.AutoSize = true;
            this.btModificar.BackColor = System.Drawing.Color.Transparent;
            this.btModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Image = global::AerolineApp.Properties.Resources.ModificarIcon;
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btModificar.Location = new System.Drawing.Point(280, 344);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(109, 74);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "EDITAR";
            this.btModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btmConfirmar
            // 
            this.btmConfirmar.AutoSize = true;
            this.btmConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btmConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmConfirmar.FlatAppearance.BorderSize = 0;
            this.btmConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btmConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmConfirmar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmConfirmar.Image = global::AerolineApp.Properties.Resources.GuardarIcon;
            this.btmConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btmConfirmar.Location = new System.Drawing.Point(425, 344);
            this.btmConfirmar.Name = "btmConfirmar";
            this.btmConfirmar.Size = new System.Drawing.Size(109, 74);
            this.btmConfirmar.TabIndex = 7;
            this.btmConfirmar.Text = "CONFIRMAR";
            this.btmConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmConfirmar.UseVisualStyleBackColor = false;
            this.btmConfirmar.Click += new System.EventHandler(this.btmConfirmar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDestinoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 457);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDestinoModificar";
            this.Text = "frmDestinoModificar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.PictureBox pboxFotoDestino;
        private System.Windows.Forms.TextBox txtADestino;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtNDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btmConfirmar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}