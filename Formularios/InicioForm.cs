using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void UrlGucci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //inicia un recurso de proceso con la especificación del nombre de un link
            System.Diagnostics.Process.Start("https://www.gucci.com/int/en/");
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            //Se establece en el inicio la hora actual del sistema con el formato indicado
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }

    }
}
