
namespace AerolineApp
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtida = new System.Windows.Forms.Label();
            this.dtFechaIda = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbEjecutiva = new System.Windows.Forms.RadioButton();
            this.cboxPaisOrigen = new System.Windows.Forms.ComboBox();
            this.rbPrimeraClase = new System.Windows.Forms.RadioButton();
            this.rbEconomica = new System.Windows.Forms.RadioButton();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumPas = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.cmdregistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrigen = new System.Windows.Forms.DataGridView();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxPaisDestino = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label11.Location = new System.Drawing.Point(852, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 119;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label10.Location = new System.Drawing.Point(859, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 117;
            this.label10.Text = "Valor total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label9.Location = new System.Drawing.Point(871, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 116;
            this.label9.Text = "Regreso";
            // 
            // dtFechaRegreso
            // 
            this.dtFechaRegreso.Location = new System.Drawing.Point(801, 289);
            this.dtFechaRegreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaRegreso.Name = "dtFechaRegreso";
            this.dtFechaRegreso.Size = new System.Drawing.Size(200, 22);
            this.dtFechaRegreso.TabIndex = 115;
            this.dtFechaRegreso.ValueChanged += new System.EventHandler(this.dtFechaRegreso_ValueChanged_1);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(875, 402);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(79, 22);
            this.txtPrecio.TabIndex = 118;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtida
            // 
            this.txtida.AutoSize = true;
            this.txtida.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.txtida.Location = new System.Drawing.Point(885, 91);
            this.txtida.Name = "txtida";
            this.txtida.Size = new System.Drawing.Size(36, 21);
            this.txtida.TabIndex = 114;
            this.txtida.Text = "Ida";
            // 
            // dtFechaIda
            // 
            this.dtFechaIda.Location = new System.Drawing.Point(800, 116);
            this.dtFechaIda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaIda.Name = "dtFechaIda";
            this.dtFechaIda.Size = new System.Drawing.Size(200, 22);
            this.dtFechaIda.TabIndex = 113;
            this.dtFechaIda.ValueChanged += new System.EventHandler(this.dtFechaIda_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label7.Location = new System.Drawing.Point(27, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 111;
            this.label7.Text = "DESTINO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label6.Location = new System.Drawing.Point(33, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 110;
            this.label6.Text = "ORIGEN";
            // 
            // rbEjecutiva
            // 
            this.rbEjecutiva.AutoSize = true;
            this.rbEjecutiva.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.rbEjecutiva.Location = new System.Drawing.Point(515, 250);
            this.rbEjecutiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEjecutiva.Name = "rbEjecutiva";
            this.rbEjecutiva.Size = new System.Drawing.Size(105, 25);
            this.rbEjecutiva.TabIndex = 106;
            this.rbEjecutiva.TabStop = true;
            this.rbEjecutiva.Text = "Ejecutiva";
            this.rbEjecutiva.UseVisualStyleBackColor = true;
            // 
            // cboxPaisOrigen
            // 
            this.cboxPaisOrigen.FormattingEnabled = true;
            this.cboxPaisOrigen.Location = new System.Drawing.Point(325, 305);
            this.cboxPaisOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxPaisOrigen.Name = "cboxPaisOrigen";
            this.cboxPaisOrigen.Size = new System.Drawing.Size(121, 24);
            this.cboxPaisOrigen.TabIndex = 105;
            this.cboxPaisOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged_1);
            this.cboxPaisOrigen.Click += new System.EventHandler(this.cboxPaisOrigen_Click);
            // 
            // rbPrimeraClase
            // 
            this.rbPrimeraClase.AutoSize = true;
            this.rbPrimeraClase.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.rbPrimeraClase.Location = new System.Drawing.Point(361, 249);
            this.rbPrimeraClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPrimeraClase.Name = "rbPrimeraClase";
            this.rbPrimeraClase.Size = new System.Drawing.Size(144, 25);
            this.rbPrimeraClase.TabIndex = 102;
            this.rbPrimeraClase.TabStop = true;
            this.rbPrimeraClase.Text = "Primera Clase";
            this.rbPrimeraClase.UseVisualStyleBackColor = true;
            // 
            // rbEconomica
            // 
            this.rbEconomica.AutoSize = true;
            this.rbEconomica.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.rbEconomica.Location = new System.Drawing.Point(233, 249);
            this.rbEconomica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEconomica.Name = "rbEconomica";
            this.rbEconomica.Size = new System.Drawing.Size(116, 25);
            this.rbEconomica.TabIndex = 101;
            this.rbEconomica.TabStop = true;
            this.rbEconomica.Text = "Economica";
            this.rbEconomica.UseVisualStyleBackColor = true;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.lblNacionalidad.Location = new System.Drawing.Point(269, 308);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(48, 21);
            this.lblNacionalidad.TabIndex = 100;
            this.lblNacionalidad.Text = "Pais:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label8.Location = new System.Drawing.Point(39, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 99;
            this.label8.Text = "Clase:";
            // 
            // txtNumPas
            // 
            this.txtNumPas.Location = new System.Drawing.Point(233, 208);
            this.txtNumPas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumPas.Name = "txtNumPas";
            this.txtNumPas.Size = new System.Drawing.Size(211, 22);
            this.txtNumPas.TabIndex = 98;
            this.txtNumPas.TextChanged += new System.EventHandler(this.txtNumPas_TextChanged);
            this.txtNumPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPas_KeyPress);
            this.txtNumPas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNumPas_MouseUp);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(235, 172);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(209, 22);
            this.txtapellidos.TabIndex = 97;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(235, 139);
            this.txtnombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(209, 22);
            this.txtnombres.TabIndex = 96;
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(235, 106);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(209, 22);
            this.txtcedula.TabIndex = 95;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label4.Location = new System.Drawing.Point(39, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 94;
            this.label4.Text = "Numero Pasajeros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 93;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label2.Location = new System.Drawing.Point(39, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label5.Location = new System.Drawing.Point(39, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 91;
            this.label5.Text = "Cédula: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1053, 73);
            this.label1.TabIndex = 88;
            this.label1.Text = "COMPRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 491);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 112;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(132, 302);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
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
            this.btConsultar.Location = new System.Drawing.Point(496, 687);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(143, 91);
            this.btConsultar.TabIndex = 108;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click_1);
            // 
            // cmdregistrar
            // 
            this.cmdregistrar.AutoSize = true;
            this.cmdregistrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdregistrar.FlatAppearance.BorderSize = 0;
            this.cmdregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdregistrar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregistrar.Image = global::AerolineApp.Properties.Resources.GuardarIcon;
            this.cmdregistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdregistrar.Location = new System.Drawing.Point(325, 686);
            this.cmdregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdregistrar.Name = "cmdregistrar";
            this.cmdregistrar.Size = new System.Drawing.Size(140, 91);
            this.cmdregistrar.TabIndex = 107;
            this.cmdregistrar.Text = "REGISTRAR";
            this.cmdregistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdregistrar.UseVisualStyleBackColor = false;
            this.cmdregistrar.Click += new System.EventHandler(this.cmdregistrar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(824, 634);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
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
            this.btnVolver.Location = new System.Drawing.Point(920, -2);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(187, 73);
            this.btnVolver.TabIndex = 89;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // dgvOrigen
            // 
            this.dgvOrigen.AllowUserToAddRows = false;
            this.dgvOrigen.AllowUserToDeleteRows = false;
            this.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pais,
            this.aeropuerto});
            this.dgvOrigen.Location = new System.Drawing.Point(27, 338);
            this.dgvOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrigen.MultiSelect = false;
            this.dgvOrigen.Name = "dgvOrigen";
            this.dgvOrigen.ReadOnly = true;
            this.dgvOrigen.RowHeadersWidth = 51;
            this.dgvOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrigen.Size = new System.Drawing.Size(557, 123);
            this.dgvOrigen.TabIndex = 120;
            this.dgvOrigen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrigen_CellClick);
            this.dgvOrigen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrigen_CellContentClick);
            // 
            // pais
            // 
            this.pais.HeaderText = "Pais";
            this.pais.MinimumWidth = 6;
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            this.pais.Width = 75;
            // 
            // aeropuerto
            // 
            this.aeropuerto.HeaderText = "Aeropuerto";
            this.aeropuerto.MinimumWidth = 6;
            this.aeropuerto.Name = "aeropuerto";
            this.aeropuerto.ReadOnly = true;
            this.aeropuerto.Width = 300;
            // 
            // dgvDestino
            // 
            this.dgvDestino.AllowUserToAddRows = false;
            this.dgvDestino.AllowUserToDeleteRows = false;
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvDestino.Location = new System.Drawing.Point(27, 538);
            this.dgvDestino.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDestino.MultiSelect = false;
            this.dgvDestino.Name = "dgvDestino";
            this.dgvDestino.ReadOnly = true;
            this.dgvDestino.RowHeadersWidth = 51;
            this.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestino.Size = new System.Drawing.Size(557, 123);
            this.dgvDestino.TabIndex = 121;
            this.dgvDestino.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestino_CellClick);
            this.dgvDestino.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestino_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Aeropuerto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // cboxPaisDestino
            // 
            this.cboxPaisDestino.FormattingEnabled = true;
            this.cboxPaisDestino.Location = new System.Drawing.Point(325, 507);
            this.cboxPaisDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxPaisDestino.Name = "cboxPaisDestino";
            this.cboxPaisDestino.Size = new System.Drawing.Size(121, 24);
            this.cboxPaisDestino.TabIndex = 123;
            this.cboxPaisDestino.SelectedIndexChanged += new System.EventHandler(this.cboxPaisDestino_SelectedIndexChanged);
            this.cboxPaisDestino.Click += new System.EventHandler(this.cboxPaisDestino_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.label12.Location = new System.Drawing.Point(269, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 122;
            this.label12.Text = "Pais:";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 793);
            this.Controls.Add(this.cboxPaisDestino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvDestino);
            this.Controls.Add(this.dgvOrigen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtFechaRegreso);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtida);
            this.Controls.Add(this.dtFechaIda);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.cmdregistrar);
            this.Controls.Add(this.rbEjecutiva);
            this.Controls.Add(this.cboxPaisOrigen);
            this.Controls.Add(this.rbPrimeraClase);
            this.Controls.Add(this.rbEconomica);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumPas);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmCompras_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFechaRegreso;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label txtida;
        private System.Windows.Forms.DateTimePicker dtFechaIda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button cmdregistrar;
        private System.Windows.Forms.RadioButton rbEjecutiva;
        private System.Windows.Forms.ComboBox cboxPaisOrigen;
        private System.Windows.Forms.RadioButton rbPrimeraClase;
        private System.Windows.Forms.RadioButton rbEconomica;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumPas;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrigen;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cboxPaisDestino;
        private System.Windows.Forms.Label label12;
    }
}