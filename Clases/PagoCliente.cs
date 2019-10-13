using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    class PagoCliente
    {
        //atributos propios del pago de cada cliente
        private string nombre, apellidos, pais, localidad, direccion, fechaExpiracion;
        private int cvc, precioTotal;
        private long nroTarjeta;
        public static ArrayList pedidos = new ArrayList(); //array que guarda los pedidos generados por cada compra

        Pedido pedido;

        //get y set de dichos atributos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string FechaExpiracion { get => fechaExpiracion; set => fechaExpiracion = value; }
        public int Cvc { get => cvc; set => cvc = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public long NroTarjeta { get => nroTarjeta; set => nroTarjeta = value; }

        public Pedido Pedido { get => pedido; set => pedido = value; }

        //sobrecarga de constructores

        //constructor que se encarga de agregar un nuevo pago
        public PagoCliente(string nombre, string apellidos, string pais, string localidad, string direccion, string fechaExpiracion, long nroTarjeta, int cvc, string producto, string modelo, string talle, int unidades, string color, int precioTotal)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Pais = pais;
            Localidad = localidad;
            Direccion = direccion;
            FechaExpiracion = fechaExpiracion;
            NroTarjeta = nroTarjeta;
            Cvc = cvc;
            PrecioTotal = precioTotal;

            //Composición: si se elimina el pago del cliente se elimina su respectivo pedido
            //se genera el pedido del cliente que realizo la compra, y se agrega al array de pedidos

            Pedido = new Pedido(producto, modelo, talle, Convert.ToString(unidades), color, CompraForm.idPedido, precioTotal, nombre, apellidos, pais, localidad, direccion, fechaExpiracion, nroTarjeta, cvc);
            pedidos.Add(Pedido);
        }


        public PagoCliente(string nombre, string apellidos, string pais, string localidad, string direccion, string fechaExpiracion, long nroTarjeta, int cvc)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Pais = pais;
            Localidad = localidad;
            Direccion = direccion;
            FechaExpiracion = fechaExpiracion;
            NroTarjeta = nroTarjeta;
            Cvc = cvc;
            PrecioTotal = precioTotal;

        }

        public PagoCliente()
        {

        }

        public void verificarValidezPago(string nombre, string apellidos, string pais, string localidad, string direccion, string fechaExpiracion, long nroTarjeta, int cvc)
        {

                
        }

    }

}
