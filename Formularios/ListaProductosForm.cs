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

namespace Tienda.Formularios
{
    public partial class ListaProductosForm : Form
    {
        BusquedaProducto p = new BusquedaProducto();

        public ListaProductosForm()
        {
            InitializeComponent();
        }

        public void filtrarProducto(string productoBuscado) //se recibe como parámetro el producto a buscar
        {
            p.buscarFiltrado(productoBuscado, ListaProductos);
        }

        public string productoDesconocidoSeleccionado()
        {
            return p.obtenerProductoSeleccionado(ListaProductos);
        }

        public void mostrarInterfazCarro(ArrayList productoBuscado) //recibe como parámetro el tipo de producto seleccionado

        {
            AñadirCarroForm c = new AñadirCarroForm();

            //se pasa como argumento el tipo de producto seleccionado y la lista de productos
            c.mostrarInformacionCarro(productoBuscado, ListaProductos);

            c.Show(); //se muestra el formulario para añadirlo al carro
        }
    }
}
