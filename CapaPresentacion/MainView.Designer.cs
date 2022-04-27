namespace CapaPresentacion
{
    partial class MainView
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ver_aula = new System.Windows.Forms.Button();
            this.btn_ver_edificio = new System.Windows.Forms.Button();
            this.btn_ver_roles = new System.Windows.Forms.Button();
            this.btn_ver_usuarios = new System.Windows.Forms.Button();
            this.btn_ver_visitas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_rol = new System.Windows.Forms.Label();
            this.label_name_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(233)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(83, 598);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Cerrar Sesion";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 48);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(1188, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.cancel1;
            this.pictureBox2.Location = new System.Drawing.Point(1229, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(559, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.btn_ver_aula);
            this.panel2.Controls.Add(this.btn_ver_edificio);
            this.panel2.Controls.Add(this.btn_ver_roles);
            this.panel2.Controls.Add(this.btn_ver_usuarios);
            this.panel2.Controls.Add(this.btn_ver_visitas);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 633);
            this.panel2.TabIndex = 0;
            // 
            // btn_ver_aula
            // 
            this.btn_ver_aula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_aula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ver_aula.Location = new System.Drawing.Point(13, 340);
            this.btn_ver_aula.Name = "btn_ver_aula";
            this.btn_ver_aula.Size = new System.Drawing.Size(187, 40);
            this.btn_ver_aula.TabIndex = 8;
            this.btn_ver_aula.Text = "Ver Aulas";
            this.btn_ver_aula.UseVisualStyleBackColor = true;
            this.btn_ver_aula.Click += new System.EventHandler(this.btn_ver_aula_Click);
            // 
            // btn_ver_edificio
            // 
            this.btn_ver_edificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_edificio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ver_edificio.Location = new System.Drawing.Point(13, 294);
            this.btn_ver_edificio.Name = "btn_ver_edificio";
            this.btn_ver_edificio.Size = new System.Drawing.Size(187, 40);
            this.btn_ver_edificio.TabIndex = 6;
            this.btn_ver_edificio.Text = "Ver Edificio";
            this.btn_ver_edificio.UseVisualStyleBackColor = true;
            this.btn_ver_edificio.Click += new System.EventHandler(this.btn_ver_usuario_Click);
            // 
            // btn_ver_roles
            // 
            this.btn_ver_roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_roles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ver_roles.Location = new System.Drawing.Point(12, 248);
            this.btn_ver_roles.Name = "btn_ver_roles";
            this.btn_ver_roles.Size = new System.Drawing.Size(187, 40);
            this.btn_ver_roles.TabIndex = 5;
            this.btn_ver_roles.Text = "Ver Roles";
            this.btn_ver_roles.UseVisualStyleBackColor = true;
            this.btn_ver_roles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ver_usuarios
            // 
            this.btn_ver_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_usuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ver_usuarios.Location = new System.Drawing.Point(13, 202);
            this.btn_ver_usuarios.Name = "btn_ver_usuarios";
            this.btn_ver_usuarios.Size = new System.Drawing.Size(187, 40);
            this.btn_ver_usuarios.TabIndex = 4;
            this.btn_ver_usuarios.Text = "Ver usuarios";
            this.btn_ver_usuarios.UseVisualStyleBackColor = true;
            this.btn_ver_usuarios.Click += new System.EventHandler(this.btn_ver_usuarios_Click);
            // 
            // btn_ver_visitas
            // 
            this.btn_ver_visitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_visitas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ver_visitas.Location = new System.Drawing.Point(13, 156);
            this.btn_ver_visitas.Name = "btn_ver_visitas";
            this.btn_ver_visitas.Size = new System.Drawing.Size(187, 40);
            this.btn_ver_visitas.TabIndex = 3;
            this.btn_ver_visitas.Text = "Ver Visitas";
            this.btn_ver_visitas.UseVisualStyleBackColor = true;
            this.btn_ver_visitas.Click += new System.EventHandler(this.btn_ver_visitas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(233)))));
            this.panel3.Controls.Add(this.label_rol);
            this.panel3.Controls.Add(this.label_name_user);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 137);
            this.panel3.TabIndex = 2;
            // 
            // label_rol
            // 
            this.label_rol.AutoSize = true;
            this.label_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.label_rol.Location = new System.Drawing.Point(69, 110);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(55, 16);
            this.label_rol.TabIndex = 4;
            this.label_rol.Text = "rol_user";
            // 
            // label_name_user
            // 
            this.label_name_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name_user.AutoSize = true;
            this.label_name_user.BackColor = System.Drawing.Color.Transparent;
            this.label_name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.label_name_user.Location = new System.Drawing.Point(24, 90);
            this.label_name_user.Name = "label_name_user";
            this.label_name_user.Size = new System.Drawing.Size(146, 20);
            this.label_name_user.TabIndex = 3;
            this.label_name_user.Text = "Nombre de Usuario";
            this.label_name_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(53, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.White;
            this.Main_panel.Controls.Add(this.panel5);
            this.Main_panel.Controls.Add(this.panel4);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(200, 48);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1091, 633);
            this.Main_panel.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1075, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 598);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 598);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1091, 35);
            this.panel4.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 681);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Label label_name_user;
        private System.Windows.Forms.Button btn_ver_visitas;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Button btn_ver_usuarios;
        private System.Windows.Forms.Button btn_ver_roles;
        private System.Windows.Forms.Button btn_ver_edificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ver_aula;
    }
}