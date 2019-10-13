using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Formularios;

namespace Tienda
{
    class Pedido
    {
        //atributos que pertenecen a cada pedido
        private string producto, modelo, talle, unidades, color;
        private int total, id_pedido = 0;

        private PagoCliente pagoCliente;

        //get y set de cada atributo
        public string Producto { get => producto; set => producto = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Talle { get => talle; set => talle = value; }
        public string Unidades { get => unidades; set => unidades = value; }
        public string Color { get => color; set => color = value; }
        public int Total { get => total; set => total = value; }
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }

        public PagoCliente PagoCliente { get => pagoCliente; set => pagoCliente = value; }

        //constructor que se encarga de agregar un nuevo pedido
        public Pedido(string producto, string modelo, string talle, string unidades, string color, int idPedido, int total, string nombre, string apellidos, string pais, string localidad, string direccion, string fechaExpiracion, long nroTarjeta, int cvc)
        {
            Producto = producto;
            Modelo = modelo;
            Talle = talle;
            Unidades = unidades;
            Color = color;
            Total = total;
            Id_pedido = idPedido;

            //Composición: si se elimina el pedido, se borra el pago respectivo

             pagoCliente = new PagoCliente(nombre, apellidos, pais, localidad, direccion, fechaExpiracion, nroTarjeta, cvc);
        }

        public Pedido()
        {

        }

        public void agregarPedido(ListView listaPedidos)
        {
            //agrega todos los pedidos a la lista
            for(int i=0; i<PagoCliente.pedidos.Count;i++)
            {
                ListViewItem lista = new ListViewItem(((Pedido)PagoCliente.pedidos[i]).Producto);
                lista.SubItems.Add(((Pedido)PagoCliente.pedidos[i]).Modelo);
                lista.SubItems.Add(((Pedido)PagoCliente.pedidos[i]).Talle);
                lista.SubItems.Add(((Pedido)PagoCliente.pedidos[i]).Color);
                lista.SubItems.Add(((Pedido)PagoCliente.pedidos[i]).Unidades);
                lista.SubItems.Add(((Pedido)PagoCliente.pedidos[i]).PagoCliente.Pais);
                lista.SubItems.Add(((Pedido)PagoCliente.pedidos[i]).PagoCliente.Direccion);
                lista.SubItems.Add(Convert.ToString(((Pedido)PagoCliente.pedidos[i]).Id_pedido));
                lista.SubItems.Add(Convert.ToString(((Pedido)PagoCliente.pedidos[i]).Total));

                listaPedidos.Items.Add(lista);
            }
        }

        public void eliminarPedido(ListView listaPedidos)
        {
            //limpia el pedido seleccionado de la lista y del array
            foreach (ListViewItem seleccionado in listaPedidos.SelectedItems)
            {
                seleccionado.Remove();
                PagoCliente.pedidos.RemoveAt(seleccionado.Index + 1);
            }

        }

    }
}
