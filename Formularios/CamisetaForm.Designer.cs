namespace Tienda
{
    partial class CamisetaForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaCamisetas = new System.Windows.Forms.ListView();
            this.ColProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOrdenarCamiseta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTOS";
            // 
            // ListaCamisetas
            // 
            this.ListaCamisetas.BackColor = System.Drawing.SystemColors.Window;
            this.ListaCamisetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaCamisetas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColProducto,
            this.ColModelo,
            this.ColPrecio});
            this.ListaCamisetas.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCamisetas.FullRowSelect = true;
            this.ListaCamisetas.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.ListaCamisetas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListaCamisetas.Location = new System.Drawing.Point(91, 59);
            this.ListaCamisetas.MultiSelect = false;
            this.ListaCamisetas.Name = "ListaCamisetas";
            this.ListaCamisetas.Size = new System.Drawing.Size(430, 229);
            this.ListaCamisetas.TabIndex = 4;
            this.ListaCamisetas.UseCompatibleStateImageBehavior = false;
            this.ListaCamisetas.View = System.Windows.Forms.View.Details;
            // 
            // ColProducto
            // 
            this.ColProducto.Text = "Producto";
            this.ColProducto.Width = 150;
            // 
            // ColModelo
            // 
            this.ColModelo.Text = "Modelo";
            this.ColModelo.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Text = "Precio";
            this.ColPrecio.Width = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ordenar por:";
            // 
            // cmbOrdenarCamiseta
            // 
            this.cmbOrdenarCamiseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdenarCamiseta.FormattingEnabled = true;
            this.cmbOrdenarCamiseta.Items.AddRange(new object[] {
            "        Seleccione",
            "        Producto",
            "               A-Z",
            "               Z-A",
            "      Precio Mayor",
            "      Precio Menor",
            "       Más vendido"});
            this.cmbOrdenarCamiseta.Location = new System.Drawing.Point(400, 19);
            this.cmbOrdenarCamiseta.Name = "cmbOrdenarCamiseta";
            this.cmbOrdenarCamiseta.Size = new System.Drawing.Size(121, 23);
            this.cmbOrdenarCamiseta.TabIndex = 11;
            this.cmbOrdenarCamiseta.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenarCamiseta_SelectedIndexChanged_1);
            this.cmbOrdenarCamiseta.Click += new System.EventHandler(this.cmbOrdenarCamiseta_Click_1);
            // 
            // CamisetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 294);
            this.Controls.Add(this.cmbOrdenarCamiseta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListaCamisetas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CamisetaForm";
            this.Text = "Camiseta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaCamisetas;
        private System.Windows.Forms.ColumnHeader ColProducto;
        private System.Windows.Forms.ColumnHeader ColModelo;
        private System.Windows.Forms.ColumnHeader ColPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOrdenarCamiseta;
    }
}