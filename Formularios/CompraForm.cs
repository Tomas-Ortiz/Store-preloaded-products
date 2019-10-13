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
using Tienda.Formularios;

namespace Tienda
{
    public partial class CompraForm : Form
    {
        private ArrayList pagosClientes = new ArrayList(); //array que guarda la información de compra del cliente
        public static int idPedido = 0; //identificador de cada pedido

        public static string prod, modelo, talle, color, unidades, precioTotal, descripcion;

        //banderas para verificar validaciones
        public static bool compraValida, formatoCorrecto = true;

        public CompraForm()
        {
            InitializeComponent();

            //al iniciar el form, se muestran los productos a comprar y se establece el formato del date time picker
            mostrarProductoAComprar();
            establecerFormatoDateTimePicker();
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            Close(); //si se cancela la compra, se cierra el formulario
        }

        private void BtnRealizarCompra_Click(object sender, EventArgs e) 
        {
            compraValida = true;

            PagoCliente p = new PagoCliente();

            //se obtiene la fecha de expiración seleccionada
            string fechaExpiracion = dtFecha.Text;

            try //se intenta verificar el pago, si ocurre algún error de formato se produce la excepción formatException
            {
                p.verificarValidezPago(TxtNombre.Text, txtApellido.Text, txtPais.Text, txtLocalidad.Text, txtDireccion.Text, fechaExpiracion, Convert.ToInt64(txtNroTarjeta.Text), Convert.ToInt32(txtCvc.Text));

            }catch(FormatException)
            {
                compraValida = false; //si ocurre un error, entonces la compra no es valida
            }

            try //se intenta validar cada campo ingresado del formulario
            {
                ControlExcepcion.detectarCampoError(TxtNombre, txtApellido, txtPais, txtLocalidad, txtDireccion, fechaExpiracion, txtNroTarjeta, txtCvc, dtFecha, errorProvider1);
            }
            catch(ExcepcionPropia) //ocurre una excepción propia cuando los digitos del cvc no coinicden o caracter inválido
            {
                compraValida = false; //si ocurre un error, entonces la compra no es valida
            }

            if (compraValida == true && formatoCorrecto == true) //si no se ha producido ningún error y la compra es valida 
            {           
                if (contenedorPrincipal.compraDirecta == true) //si compra el producto directamente
                {
                    idPedido++; //incremente el número de pedido

                    //se genera el pago del cliente con la información ingresada, y se agrega al array de pagos
                    p = new PagoCliente(TxtNombre.Text, txtApellido.Text, txtPais.Text, txtLocalidad.Text, txtDireccion.Text, fechaExpiracion, Convert.ToInt64(txtNroTarjeta.Text), Convert.ToInt32(txtCvc.Text), prod, modelo, talle, Convert.ToInt32(unidades), color, Convert.ToInt32(precioTotal));
                    pagosClientes.Add(p);

                }

                else if (contenedorPrincipal.compraDesdeCarro == true) //si compra el producto desde el carrito
                {
                    Carrito c = new Carrito();

                    idPedido++;

                    p = new PagoCliente(TxtNombre.Text, txtApellido.Text, txtPais.Text, txtLocalidad.Text, txtDireccion.Text, fechaExpiracion, Convert.ToInt64(txtNroTarjeta.Text), Convert.ToInt32(txtCvc.Text), prod, modelo, talle, Convert.ToInt32(unidades), color, Convert.ToInt32(precioTotal));
                    pagosClientes.Add(p);

                    c.borrarProductoCompradoDelCarro(); //una vez adquirido el producto, se lo borra del carrito
                }

                else if (contenedorPrincipal.comprarTodo == true) //si el cliente compra todos los productos del carro
                {
                        for (int i=0; i<contenedorPrincipal.carro.Count; i++) //se recorre todo el carro
                        {
                            idPedido++;

                            p = new PagoCliente(TxtNombre.Text, txtApellido.Text, txtPais.Text, txtLocalidad.Text, txtDireccion.Text, fechaExpiracion, Convert.ToInt64(txtNroTarjeta.Text), Convert.ToInt32(txtCvc.Text), ((Carrito)contenedorPrincipal.carro[i]).Producto, ((Carrito)contenedorPrincipal.carro[i]).Modelo, ((Carrito)contenedorPrincipal.carro[i]).Talle, ((Carrito)contenedorPrincipal.carro[i]).Unidades, ((Carrito)contenedorPrincipal.carro[i]).Color, Convert.ToInt32(((Carrito)contenedorPrincipal.carro[i]).Precio));
                            pagosClientes.Add(p);                 
                        }
                }

                //se verifican los productos más vendidos
                establecerProductosMasVendidos();

                //una vez comprado y verificado el total de vendidos, se cierra el formulario, se muestra un mensaje y se reinician las banderas
                Close(); 

                MessageBox.Show("¡Tu compra ha sido realizada con éxito!. \n \n Por favor, dirígete a la pestaña 'Mis pedidos' para revisar los detalles del envío.", " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                contenedorPrincipal.compraDirecta = false;
                contenedorPrincipal.compraDesdeCarro = false;
                contenedorPrincipal.comprarTodo = false;
            }
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {
            //si se hace click la primera vez, entonces se borra el texto contenido
            if (TxtNombre.Text == "Ingrese su nombre") 
            {
                TxtNombre.Clear();
            }

            //se establece una nueva fuente, tamaño y color del texto
            TxtNombre.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtNombre.ForeColor = Color.Black;
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Ingrese su apellido")
            {
                txtApellido.Clear();
            }

            txtApellido.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.ForeColor = Color.Black;
        }

        private void txtPais_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "Ingrese su país")
            {
                txtPais.Clear();
            }

            txtPais.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPais.ForeColor = Color.Black;

        }

