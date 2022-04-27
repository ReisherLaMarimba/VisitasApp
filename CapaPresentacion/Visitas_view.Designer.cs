namespace CapaPresentacion
{
    partial class Visitas_view
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
            this.table_registro = new System.Windows.Forms.DataGridView();
            this.combo_buscar_edificio = new System.Windows.Forms.ComboBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hora_entrada = new System.Windows.Forms.DateTimePicker();
            this.combo_edificio = new System.Windows.Forms.ComboBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_apellido_visitante = new System.Windows.Forms.TextBox();
            this.txt_nombre_visitante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_carrera = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hora_salida = new System.Windows.Forms.DateTimePicker();
            this.comboAula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_obj = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_registro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // table_registro
            // 
            this.table_registro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_registro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_registro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.table_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_registro.Location = new System.Drawing.Point(-2, 258);
            this.table_registro.Name = "table_registro";
            this.table_registro.Size = new System.Drawing.Size(1068, 385);
            this.table_registro.TabIndex = 0;
            // 
            // combo_buscar_edificio
            // 
            this.combo_buscar_edificio.Location = new System.Drawing.Point(766, 231);
            this.combo_buscar_edificio.Name = "combo_buscar_edificio";
            this.combo_buscar_edificio.Size = new System.Drawing.Size(121, 21);
            this.combo_buscar_edificio.TabIndex = 3;
            this.combo_buscar_edificio.SelectionChangeCommitted += new System.EventHandler(this.combo_buscar_edificio_SelectionChangeCommitted);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(893, 217);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(160, 35);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar por Edificio";
            // 
            // hora_entrada
            // 
            this.hora_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora_entrada.Location = new System.Drawing.Point(656, 49);
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.Size = new System.Drawing.Size(160, 20);
            this.hora_entrada.TabIndex = 42;
            this.hora_entrada.ValueChanged += new System.EventHandler(this.data_nacimiento_ValueChanged);
            // 
            // combo_edificio
            // 
            this.combo_edificio.FormattingEnabled = true;
            this.combo_edificio.Location = new System.Drawing.Point(204, 45);
            this.combo_edificio.Name = "combo_edificio";
            this.combo_edificio.Size = new System.Drawing.Size(200, 21);
            this.combo_edificio.TabIndex = 41;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(15, 211);
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(160, 24);
            this.txt_correo.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Correo";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(15, 159);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 24);
            this.txt_name.TabIndex = 38;
            // 
            // txt_apellido_visitante
            // 
            this.txt_apellido_visitante.Location = new System.Drawing.Point(15, 98);
            this.txt_apellido_visitante.Multiline = true;
            this.txt_apellido_visitante.Name = "txt_apellido_visitante";
            this.txt_apellido_visitante.Size = new System.Drawing.Size(160, 24);
            this.txt_apellido_visitante.TabIndex = 37;
            // 
            // txt_nombre_visitante
            // 
            this.txt_nombre_visitante.Location = new System.Drawing.Point(15, 45);
            this.txt_nombre_visitante.Multiline = true;
            this.txt_nombre_visitante.Name = "txt_nombre_visitante";
            this.txt_nombre_visitante.Size = new System.Drawing.Size(160, 24);
            this.txt_nombre_visitante.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Fecha de Entrada";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Edificio";
            // 
            // txt_carrera
            // 
            this.txt_carrera.AutoSize = true;
            this.txt_carrera.Location = new System.Drawing.Point(12, 143);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(41, 13);
            this.txt_carrera.TabIndex = 33;
            this.txt_carrera.Text = "Carrera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Fecha de Salida";
            // 
            // Hora_salida
            // 
            this.Hora_salida.Location = new System.Drawing.Point(656, 98);
            this.Hora_salida.Name = "Hora_salida";
            this.Hora_salida.Size = new System.Drawing.Size(160, 20);
            this.Hora_salida.TabIndex = 44;
            // 
            // comboAula
            // 
            this.comboAula.FormattingEnabled = true;
            this.comboAula.Location = new System.Drawing.Point(204, 98);
            this.comboAula.Name = "comboAula";
            this.comboAula.Size = new System.Drawing.Size(200, 21);
            this.comboAula.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Aula";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(421, 47);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(200, 109);
            this.txt_motivo.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Motivo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Borrar";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btn_borrar.Location = new System.Drawing.Point(656, 211);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(54, 41);
            this.btn_borrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_borrar.TabIndex = 55;
            this.btn_borrar.TabStop = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Editar";
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btn_edit.Location = new System.Drawing.Point(596, 208);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(54, 41);
            this.btn_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_edit.TabIndex = 53;
            this.btn_edit.TabStop = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(549, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Actualizar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Añadir";
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Image = global::CapaPresentacion.Properties.Resources.sync;
            this.btn_update.Location = new System.Drawing.Point(517, 208);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(54, 41);
            this.btn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_update.TabIndex = 50;
            this.btn_update.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(446, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_obj
            // 
            this.txt_obj.Location = new System.Drawing.Point(204, 160);
            this.txt_obj.Multiline = true;
            this.txt_obj.Name = "txt_obj";
            this.txt_obj.Size = new System.Drawing.Size(160, 24);
            this.txt_obj.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Objetivo";
            // 
            // Visitas_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 642);
            this.Controls.Add(this.txt_obj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.comboAula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hora_salida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hora_entrada);
            this.Controls.Add(this.combo_edificio);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_apellido_visitante);
            this.Controls.Add(this.txt_nombre_visitante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_carrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.combo_buscar_edificio);
            this.Controls.Add(this.table_registro);
            this.Name = "Visitas_view";
            this.Text = "Visitas_view";
            this.Load += new System.EventHandler(this.Visitas_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_registro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_registro;
        private System.Windows.Forms.ComboBox combo_buscar_edificio;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hora_entrada;
        private System.Windows.Forms.ComboBox combo_edificio;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_apellido_visitante;
        private System.Windows.Forms.TextBox txt_nombre_visitante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_carrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Hora_salida;
        private System.Windows.Forms.ComboBox comboAula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btn_borrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btn_edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btn_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_obj;
        private System.Windows.Forms.Label label15;
    }
}