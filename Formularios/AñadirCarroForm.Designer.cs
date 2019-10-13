namespace Tienda
{
    partial class AñadirCarroForm
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
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblNombreProd = new System.Windows.Forms.Label();
            this.LblUnidades = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblTalle = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.cmbTalles = new System.Windows.Forms.ComboBox();
            this.UnidadesTotal = new System.Windows.Forms.NumericUpDown();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblPrecioUnidad = new System.Windows.Forms.Label();
            this.LblPrecioTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.BtnAñadirAlCarro2 = new System.Windows.Forms.Button();
            this.BtnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(266, 115);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(349, 254);
            this.LblDescripcion.TabIndex = 0;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // LblNombreProd
            // 
            this.LblNombreProd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.LblNombreProd.Location = new System.Drawing.Point(13, 13);
            this.LblNombreProd.Name = "LblNombreProd";
            this.LblNombreProd.Size = new System.Drawing.Size(231, 38);
            this.LblNombreProd.TabIndex = 1;
            this.LblNombreProd.Text = "NombreProducto";
            // 
            // LblUnidades
            // 
            this.LblUnidades.AutoSize = true;
            this.LblUnidades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnidades.Location = new System.Drawing.Point(1, 117);
            this.LblUnidades.Name = "LblUnidades";
            this.LblUnidades.Size = new System.Drawing.Size(72, 16);
            this.LblUnidades.TabIndex = 2;
            this.LblUnidades.Text = "Unidades:";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.Location = new System.Drawing.Point(24, 156);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(48, 16);
            this.LblColor.TabIndex = 3;
            this.LblColor.Text = "Color:";
            // 
            // LblTalle
            // 
            this.LblTalle.AutoSize = true;
            this.LblTalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTalle.Location = new System.Drawing.Point(32, 198);
            this.LblTalle.Name = "LblTalle";
            this.LblTalle.Size = new System.Drawing.Size(40, 16);
            this.LblTalle.TabIndex = 4;
            this.LblTalle.Text = "Talle:";
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(86, 151);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 21);
            this.cmbColores.TabIndex = 5;
            // 
            // cmbTalles
            // 
            this.cmbTalles.FormattingEnabled = true;
            this.cmbTalles.Location = new System.Drawing.Point(86, 193);
            this.cmbTalles.Name = "cmbTalles";
            this.cmbTalles.Size = new System.Drawing.Size(121, 21);
            this.cmbTalles.TabIndex = 6;
            // 
            // UnidadesTotal
            // 
            this.UnidadesTotal.Location = new System.Drawing.Point(87, 112);
            this.UnidadesTotal.Name = "UnidadesTotal";
            this.UnidadesTotal.Size = new System.Drawing.Size(120, 20);
            this.UnidadesTotal.TabIndex = 7;
            this.UnidadesTotal.ValueChanged += new System.EventHandler(this.UnidadesTotal_ValueChanged);
            // 
            // LblModelo
            // 
            this.LblModelo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.LblModelo.Location = new System.Drawing.Point(12, 67);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(291, 30);
            this.LblModelo.TabIndex = 8;
            this.LblModelo.Text = "NombreModelo";
            // 
            // LblPrecioUnidad
            // 
            this.LblPrecioUnidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioUnidad.Location = new System.Drawing.Point(170, 263);
            this.LblPrecioUnidad.Name = "LblPrecioUnidad";
            this.LblPrecioUnidad.Size = new System.Drawing.Size(90, 23);
            this.LblPrecioUnidad.TabIndex = 9;
            this.LblPrecioUnidad.Text = "0";
            // 
            // LblPrecioTotal
            // 
            this.LblPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.LblPrecioTotal.Location = new System.Drawing.Point(166, 327);
            this.LblPrecioTotal.Name = "LblPrecioTotal";
            this.LblPrecioTotal.Size = new System.Drawing.Size(94, 23);
            this.LblPrecioTotal.TabIndex = 10;
            this.LblPrecioTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(309, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(28, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 2);
            this.label4.TabIndex = 22;
            this.label4.Text = "       ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(313, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 2);
            this.label3.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio por unidad: $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Precio total: $";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(17, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 2);
            this.label7.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(19, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 2);
            this.label8.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(17, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 2);
            this.label9.TabIndex = 29;
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.AutoSize = true;
            this.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarForm.Image = global::Tienda.Properties.Resources.cerrar_copia;
            this.BtnCerrarForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarForm.Location = new System.Drawing.Point(532, 428);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(83, 34);
            this.BtnCerrarForm.TabIndex = 21;
            this.BtnCerrarForm.Text = "Cerrar";
            this.BtnCerrarForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarForm.UseVisualStyleBackColor = true;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // BtnAñadirAlCarro2
            // 
            this.BtnAñadirAlCarro2.AutoSize = true;
            this.BtnAñadirAlCarro2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAñadirAlCarro2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadirAlCarro2.Image = global::Tienda.Properties.Resources._32360_copia;
            this.BtnAñadirAlCarro2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAñadirAlCarro2.Location = new System.Drawing.Point(228, 428);
            this.BtnAñadirAlCarro2.Name = "BtnAñadirAlCarro2";
            this.BtnAñadirAlCarro2.Size = new System.Drawing.Size(142, 34);
            this.BtnAñadirAlCarro2.TabIndex = 20;
            this.BtnAñadirAlCarro2.Text = "Añadir al carro";
            this.BtnAñadirAlCarro2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAñadirAlCarro2.UseVisualStyleBackColor = true;
            this.BtnAñadirAlCarro2.Click += new System.EventHandler(this.BtnAñadirAlCarro2_Click);
            // 
            // BtnComprar
            // 
            this.BtnComprar.AutoSize = true;
            this.BtnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComprar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.Image = global::Tienda.Properties.Resources._34363_copia;
            this.BtnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnComprar.Location = new System.Drawing.Point(27, 428);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(164, 34);
            this.BtnComprar.TabIndex = 30;
            this.BtnComprar.Text = "Proceder compra";
            this.BtnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Visible = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // AñadirCarroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 474);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.BtnAñadirAlCarro2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPrecioTotal);
            this.Controls.Add(this.LblPrecioUnidad);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.UnidadesTotal);
            this.Controls.Add(this.cmbTalles);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.LblTalle);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.LblUnidades);
            this.Controls.Add(this.LblNombreProd);
            this.Controls.Add(this.LblDescripcion);
            this.Name = "AñadirCarroForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "AñadirCarro";
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombreProd;
        private System.Windows.Forms.Label LblUnidades;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblTalle;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.ComboBox cmbTalles;
        private System.Windows.Forms.NumericUpDown UnidadesTotal;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblPrecioUnidad;
        private System.Windows.Forms.Label LblPrecioTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAñadirAlCarro2;
        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnComprar;
    }
}