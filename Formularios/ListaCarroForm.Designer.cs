namespace Tienda
{
    partial class ListaCarroForm
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
            this.ListaCarrito = new System.Windows.Forms.ListView();
            this.ColProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUnidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBorrarProducto = new System.Windows.Forms.Button();
            this.BtnComprarTodo = new System.Windows.Forms.Button();
            this.BtnComprarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaCarrito
            // 
            this.ListaCarrito.BackColor = System.Drawing.SystemColors.Window;
            this.ListaCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColProducto,
            this.ColModelo,
            this.ColTalle,
            this.ColColor,
            this.ColUnidades,
            this.ColPrecio});
            this.ListaCarrito.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCarrito.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.ListaCarrito.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListaCarrito.Location = new System.Drawing.Point(4, 90);
            this.ListaCarrito.MultiSelect = false;
            this.ListaCarrito.Name = "ListaCarrito";
            this.ListaCarrito.Size = new System.Drawing.Size(658, 262);
            this.ListaCarrito.TabIndex = 9;
            this.ListaCarrito.UseCompatibleStateImageBehavior = false;
            this.ListaCarrito.View = System.Windows.Forms.View.Details;
            // 
            // ColProducto
            // 
            this.ColProducto.Text = "Producto";
            this.ColProducto.Width = 150;
            // 
            // ColModelo
            // 
            this.ColModelo.Text = "Modelo";
            this.ColModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColModelo.Width = 195;
            // 
            // ColTalle
            // 
            this.ColTalle.Text = "Talle";
            this.ColTalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColColor
            // 
            this.ColColor.Text = "Color";
            this.ColColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColColor.Width = 70;
            // 
            // ColUnidades
            // 
            this.ColUnidades.Text = "Unidades";
            this.ColUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColUnidades.Width = 79;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Text = "Total";
            this.ColPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColPrecio.Width = 98;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "MI CARRITO";
            // 
            // BtnBorrarProducto
            // 
            this.BtnBorrarProducto.AutoSize = true;
            this.BtnBorrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarProducto.Image = global::Tienda.Properties.Resources.cerrar_copia;
            this.BtnBorrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrarProducto.Location = new System.Drawing.Point(398, 358);
            this.BtnBorrarProducto.Name = "BtnBorrarProducto";
            this.BtnBorrarProducto.Size = new System.Drawing.Size(157, 34);
            this.BtnBorrarProducto.TabIndex = 21;
            this.BtnBorrarProducto.Text = "Eliminar del carro";
            this.BtnBorrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrarProducto.UseVisualStyleBackColor = true;
            this.BtnBorrarProducto.Click += new System.EventHandler(this.BtnBorrarProducto_Click);
            // 
            // BtnComprarTodo
            // 
            this.BtnComprarTodo.AutoSize = true;
            this.BtnComprarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComprarTodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprarTodo.Image = global::Tienda.Properties.Resources.peso_copia;
            this.BtnComprarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnComprarTodo.Location = new System.Drawing.Point(4, 358);
            this.BtnComprarTodo.Name = "BtnComprarTodo";
            this.BtnComprarTodo.Size = new System.Drawing.Size(136, 34);
            this.BtnComprarTodo.TabIndex = 22;
            this.BtnComprarTodo.Text = "Comprar todo";
            this.BtnComprarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComprarTodo.UseVisualStyleBackColor = true;
            this.BtnComprarTodo.Click += new System.EventHandler(this.BtnComprarTodo_Click);
            // 
            // BtnComprarProducto
            // 
            this.BtnComprarProducto.AutoSize = true;
            this.BtnComprarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComprarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprarProducto.Image = global::Tienda.Properties.Resources._34363_copia;
            this.BtnComprarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnComprarProducto.Location = new System.Drawing.Point(561, 358);
            this.BtnComprarProducto.Name = "BtnComprarProducto";
            this.BtnComprarProducto.Size = new System.Drawing.Size(101, 34);
            this.BtnComprarProducto.TabIndex = 23;
            this.BtnComprarProducto.Text = "Comprar";
            this.BtnComprarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComprarProducto.UseVisualStyleBackColor = true;
            this.BtnComprarProducto.Click += new System.EventHandler(this.BtnComprarProducto_Click);
            // 
            // ListaCarroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 433);
            this.Controls.Add(this.BtnComprarProducto);
            this.Controls.Add(this.BtnComprarTodo);
            this.Controls.Add(this.BtnBorrarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCarroForm";
            this.Text = "ListaCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaCarrito;
        private System.Windows.Forms.ColumnHeader ColProducto;
        private System.Windows.Forms.ColumnHeader ColModelo;
        private System.Windows.Forms.ColumnHeader ColTalle;
        private System.Windows.Forms.ColumnHeader ColColor;
        private System.Windows.Forms.ColumnHeader ColUnidades;
        private System.Windows.Forms.ColumnHeader ColPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBorrarProducto;
        private System.Windows.Forms.Button BtnComprarTodo;
        private System.Windows.Forms.Button BtnComprarProducto;
    }
}