namespace CapaPresentacion
{
    partial class Usuarios_view
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
            this.tabla_ver_usario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ver_usario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_ver_usario
            // 
            this.tabla_ver_usario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_ver_usario.Location = new System.Drawing.Point(0, 50);
            this.tabla_ver_usario.Name = "tabla_ver_usario";
            this.tabla_ver_usario.Size = new System.Drawing.Size(800, 405);
            this.tabla_ver_usario.TabIndex = 0;
            // 
            // Usuarios_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabla_ver_usario);
            this.Name = "Usuarios_view";
            this.Text = "Usuarios_view";
            this.Load += new System.EventHandler(this.Usuarios_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ver_usario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_ver_usario;
    }
}