namespace Tienda.Formularios
{
    partial class PedidoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaPedido = new System.Windows.Forms.ListView();
            this.ColProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUnidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPaís = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColIdPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnBorrarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "PEDIDOS";
            // 
            // ListaPedido
            // 
            this.ListaPedido.BackColor = System.Drawing.SystemColors.Window;
            this.ListaPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColProducto,
            this.ColModelo,
            this.ColTalle,
            this.ColColor,
            this.ColUnidades,
            this.ColPaís,
            this.ColDireccion,
            this.ColIdPedido,
            this.ColTotal});
            this.ListaPedido.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaPedido.GridLines = true;
            listViewItem2.StateImageIndex = 0;
            this.ListaPedido.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListaPedido.Location = new System.Drawing.Point(16, 90);
            this.ListaPedido.MultiSelect = false;
            this.ListaPedido.Name = "ListaPedido";
            this.ListaPedido.Size = new System.Drawing.Size(633, 262);
            this.ListaPedido.TabIndex = 14;
            this.ListaPedido.UseCompatibleStateImageBehavior = false;
            this.ListaPedido.View = System.Windows.Forms.View.Details;
            // 
            // ColProducto
            // 
            this.ColProducto.Text = "Producto";
            this.ColProducto.Width = 80;
            // 
            // ColModelo
            // 
            this.ColModelo.Text = "Modelo";
            this.ColModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColModelo.Width = 80;
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
            // 
            // ColUnidades
            // 
            this.ColUnidades.Text = "Unidades";
            this.ColUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColUnidades.Width = 70;
            // 
            // ColPaís
            // 
            this.ColPaís.Text = "País";
            this.ColPaís.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColDireccion
            // 
            this.ColDireccion.Text = "Dirección";
            this.ColDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColDireccion.Width = 80;
            // 
            // ColIdPedido
            // 
            this.ColIdPedido.Text = "Id pedido";
            this.ColIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColIdPedido.Width = 80;
            // 
            // ColTotal
            // 
            this.ColTotal.Text = "Total";
            this.ColTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBorrarPedido
            // 
            this.BtnBorrarPedido.AutoSize = true;
            this.BtnBorrarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarPedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarPedido.Image = global::Tienda.Properties.Resources.cerrar_copia;
            this.BtnBorrarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrarPedido.Location = new System.Drawing.Point(507, 358);
            this.BtnBorrarPedido.Name = "BtnBorrarPedido";
            this.BtnBorrarPedido.Size = new System.Drawing.Size(142, 34);
            this.BtnBorrarPedido.TabIndex = 22;
            this.BtnBorrarPedido.Text = "Eliminar pedido";
            this.BtnBorrarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrarPedido.UseVisualStyleBackColor = true;
            this.BtnBorrarPedido.Click += new System.EventHandler(this.BtnBorrarPedido_Click);
            // 
            // PedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(667, 433);
            this.Controls.Add(this.BtnBorrarPedido);
            this.Controls.Add(this.ListaPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoForm";
            this.Text = "PedidoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaPedido;
        private System.Windows.Forms.ColumnHeader ColProducto;
        private System.Windows.Forms.ColumnHeader ColModelo;
        private System.Windows.Forms.ColumnHeader ColTalle;
        private System.Windows.Forms.ColumnHeader ColColor;
        private System.Windows.Forms.ColumnHeader ColUnidades;
        private System.Windows.Forms.ColumnHeader ColPaís;
        private System.Windows.Forms.Button BtnBorrarPedido;
        private System.Windows.Forms.ColumnHeader ColDireccion;
        private System.Windows.Forms.ColumnHeader ColIdPedido;
        private System.Windows.Forms.ColumnHeader ColTotal;
    }
}