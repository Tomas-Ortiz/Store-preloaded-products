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
    public partial class ZapatillaForm : Form
    {
        private static ArrayList zapatillaAux = new ArrayList();
        Zapatilla z = new Zapatilla();

        public ZapatillaForm(ArrayList zapatillas)
        {
            InitializeComponent();

            cmbOrdenarZapatilla.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbOrdenarZapatilla.SelectedIndex = 0;

            z.agregarZapatillasLista(zapatillas, ListaZapatillas);           
        }

        public void mostrarInterfazCarro(ArrayList zapatillas)
        {
            AñadirCarroForm c = new AñadirCarroForm();

            c.mostrarInformacionCarro(zapatillas, ListaZapatillas);

            c.Show();
            c.BringToFront();
        }

        public static void obtenerZapatilla(ArrayList zapatillas)
        {
            zapatillaAux = zapatillas;
        }

        private void cmbOrdenarZapatilla_Click(object sender, EventArgs e)
        {
            cmbOrdenarZapatilla.Items.Remove("        Seleccione");
        }

        private void cmbOrdenarZapatilla_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListaZapatillas.Items.Clear();

            string item = Convert.ToString(cmbOrdenarZapatilla.SelectedItem);

            z.ordenarListaZapatillas(item, zapatillaAux, ListaZapatillas);
        }

    }
}
