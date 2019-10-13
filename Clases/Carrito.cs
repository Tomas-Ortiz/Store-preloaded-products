using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    class Carrito
    {
        //atributos propios de cada producto añadido al carro
        private string producto, color, talle, modelo, descripicion, precio;
        private int unidades;

        public string Producto { get => producto; set => producto = value; }
        public string Color { get => color; set => color = value; }
        public string Talle { get => talle; set => talle = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Descripicion { get => descripicion; set => descripicion = value; }

        //constructor que añade un producto al carro
        public Carrito(string producto, string modelo, string precio, string color, string talle, int unidades, string descripcion)
        {           
            Producto = producto;
            Modelo = modelo;
            Color = color;
            Talle = talle;
            Unidades = unidades;
            Precio = precio;
            Descripicion = descripcion;
        }

        public Carrito()
        {

        }

        public void agregarCarroLista(ArrayList carro, ListView ListaCarro)
        {
            for (int i = 0; i < carro.Count; i++)
            {
                ListViewItem l = new ListViewItem(((Carrito)carro[i]).Producto);
                l.SubItems.Add(((Carrito)carro[i]).Modelo);
                l.SubItems.Add(((Carrito)carro[i]).Talle);
                l.SubItems.Add(((Carrito)carro[i]).Color);
                l.SubItems.Add(Convert.ToString(((Carrito)carro[i]).Unidades));
                l.SubItems.Add(Convert.ToString(((Carrito)carro[i]).Precio));

                ListaCarro.Items.Add(l);
            }
        }

        public void borrarProductoDelCarro(ArrayList carro, ListView ListaCarro)
        {
            if (ListaCarro.SelectedItems.Count != 0) //si ha seleccionado al menos 1 producto
            {
                foreach (ListViewItem producto in ListaCarro.SelectedItems)
                {
                    //borra el producto del carro y de la lista
                    carro.RemoveAt(producto.Index);
                    producto.Remove();
                }
            }
        }

        public void comprarProductoDelCarro(ListView ListaCarrito)
        {
            if (ListaCarrito.SelectedItems.Count != 0) ////si ha seleccionado al menos 1 producto
            {
                foreach (ListViewItem seleccionado in ListaCarrito.SelectedItems)
                {
                    //se guarda la información del producto a comprar

                    CompraForm.prod = seleccionado.SubItems[0].Text;
                    CompraForm.modelo = seleccionado.SubItems[1].Text;
                    CompraForm.talle = seleccionado.SubItems[2].Text;
                    CompraForm.color = seleccionado.SubItems[3].Text;
                    CompraForm.unidades = seleccionado.SubItems[4].Text;
                    CompraForm.precioTotal = seleccionado.SubItems[5].Text;
                }

                CompraForm c = new CompraForm();
                c.Show(); //se muestra el formulario de compra
            }
        }

        public void borrarProductoCompradoDelCarro()
        {
            for (int i = 0; i < contenedorPrincipal.carro.Count; i++)
            {
                if (((Carrito)contenedorPrincipal.carro[i]).Producto == CompraForm.prod && ((Carrito)contenedorPrincipal.carro[i]).Modelo == CompraForm.modelo && ((Carrito)contenedorPrincipal.carro[i]).Talle == CompraForm.talle && ((Carrito)contenedorPrincipal.carro[i]).Color == CompraForm.color && ((Carrito)contenedorPrincipal.carro[i]).Unidades == Convert.ToInt32(CompraForm.unidades) && ((Carrito)contenedorPrincipal.carro[i]).Precio == CompraForm.precioTotal)
                {
                    contenedorPrincipal.carro.RemoveAt(i);
                }
            }
        }
    }  
}
