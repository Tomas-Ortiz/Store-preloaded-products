using System;
using System.Collections;
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
    public partial class PantalonForm : Form
    {
        private static ArrayList pantalonAux = new ArrayList();

        Pantalon p = new Pantalon();

        public PantalonForm(ArrayList pantalones)
        {
            InitializeComponent();

            cmbOrdenarPantalon.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbOrdenarPantalon.SelectedIndex = 0;

            p.agregarPantalonesLista(pantalones, ListaPantalones);

        }

        public void mostrarInterfazCarro(ArrayList pantalones)
        {
            AñadirCarroForm c = new AñadirCarroForm();

            c.mostrarInformacionCarro(pantalones, ListaPantalones);

            c.Show();
            c.BringToFront();
        }

        public static void obtenerPantalon(ArrayList pantalon)
        {
            pantalonAux = pantalon;
        }

        private void cmbOrdenarPantalon_Click_1(object sender, EventArgs e)
        {
            cmbOrdenarPantalon.Items.Remove("        Seleccione");

        }

        private void cmbOrdenarPantalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaPantalones.Items.Clear();

            string item = Convert.ToString(cmbOrdenarPantalon.SelectedItem);

            p.ordenarListaPantalones(item, pantalonAux, ListaPantalones);
        }

    }
}
