namespace Tienda
{
    partial class InicioForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.informaciónGucci = new System.Windows.Forms.Label();
            this.UrlGucci = new System.Windows.Forms.LinkLabel();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 1;
            // 
            // informaciónGucci
            // 
            this.informaciónGucci.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informaciónGucci.Location = new System.Drawing.Point(16, 60);
            this.informaciónGucci.Name = "informaciónGucci";
            this.informaciónGucci.Size = new System.Drawing.Size(606, 192);
            this.informaciónGucci.TabIndex = 2;
            this.informaciónGucci.Text = resources.GetString("informaciónGucci.Text");
            // 
            // UrlGucci
            // 
            this.UrlGucci.AutoSize = true;
            this.UrlGucci.Location = new System.Drawing.Point(198, 174);
            this.UrlGucci.Name = "UrlGucci";
            this.UrlGucci.Size = new System.Drawing.Size(157, 13);
            this.UrlGucci.TabIndex = 3;
            this.UrlGucci.TabStop = true;
            this.UrlGucci.Text = "https://www.gucci.com/int/en/";
            this.UrlGucci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlGucci_LinkClicked);
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHora.Location = new System.Drawing.Point(221, 225);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(184, 69);
            this.lblHora.TabIndex = 4;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(201, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 104);
            this.label3.TabIndex = 25;
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 334);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.UrlGucci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.informaciónGucci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioForm";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label informaciónGucci;
        private System.Windows.Forms.LinkLabel UrlGucci;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label3;
    }
}