namespace CapaPresentacion
{
    partial class Roles_view
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
            this.tabla_Ver_roles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Ver_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_Ver_roles
            // 
            this.tabla_Ver_roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_Ver_roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_Ver_roles.BackgroundColor = System.Drawing.Color.White;
            this.tabla_Ver_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_Ver_roles.Location = new System.Drawing.Point(0, 71);
            this.tabla_Ver_roles.Name = "tabla_Ver_roles";
            this.tabla_Ver_roles.Size = new System.Drawing.Size(1068, 574);
            this.tabla_Ver_roles.TabIndex = 0;
            // 
            // Roles_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 642);
            this.Controls.Add(this.tabla_Ver_roles);
            this.Name = "Roles_view";
            this.Text = "Roles_view";
            this.Load += new System.EventHandler(this.Roles_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_Ver_roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_Ver_roles;
    }
}