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
    public partial class CamisetaForm : Form
    {
        private static ArrayList camisetaAux = new ArrayList(); //aux del array camiseta
        Remera r = new Remera();

        public CamisetaForm(ArrayList camisetas)
        {
            InitializeComponent();

            //Se especifica el estilo del combobox de ordenar
            cmbOrdenarCamiseta.DropDownStyle = ComboBoxStyle.DropDownList;
            //se selecciona el primer elemento del combobox (seleccione)
            cmbOrdenarCamiseta.SelectedIndex = 0;

            r.agregarCamisetasLista(camisetas, ListaCamisetas);

        }

        public void mostrarInterfazCarro(ArrayList camisetas)
        {
            AñadirCarroForm c = new AñadirCarroForm();
            //si el producto seleccionado es de tipo camisetas, se pasa como parámetro el array de camisetas,junto con su ListView
            //para mostrar el producto en la interfaz del carro
            c.mostrarInformacionCarro(camisetas, ListaCamisetas);

            c.Show(); //se muestra el formulario de añadir al carro
        }

        public static void obtenerCamiseta(ArrayList camisetas)
        {
            //se obtiene el array de camisetas y se lo iguala a un auxiliar
            camisetaAux = camisetas;
        }

        private void cmbOrdenarCamiseta_Click_1(object sender, EventArgs e)
        {
            //Al hacer click en el combobox se elimina la opción de 'seleccione'
            cmbOrdenarCamiseta.Items.Remove("        Seleccione");
        }

        private void cmbOrdenarCamiseta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //si se cambia la opción de ordenamiento, se borra la lista de camisetas
            ListaCamisetas.Items.Clear();
            //se obtiene la opcion seleccionada del combobox
            string item = Convert.ToString(cmbOrdenarCamiseta.SelectedItem);

            //se ordena la lista de camisetas según la opción elegida
            r.ordenarListaCamiseta(item, camisetaAux, ListaCamisetas); 

        }
    }
}
