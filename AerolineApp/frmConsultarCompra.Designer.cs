
namespace AerolineApp
{
    partial class frmConsultarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCompra));
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombres,
            this.apellidos,
            this.NumPas,
            this.sexo,
            this.nacionalidad,
            this.provincia,
            this.cantones,
            this.FechaIda,
            this.fechaRegreso,
            this.precio});
            this.dgv_listarTodos.Location = new System.Drawing.Point(12, 140);
            this.dgv_listarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.RowHeadersWidth = 51;
            this.dgv_listarTodos.RowTemplate.Height = 24;
            this.dgv_listarTodos.Size = new System.Drawing.Size(1129, 209);
            this.dgv_listarTodos.TabIndex = 55;
            this.dgv_listarTodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listarTodos_CellContentClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 125;
            // 
            // nombres
            // 
            this.nombres.HeaderText = "Nombres";
            this.nombres.MinimumWidth = 6;
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 125;
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.MinimumWidth = 6;
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 125;
            // 
            // NumPas
            // 
            this.NumPas.HeaderText = "Numero de Pasajeros";
            this.NumPas.MinimumWidth = 6;
            this.NumPas.Name = "NumPas";
            this.NumPas.ReadOnly = true;
            this.NumPas.Width = 90;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Clase";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 125;
            // 
            // nacionalidad
            // 
            this.nacionalidad.HeaderText = "Pais";
            this.nacionalidad.MinimumWidth = 6;
            this.nacionalidad.Name = "nacionalidad";
            this.nacionalidad.ReadOnly = true;
            this.nacionalidad.Width = 125;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Origen";
            this.provincia.MinimumWidth = 6;
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 125;
            // 
            // cantones
            // 
            this.cantones.HeaderText = "Destino";
            this.cantones.MinimumWidth = 6;
            this.cantones.Name = "cantones";
            this.cantones.ReadOnly = true;
            this.cantones.Width = 125;
            // 
            // FechaIda
            // 
            this.FechaIda.HeaderText = "Fecha de Ida";
            this.FechaIda.MinimumWidth = 6;
            this.FechaIda.Name = "FechaIda";
            this.FechaIda.ReadOnly = true;
            this.FechaIda.Width = 200;
            // 
            // fechaRegreso
            // 
            this.fechaRegreso.HeaderText = "Fecha de Regreso";
            this.fechaRegreso.MinimumWidth = 6;
            this.fechaRegreso.Name = "fechaRegreso";
            this.fechaRegreso.ReadOnly = true;
            this.fechaRegreso.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label5.Location = new System.Drawing.Point(575, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Regresar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(830, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmConsultarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 455);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmConsultarCompra";
            this.Text = "frmConsultarCompra";
            this.Load += new System.EventHandler(this.frmConsultarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPas;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantones;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIda;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}