namespace CapaPresentacion
{
    partial class Edificios_view
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
            this.tabla_ver_edificio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre_Edificio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ver_edificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_ver_edificio
            // 
            this.tabla_ver_edificio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_ver_edificio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_ver_edificio.BackgroundColor = System.Drawing.Color.White;
            this.tabla_ver_edificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_ver_edificio.Location = new System.Drawing.Point(-3, 185);
            this.tabla_ver_edificio.Name = "tabla_ver_edificio";
            this.tabla_ver_edificio.Size = new System.Drawing.Size(552, 460);
            this.tabla_ver_edificio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Añadir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actualizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Borrar";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btn_borrar.Location = new System.Drawing.Point(105, 103);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(54, 41);
            this.btn_borrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.TabStop = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btn_edit.Location = new System.Drawing.Point(105, 24);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(54, 41);
            this.btn_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_edit.TabIndex = 7;
            this.btn_edit.TabStop = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Image = global::CapaPresentacion.Properties.Resources.sync;
            this.btn_update.Location = new System.Drawing.Point(14, 103);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(54, 41);
            this.btn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_update.TabIndex = 4;
            this.btn_update.TabStop = false;
            this.btn_update.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_nombre_Edificio
            // 
            this.txt_nombre_Edificio.Location = new System.Drawing.Point(221, 88);
            this.txt_nombre_Edificio.Multiline = true;
            this.txt_nombre_Edificio.Name = "txt_nombre_Edificio";
            this.txt_nombre_Edificio.Size = new System.Drawing.Size(169, 32);
            this.txt_nombre_Edificio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre del Edificio";
            // 
            // Edificios_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 642);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre_Edificio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabla_ver_edificio);
            this.Name = "Edificios_view";
            this.Text = "Edificios_view";
            this.Load += new System.EventHandler(this.Edificios_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ver_edificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_ver_edificio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_borrar;
        private System.Windows.Forms.TextBox txt_nombre_Edificio;
        private System.Windows.Forms.Label label5;
    }
}