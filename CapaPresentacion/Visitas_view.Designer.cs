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
            ((System.ComponentModel.ISupportInitialize)(this.table_registro)).BeginInit();
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
            this.table_registro.Location = new System.Drawing.Point(-2, 71);
            this.table_registro.Name = "table_registro";
            this.table_registro.Size = new System.Drawing.Size(1068, 572);
            this.table_registro.TabIndex = 0;
            // 
            // combo_buscar_edificio
            // 
            this.combo_buscar_edificio.Location = new System.Drawing.Point(932, 28);
            this.combo_buscar_edificio.Name = "combo_buscar_edificio";
            this.combo_buscar_edificio.Size = new System.Drawing.Size(121, 21);
            this.combo_buscar_edificio.TabIndex = 3;
            this.combo_buscar_edificio.SelectionChangeCommitted += new System.EventHandler(this.combo_buscar_edificio_SelectionChangeCommitted);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(772, 28);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(145, 21);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Edificio";
            // 
            // Visitas_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.combo_buscar_edificio);
            this.Controls.Add(this.table_registro);
            this.Name = "Visitas_view";
            this.Text = "Visitas_view";
            this.Load += new System.EventHandler(this.Visitas_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_registro;
        private System.Windows.Forms.ComboBox combo_buscar_edificio;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}