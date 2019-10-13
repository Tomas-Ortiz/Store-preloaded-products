namespace Tienda.Formularios
{
    partial class ListaProductosForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.ListaProductos = new System.Windows.Forms.ListView();
            this.ColProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaProductos
            // 
            this.ListaProductos.BackColor = System.Drawing.SystemColors.Window;
            this.ListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColProducto,
            this.ColModelo,
            this.ColPrecio});
            this.ListaProductos.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProductos.FullRowSelect = true;
            this.ListaProductos.GridLines = true;
            listViewItem2.StateImageIndex = 0;
            this.ListaProductos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListaProductos.Location = new System.Drawing.Point(90, 63);
            this.ListaProductos.MultiSelect = false;
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(430, 229);
            this.ListaProductos.TabIndex = 7;
            this.ListaProductos.UseCompatibleStateImageBehavior = false;
            this.ListaProductos.View = System.Windows.Forms.View.Details;
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
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILTRADO";
            // 
            // ListaProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 294);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProductosForm";
            this.Text = "ListaProductosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListaProductos;
        private System.Windows.Forms.ColumnHeader ColProducto;
        private System.Windows.Forms.ColumnHeader ColModelo;
        private System.Windows.Forms.ColumnHeader ColPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}