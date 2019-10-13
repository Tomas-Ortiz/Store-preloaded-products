namespace Tienda
{
    partial class contenedorPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contenedorPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextoBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesYReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelReemplazable = new System.Windows.Forms.Panel();
            this.panelReemplazable2 = new System.Windows.Forms.Panel();
            this.BtnCerrarVentanaCarro = new System.Windows.Forms.Button();
            this.BtnAñadirAlCarro = new System.Windows.Forms.Button();
            this.BtnComprar1 = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnZapatillas = new System.Windows.Forms.Button();
            this.BtnPantalones = new System.Windows.Forms.Button();
            this.BtnCamiseta = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCarrito = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(85, 5, 85, 5);
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "GUCCI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(105, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 2);
            this.label2.TabIndex = 2;
            this.label2.Text = "       ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(105, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 2);
            this.label3.TabIndex = 3;
            this.label3.Text = "       ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(105, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 2);
            this.label4.TabIndex = 6;
            this.label4.Text = "       ";
            // 
            // TextoBusqueda
            // 
            this.TextoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBusqueda.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextoBusqueda.Location = new System.Drawing.Point(471, 160);
            this.TextoBusqueda.Name = "TextoBusqueda";
            this.TextoBusqueda.Size = new System.Drawing.Size(187, 20);
            this.TextoBusqueda.TabIndex = 8;
            this.TextoBusqueda.Text = "Buscar producto/s, modelo/s...";
            this.TextoBusqueda.Click += new System.EventHandler(this.TextoBusqueda_Click);
            this.TextoBusqueda.TextChanged += new System.EventHandler(this.TextoBusqueda_TextChanged);
            this.TextoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoBusqueda_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(105, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(600, 2);
            this.label5.TabIndex = 14;
            this.label5.Text = "       ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaToolStripMenuItem,
            this.reportesYReclamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 26);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tiendaToolStripMenuItem.Checked = true;
            this.tiendaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tiendaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiendaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // reportesYReclamosToolStripMenuItem
            // 
            this.reportesYReclamosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportesYReclamosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesYReclamosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportesYReclamosToolStripMenuItem.Name = "reportesYReclamosToolStripMenuItem";
            this.reportesYReclamosToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.reportesYReclamosToolStripMenuItem.Text = "Reclamos";
            // 
            // panelReemplazable
            // 
            this.panelReemplazable.Location = new System.Drawing.Point(71, 255);
            this.panelReemplazable.Name = "panelReemplazable";
            this.panelReemplazable.Size = new System.Drawing.Size(634, 320);
            this.panelReemplazable.TabIndex = 17;
            // 
            // panelReemplazable2
            // 
            this.panelReemplazable2.Location = new System.Drawing.Point(71, 147);
            this.panelReemplazable2.Name = "panelReemplazable2";
            this.panelReemplazable2.Size = new System.Drawing.Size(670, 437);
            this.panelReemplazable2.TabIndex = 20;
            this.panelReemplazable2.Visible = false;
            // 
            // BtnCerrarVentanaCarro
            // 
            this.BtnCerrarVentanaCarro.Image = global::Tienda.Properties.Resources.borrar_copia2;
            this.BtnCerrarVentanaCarro.Location = new System.Drawing.Point(700, 147);
            this.BtnCerrarVentanaCarro.Name = "BtnCerrarVentanaCarro";
            this.BtnCerrarVentanaCarro.Size = new System.Drawing.Size(38, 23);
            this.BtnCerrarVentanaCarro.TabIndex = 21;
            this.BtnCerrarVentanaCarro.UseVisualStyleBackColor = true;
            this.BtnCerrarVentanaCarro.Visible = false;
            this.BtnCerrarVentanaCarro.Click += new System.EventHandler(this.BtnCerrarVentanaCarro_Click);
            // 
            // BtnAñadirAlCarro
            // 
            this.BtnAñadirAlCarro.AutoSize = true;
            this.BtnAñadirAlCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAñadirAlCarro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadirAlCarro.Image = global::Tienda.Properties.Resources._32360_copia;
            this.BtnAñadirAlCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAñadirAlCarro.Location = new System.Drawing.Point(162, 550);
            this.BtnAñadirAlCarro.Name = "BtnAñadirAlCarro";
            this.BtnAñadirAlCarro.Size = new System.Drawing.Size(142, 34);
            this.BtnAñadirAlCarro.TabIndex = 19;
            this.BtnAñadirAlCarro.Text = "Añadir al carro";
            this.BtnAñadirAlCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAñadirAlCarro.UseVisualStyleBackColor = true;
            this.BtnAñadirAlCarro.Click += new System.EventHandler(this.BtnAñadirAlCarro_Click);
            // 
            // BtnComprar1
            // 
            this.BtnComprar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComprar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar1.Image = global::Tienda.Properties.Resources._34363_copia;
            this.BtnComprar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnComprar1.Location = new System.Drawing.Point(509, 550);
            this.BtnComprar1.Name = "BtnComprar1";
            this.BtnComprar1.Size = new System.Drawing.Size(101, 34);
            this.BtnComprar1.TabIndex = 18;
            this.BtnComprar1.Text = "Comprar";
            this.BtnComprar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComprar1.UseVisualStyleBackColor = true;
            this.BtnComprar1.Click += new System.EventHandler(this.BtnComprar1_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Black;
            this.BtnInicio.Image = global::Tienda.Properties.Resources.inicio_icono_copia;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(162, 213);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(103, 36);
            this.BtnInicio.TabIndex = 15;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnZapatillas
            // 
            this.BtnZapatillas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnZapatillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZapatillas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZapatillas.ForeColor = System.Drawing.Color.Black;
            this.BtnZapatillas.Image = global::Tienda.Properties.Resources.zapatilla_icono_copia;
            this.BtnZapatillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnZapatillas.Location = new System.Drawing.Point(513, 213);
            this.BtnZapatillas.Name = "BtnZapatillas";
            this.BtnZapatillas.Size = new System.Drawing.Size(115, 36);
            this.BtnZapatillas.TabIndex = 13;
            this.BtnZapatillas.Text = "Zapatillas";
            this.BtnZapatillas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnZapatillas.UseVisualStyleBackColor = true;
            this.BtnZapatillas.Click += new System.EventHandler(this.BtnZapatillas_Click);
            // 
            // BtnPantalones
            // 
            this.BtnPantalones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPantalones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPantalones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPantalones.ForeColor = System.Drawing.Color.Black;
            this.BtnPantalones.Image = global::Tienda.Properties.Resources.pantalon_icono_copia;
            this.BtnPantalones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPantalones.Location = new System.Drawing.Point(392, 213);
            this.BtnPantalones.Name = "BtnPantalones";
            this.BtnPantalones.Size = new System.Drawing.Size(115, 36);
            this.BtnPantalones.TabIndex = 12;
            this.BtnPantalones.Text = "Pantalones";
            this.BtnPantalones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPantalones.UseVisualStyleBackColor = true;
            this.BtnPantalones.Click += new System.EventHandler(this.BtnPantalones_Click);
            // 
            // BtnCamiseta
            // 
            this.BtnCamiseta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCamiseta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCamiseta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCamiseta.ForeColor = System.Drawing.Color.Black;
            this.BtnCamiseta.Image = global::Tienda.Properties.Resources.camiseta_icono_copia;
            this.BtnCamiseta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCamiseta.Location = new System.Drawing.Point(271, 213);
            this.BtnCamiseta.Name = "BtnCamiseta";
            this.BtnCamiseta.Size = new System.Drawing.Size(115, 36);
            this.BtnCamiseta.TabIndex = 11;
            this.BtnCamiseta.Text = "Camisetas";
            this.BtnCamiseta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCamiseta.UseVisualStyleBackColor = true;
            this.BtnCamiseta.Click += new System.EventHandler(this.BtnCamiseta_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Image = global::Tienda.Properties.Resources.buscar_copia2;
            this.BtnBuscar.Location = new System.Drawing.Point(664, 147);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(41, 36);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Tienda.Properties.Resources.lista_copia;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(585, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mis pedidos";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // BtnCarrito
            // 
            this.BtnCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarrito.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarrito.Image = global::Tienda.Properties.Resources.carrito_copia5;
            this.BtnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarrito.Location = new System.Drawing.Point(486, 90);
            this.BtnCarrito.Name = "BtnCarrito";
            this.BtnCarrito.Size = new System.Drawing.Size(93, 39);
            this.BtnCarrito.TabIndex = 4;
            this.BtnCarrito.Text = "Carrito";
            this.BtnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCarrito.UseVisualStyleBackColor = true;
            this.BtnCarrito.Click += new System.EventHandler(this.BtnCarrito_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Image = global::Tienda.Properties.Resources.salir2;
            this.BtnSalir.Location = new System.Drawing.Point(620, 609);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(85, 40);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.SystemColors.Control;
            this.LblFecha.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(102, 111);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(0, 18);
            this.LblFecha.TabIndex = 22;
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Tick += new System.EventHandler(this.TimerFecha_Tick);
            // 
            // contenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.panelReemplazable2);
            this.Controls.Add(this.BtnCerrarVentanaCarro);
            this.Controls.Add(this.BtnAñadirAlCarro);
            this.Controls.Add(this.BtnComprar1);
            this.Controls.Add(this.panelReemplazable);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnZapatillas);
            this.Controls.Add(this.BtnPantalones);
            this.Controls.Add(this.BtnCamiseta);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextoBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCarrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "contenedorPrincipal";
            this.RightToLeftLayout = true;
            this.Text = "G U C C I";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCarrito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextoBusqueda;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCamiseta;
        private System.Windows.Forms.Button BtnPantalones;
        private System.Windows.Forms.Button BtnZapatillas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesYReclamosToolStripMenuItem;
        private System.Windows.Forms.Panel panelReemplazable;
        private System.Windows.Forms.Button BtnComprar1;
        private System.Windows.Forms.Button BtnAñadirAlCarro;
        private System.Windows.Forms.Panel panelReemplazable2;
        private System.Windows.Forms.Button BtnCerrarVentanaCarro;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer Fecha;
    }
}

