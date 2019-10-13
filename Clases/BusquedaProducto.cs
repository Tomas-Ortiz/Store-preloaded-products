using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    class BusquedaProducto
    {

        string productoBuscado;

        public BusquedaProducto()
        {

        }

        public void buscarFiltrado(string productoBuscado,ListView ListaProductos)
        {
            ListaProductos.Items.Clear(); //se limpia la lista
            ListaProductos.Columns.Clear();

            ListaProductos.Columns.Add("Producto", 150, HorizontalAlignment.Left);
            ListaProductos.Columns.Add("Modelo", 200, HorizontalAlignment.Left);
            ListaProductos.Columns.Add("Precio", 80, HorizontalAlignment.Left);

            for (int i = 0; i < Vestimenta.totalProductos / 3; i++) //se itera según la cantidad de productos
            {
                //toLower para convertir la cadena en minúscula
                //los productos se filtra por modelo o nombre del producto
                if (productoBuscado == ((Remera)contenedorPrincipal.camisetas[i]).Modelo().ToLower() || productoBuscado == ((Remera)contenedorPrincipal.camisetas[i]).Producto().ToLower())
                {
                    ListViewItem filtrado = new ListViewItem(((Remera)contenedorPrincipal.camisetas[i]).Producto());
                    filtrado.SubItems.Add(((Remera)contenedorPrincipal.camisetas[i]).Modelo());
                    filtrado.SubItems.Add(Convert.ToString(((Remera)contenedorPrincipal.camisetas[i]).Precio()));

                    ListaProductos.Items.Add(filtrado); //se agrega a la lista el producto filtrado
                }
                else if (productoBuscado == ((Pantalon)contenedorPrincipal.pantalones[i]).Modelo().ToLower() || productoBuscado == ((Pantalon)contenedorPrincipal.pantalones[i]).Producto().ToLower())
                {
                    ListViewItem filtrado = new ListViewItem(((Pantalon)contenedorPrincipal.pantalones[i]).Producto());
                    filtrado.SubItems.Add(((Pantalon)contenedorPrincipal.pantalones[i]).Modelo());
                    filtrado.SubItems.Add(Convert.ToString(((Pantalon)contenedorPrincipal.pantalones[i]).Precio()));

                    ListaProductos.Items.Add(filtrado);
                }
                else if (productoBuscado == ((Zapatilla)contenedorPrincipal.zapatillas[i]).Modelo().ToLower() || productoBuscado == ((Zapatilla)contenedorPrincipal.zapatillas[i]).Producto().ToLower())
                {
                    ListViewItem filtrado = new ListViewItem(((Zapatilla)contenedorPrincipal.zapatillas[i]).Producto());
                    filtrado.SubItems.Add(((Zapatilla)contenedorPrincipal.zapatillas[i]).Modelo());
                    filtrado.SubItems.Add(Convert.ToString(((Zapatilla)contenedorPrincipal.zapatillas[i]).Precio()));

                    ListaProductos.Items.Add(filtrado);
                }
            }

            if (ListaProductos.Items.Count == 0) //si no existe ningún item en la lista es porque no se encontraron resultados
            {
                //se borran todas las columnas y se agrega una llamada 'mensaje' y se establece el tamaño y posición
                ListaProductos.Columns.Clear();

                ListaProductos.Columns.Add("", 1);
                ListaProductos.Columns.Add("Mensaje", 429, HorizontalAlignment.Center);

                //se agrega un mensaje a la lista
                ListViewItem mensaje = new ListViewItem("");
                mensaje.SubItems.Add("       No se han encontrado resultados");

                ListaProductos.Items.Add(mensaje);
            }
        }

        public string obtenerProductoSeleccionado(ListView ListaProductos)
        {
            //se obtiene  y devuelve el producto seleccionado de la lista de productos filtrados

            productoBuscado = "";

            foreach (ListViewItem seleccionado in ListaProductos.SelectedItems)
            {
                productoBuscado = seleccionado.SubItems[0].Text;

                return productoBuscado;
            }

            return productoBuscado;
        }
    }
}
