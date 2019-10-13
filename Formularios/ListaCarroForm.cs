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
    public partial class ListaCarroForm : Form
    {
        Carrito c = new Carrito();

        public ListaCarroForm()
        {
            InitializeComponent();
        }

        public void agregarCarroALista(ArrayList carro)
        {
            ListaCarrito.Items.Clear();
            //se agrega todo el carro a la lista del carrito
            c.agregarCarroLista(carro, ListaCarrito);
        }

        private void BtnComprarTodo_Click(object sender, EventArgs e)
        {
            //banderas utilizadas para futuras validaciones
            contenedorPrincipal.compraDesdeCarro = false;
            contenedorPrincipal.compraDirecta = false;
            contenedorPrincipal.comprarTodo = true;

            CompraForm c = new CompraForm();

            if (ListaCarrito.Items.Count > 0) //si hay al menos un item en la lista se muestra el formulario de compra
            {
                c.Show();
            }
        }

        private void BtnBorrarProducto_Click(object sender, EventArgs e)
        {

            c.borrarProductoDelCarro(contenedorPrincipal.carro, ListaCarrito);

            ListaCarrito.SelectedItems.Clear(); //se borra la referencia al item seleccionado
        }

        private void BtnComprarProducto_Click(object sender, EventArgs e)
        {
            //banderas utilizadas para futuras validaciones

            contenedorPrincipal.compraDesdeCarro = true;
            contenedorPrincipal.compraDirecta = false;
            contenedorPrincipal.comprarTodo = false;

            c.comprarProductoDelCarro(ListaCarrito);

            //se borra la referencia al item seleccionado
            ListaCarrito.SelectedItems.Clear(); 
        }
    }
}