        private void txtLocalidad_Click(object sender, EventArgs e)
        {
            if (txtLocalidad.Text == "Ingrese su localidad")
            {
                txtLocalidad.Clear();
            }

            txtLocalidad.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocalidad.ForeColor = Color.Black;
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Ingrese su direccion domiciliaria")
            {
                txtDireccion.Clear();
            }

            txtDireccion.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.ForeColor = Color.Black;
        }

        private void txtNroTarjeta_Click(object sender, EventArgs e)
        {
            if (txtNroTarjeta.Text == "Ingrese su número de tarjeta")
            {
                txtNroTarjeta.Clear();
            }

            txtNroTarjeta.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNroTarjeta.ForeColor = Color.Black;
        }

        private void txtCvc_Click(object sender, EventArgs e)
        {
            if (txtCvc.Text == "Ingrese el código de seguridad")
            {
                txtCvc.Clear();
            }

            txtCvc.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCvc.ForeColor = Color.Black;
        }

        private void mostrarProductoAComprar() //se muestran en el formulario de compra todos los productos a comprar
        {
            if (contenedorPrincipal.compraDesdeCarro == true) //Si compra desde el carro
            {
                //Se establece una nueva fuente, tamaño, y color para los labels
                //se ajustan algunas configuraciones de algunos labels
                lblP.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblM.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblT.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblC.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblU.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblTo.Font = new Font("Modern No. 20", 20, FontStyle.Regular, GraphicsUnit.Pixel);

                lblTo.AutoSize = true;
                lblTo.Location = new Point(15, 149);
                lblTo.BorderStyle = BorderStyle.FixedSingle;
                lblTo.TextAlign = ContentAlignment.MiddleCenter;

                lblProducto.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lblModelo.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lbTalle.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lblColor.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lblUnidades.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lbllTotal.Font = new Font("MS Reference Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Pixel);

                lblModelo.Size = new Size(212, 18);
                lbllTotal.Location = new Point(80, 153);

                //se establece el texto de todos los labels, según el producto a comprar
                lblProducto.Text = prod;
                lblModelo.Text = modelo;
                lbTalle.Text = talle;
                lblColor.Text = color;
                lblUnidades.Text = unidades;
                lbllTotal.Text = "$" + precioTotal;

                //finalmente se agregan los labels al panel de productos
                agregarProductoPanel();
            }
                else if (contenedorPrincipal.comprarTodo == true) //si compra todo
                {
                    int y = 0;

                    for (int i = 0; i < contenedorPrincipal.carro.Count; i++) //se recorre todo el carro
                    {
                        //se establece en cada iteración nuevos label's (para evitar que se sobreescriban)
                        //y la fuente, tamaño y color de los mismos
                        lblP.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblM.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblT.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblC.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblU.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblTo.Font = new Font("Modern No. 20", 20, FontStyle.Regular, GraphicsUnit.Pixel);

                        lblTo.AutoSize = true;
                        lblTo.TextAlign = ContentAlignment.MiddleCenter;
                        lblTo.BorderStyle = BorderStyle.FixedSingle;

                        lblProducto.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblModelo.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        lbTalle.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblColor.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        lblUnidades.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                        lbllTotal.Font = new Font("MS Reference Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Pixel);

                        lblModelo.Size = new Size(212, 18);

                        //se especifica en cada iteración el nombre de los label's y la información contenida de cada objeto del array
                        lblP.Text = "Producto:";
                        lblProducto.Text = ((Carrito)contenedorPrincipal.carro[i]).Producto;
                        //se establece la posición de cada label para mostrarla como una lista y para evitar que se sobrepongan
                        lblProducto.Location = new Point(80, y += 28);
                        lblP.Location = new Point(6, y);

                        lblM.Text = "Modelo:";
                        lblModelo.Text = ((Carrito)contenedorPrincipal.carro[i]).Modelo;
                        lblModelo.Location = new Point(80, y += 28);
                        lblM.Location = new Point(15, y);

                        lblT.Text = "Talle:";
                        lbTalle.Text = ((Carrito)contenedorPrincipal.carro[i]).Talle;
                        lbTalle.Location = new Point(80, y += 28);
                        lblT.Location = new Point(29, y);

                        lblC.Text = "Color:";
                        lblColor.Text = ((Carrito)contenedorPrincipal.carro[i]).Color;
                        lblColor.Location = new Point(80, y += 28);
                        lblC.Location = new Point(28, y);

                        lblU.Text = "Unidades:";            
                        lblUnidades.Text = Convert.ToString(((Carrito)contenedorPrincipal.carro[i]).Unidades);
                        lblUnidades.Location = new Point(80, y += 28);
                        lblU.Location = new Point(6, y);

                        lblTo.Text = "Total:";
                        lbllTotal.Text = "$" + Convert.ToString(((Carrito)contenedorPrincipal.carro[i]).Precio);
                        lbllTotal.Location = new Point(78, y += 40);
                        lblTo.Location = new Point(15, y-3);

                        //separador entre cada producto
                        lblSeparador2.Text = "_______________________________________";
                        lblSeparador2.AutoSize = true;
                        lblSeparador2.Location = new Point(0, y += 23);

                        agregarProductoPanel(); //se agregan los labels al panel
                        
                        //al final de cada iteración se crean nuevas instancias de los label's
                        lblProducto = new Label();
                        lblModelo = new Label();
                        lbTalle = new Label();
                        lblColor = new Label();
                        lblUnidades = new Label();
                        lbllTotal = new Label();
                        lblSeparador2 = new Label();
                        
                        lblP = new Label();
                        lblM = new Label();
                        lblT = new Label();
                        lblC = new Label();
                        lblU = new Label();
                        lblTo = new Label();
                        
                    }

                }
            
            else if(contenedorPrincipal.compraDirecta == true) //si es compra directa
            {

                lblP.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblM.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblT.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblC.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblU.Font = new Font("Modern No. 20", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                lblTo.Font = new Font("Modern No. 20", 20, FontStyle.Regular, GraphicsUnit.Pixel);

                lblTo.AutoSize = true;
                lblTo.Location = new Point(15, 149);
                lblTo.BorderStyle = BorderStyle.FixedSingle;
                lblTo.TextAlign = ContentAlignment.MiddleCenter;

                lblProducto.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lblModelo.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lbTalle.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lblColor.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lblUnidades.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                lbllTotal.Font = new Font("MS Reference Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Pixel);

                lblModelo.Size = new Size(212, 18);
                lbllTotal.Location = new Point(80, 153);

                lblProducto.Text = prod;
                lblModelo.Text = modelo;
                lbTalle.Text = talle;
                lblColor.Text = color;
                lblUnidades.Text = Convert.ToString(unidades);
                lbllTotal.Text = "$" + Convert.ToString(precioTotal);

                agregarProductoPanel();
            }
        }

        private void agregarProductoPanel() //método que se encarga de agregar los labels al panel de productos
        {
            panelProductos.Controls.Add(lblProducto);
            panelProductos.Controls.Add(lblModelo);
            panelProductos.Controls.Add(lbTalle);
            panelProductos.Controls.Add(lblColor);
            panelProductos.Controls.Add(lblUnidades);
            panelProductos.Controls.Add(lbllTotal);
            panelProductos.Controls.Add(lblSeparador2);

            panelProductos.Controls.Add(lblP);
            panelProductos.Controls.Add(lblM);
            panelProductos.Controls.Add(lblU);
            panelProductos.Controls.Add(lblT);
            panelProductos.Controls.Add(lblC);
            panelProductos.Controls.Add(lblTo);
        }

        private void establecerFormatoDateTimePicker()
        {
            //se especifica un formato customizado del datetimepicker
            dtFecha.Format = DateTimePickerFormat.Custom;
            //se establece el nuevo formato requerido
            dtFecha.CustomFormat = "dd/MM/yyyy"; 

            //se establece la fecha máxima y mínima a seleccionar
            dtFecha.MaxDate = new DateTime(2025, 6, 1);
            dtFecha.MinDate = DateTime.Today;
        }

        private void establecerProductosMasVendidos()
        {
            if (contenedorPrincipal.comprarTodo == true) //si se compra todo del carro
            {
                for (int j = 0; j < contenedorPrincipal.carro.Count; j++) //se recorre los productos de todo el carro
                {
                    for (int i = 0; i < Vestimenta.totalProductos / 3; i++) //se recorre la cantidad de productos
                    {
                        try
                        {
                            //si el producto del carrito coincide con algún producto registrado, se incrementa en uno el total de vendido para dicho producto
                            if (((Carrito)contenedorPrincipal.carro[j]).Producto == ((Remera)contenedorPrincipal.camisetas[i]).Producto() && ((Carrito)contenedorPrincipal.carro[j]).Modelo == ((Remera)contenedorPrincipal.camisetas[i]).Modelo())
                            {
                                ((Remera)contenedorPrincipal.camisetas[i]).TotalVendido++;
                            }
                            else if (((Carrito)contenedorPrincipal.carro[j]).Producto == ((Pantalon)contenedorPrincipal.pantalones[i]).Producto() && ((Carrito)contenedorPrincipal.carro[j]).Modelo == ((Pantalon)contenedorPrincipal.pantalones[i]).Modelo())
                            {
                                ((Pantalon)contenedorPrincipal.pantalones[i]).TotalVendido++;
                            }
                            else if (((Carrito)contenedorPrincipal.carro[j]).Producto == ((Zapatilla)contenedorPrincipal.zapatillas[i]).Producto() && ((Carrito)contenedorPrincipal.carro[j]).Modelo == ((Zapatilla)contenedorPrincipal.zapatillas[i]).Modelo())
                            {
                                ((Zapatilla)contenedorPrincipal.zapatillas[i]).TotalVendido++;
                            }
                        }

                        catch (ArgumentOutOfRangeException)
                        {

                        }
                    }
                }

                contenedorPrincipal.carro.Clear(); //una vez comprado todo y verificado el total de vendidos, se borra el carro
            }

            else //si es compra directa o desde el carro
            {
                for (int i = 0; i < contenedorPrincipal.camisetas.Count; i++)
                {
                    //si el producto o modelo coincide con algún producto registrado, se incrementa el total de vendidos para dicho producto
                    if (lblProducto.Text == ((Remera)contenedorPrincipal.camisetas[i]).Producto() && lblModelo.Text == ((Remera)contenedorPrincipal.camisetas[i]).Modelo())
                    {
                        ((Remera)contenedorPrincipal.camisetas[i]).TotalVendido++;
                    }
                }

                for (int i = 0; i < contenedorPrincipal.pantalones.Count; i++)
                {
                    if (lblProducto.Text == ((Pantalon)contenedorPrincipal.pantalones[i]).Producto() && lblModelo.Text == ((Pantalon)contenedorPrincipal.pantalones[i]).Modelo())
                    {
                        ((Pantalon)contenedorPrincipal.pantalones[i]).TotalVendido++;
                    }
                }

                for (int i = 0; i < contenedorPrincipal.zapatillas.Count; i++)
                {
                    if (lblProducto.Text == ((Zapatilla)contenedorPrincipal.zapatillas[i]).Producto() && lblModelo.Text == ((Zapatilla)contenedorPrincipal.zapatillas[i]).Modelo())
                    {
                        ((Zapatilla)contenedorPrincipal.zapatillas[i]).TotalVendido++;
                    }
                }
            }
        }
    }
}
