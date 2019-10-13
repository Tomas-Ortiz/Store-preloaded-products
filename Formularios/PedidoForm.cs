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
    public partial class PedidoForm : Form
    {
        Pedido p = new Pedido();

        public PedidoForm()
        {
            InitializeComponent();
        }

        public void agregarPedidos()
        {
            //agrega todos los pedidos a la lista
            p.agregarPedido(ListaPedido);
        }

        private void BtnBorrarPedido_Click(object sender, EventArgs e)
        {
            //elimina el producto seleccionado
            p.eliminarPedido(ListaPedido);
        }
    }
}
