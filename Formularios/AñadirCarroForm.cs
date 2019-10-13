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
    public partial class AñadirCarroForm : Form
    {

        public AñadirCarroForm()
        {
            InitializeComponent();

            if(contenedorPrincipal.flag == true) //si se seleccionó para comprar directo el producto entonces
            {
                //se desactiva el botón de añadir al carro y se activa el de comprar
                BtnAñadirAlCarro2.Visible = false; 
                BtnComprar.Location = new Point(228, 428);
                BtnComprar.Visible = true;

                contenedorPrincipal.flag = false;
            }

            //se especifica el estilo del combobox y las unidades mínimas a comprar
            cmbColores.DropDownStyle = ComboBoxStyle.DropDownList; 
            cmbTalles.DropDownStyle = ComboBoxStyle.DropDownList;
            UnidadesTotal.Minimum = 1;
        }

        //método que se encarga de establecer el producto seleccionado en la interfaz para añadirlo al carro
        //recibe como argumento el array según el tipo de producto seleccionado (camiseta, remera..) junto con su listview
        public void mostrarInformacionCarro(ArrayList producto, ListView listaProducto) 
        {
            foreach (ListViewItem productoSeleccionado in listaProducto.SelectedItems) //recorre la lista hasta el producto seleccionado
            {
                if (productoSeleccionado.SubItems.Count > 0) //si el producto seleccionado tiene más de un subitem (forma de validar)
                {
                    //se establecen los labels según el producto seleccionado
                    LblNombreProd.Text = productoSeleccionado.SubItems[0].Text;

                    LblModelo.Text = productoSeleccionado.SubItems[1].Text;

                    LblPrecioUnidad.Text = productoSeleccionado.SubItems[2].Text;

                    CompraForm.precioTotal = Convert.ToString(LblPrecioUnidad.Text);

                    LblPrecioTotal.Text = Convert.ToString(CompraForm.precioTotal);                  

                    for (int i=0; i<producto.Count;i++) //se recorre según la cantidad de elementos del array recibido
                    {
                        if (producto[i].GetType() == typeof(Pantalon)) //si el array es de tipo Pantalon
                        {
                            //si un modelo coincide con el producto seleccionado 
                            if (((Pantalon)producto[i]).Modelo() == productoSeleccionado.SubItems[1].Text)
                            {
                                //se establece la descripción del producto
                                LblDescripcion.Text = ((Pantalon)producto[i]).Descripcion;

                                foreach (var color in ((Pantalon)producto[i]).Colores)
                                {
                                    //se completa el combobox de los colores disponibles para ese producto
                                    cmbColores.Items.Add(color);
                                }

                                foreach (var talle in ((Pantalon)producto[i]).Talles)
                                {
                                    //se completa el combobox de los talles disponibles para ese producto
                                    cmbTalles.Items.Add(talle);
                                }
                            }
                        }

                        else if(producto[i].GetType() == typeof(Remera)) //si el array es de tipo Remera
                        {                           
                                if (((Remera)producto[i]).Modelo() == productoSeleccionado.SubItems[1].Text)
                                {

                                    LblDescripcion.Text = ((Remera)producto[i]).Descripcion;

                                foreach (var color in ((Remera)producto[i]).Colores)
                                    {
                                        cmbColores.Items.Add(color);
                                    }

                                    foreach (var talle in ((Remera)producto[i]).Talles)
                                    {
                                        cmbTalles.Items.Add(talle);
                                    }
                                }                         
                        }

                        else if(producto[i].GetType()==typeof(Zapatilla)) //si el array es de tipo Zapatilla
                        {
                            if (((Zapatilla)producto[i]).Modelo() == productoSeleccionado.SubItems[1].Text)
                            {

                                LblDescripcion.Text = ((Zapatilla)producto[i]).Descripcion;

                                foreach (var color in ((Zapatilla)producto[i]).Colores)
                                {
                                    cmbColores.Items.Add(color);
                                }

                                foreach (var talle in ((Zapatilla)producto[i]).TallaZapatilla)
                                {
                                    cmbTalles.Items.Add(talle);
                                }
                            }
                        }
                    }
                }

                //se setea el producto a comprar 
                CompraForm.prod = LblNombreProd.Text;
                CompraForm.modelo = LblModelo.Text;
                CompraForm.descripcion = LblDescripcion.Text;
            }

            //una vez registrado el producto, se selecciona por defecto el primer elemento de los combobox
            cmbColores.SelectedIndex = 0;
            cmbTalles.SelectedIndex = 0;
        }

        private void BtnAñadirAlCarro2_Click(object sender, EventArgs e)
        {
            //se recibe el color, talle y unidades seleccionados

            CompraForm.color = cmbColores.SelectedItem.ToString();
            CompraForm.talle = cmbTalles.SelectedItem.ToString();
            CompraForm.unidades = Convert.ToString(UnidadesTotal.Value);

            //se verifica el tipo de producto y se lo agrega al carro
            if (LblNombreProd.Text == "Remera Gucci")
            {
                Carrito c = new Carrito(CompraForm.prod, CompraForm.modelo, Convert.ToString(CompraForm.precioTotal), CompraForm.color, CompraForm.talle, Convert.ToInt32(CompraForm.unidades), CompraForm.descripcion);
                contenedorPrincipal.carro.Add(c);
            }
            else if(LblNombreProd.Text == "Pantalon Gucci")
            {
                Carrito c = new Carrito(CompraForm.prod, CompraForm.modelo, Convert.ToString(CompraForm.precioTotal), CompraForm.color, CompraForm.talle, Convert.ToInt32(CompraForm.unidades), CompraForm.descripcion);
                contenedorPrincipal.carro.Add(c);
            }
            else if(LblNombreProd.Text == "Zapatilla Gucci")
            {
                Carrito c = new Carrito(CompraForm.prod, CompraForm.modelo, Convert.ToString(CompraForm.precioTotal), CompraForm.color, CompraForm.talle, Convert.ToInt32(CompraForm.unidades), CompraForm.descripcion);
                contenedorPrincipal.carro.Add(c);
            }

            Close(); //una vez apretado el botón y agregado el producto, se cierra la ventana

            mostrarMensaje(); //muestra mensaje informativo al final
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            Close();   //cierra este formulario
        }

        public void mostrarMensaje()
        {
            MessageBox.Show(" El producto ha sido añadido al carro. \n \n Puedes ubicarlo y comprarlo dando click en la botón 'Carrito'.", " Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UnidadesTotal_ValueChanged(object sender, EventArgs e)   //se evalúa el valor cada vez que se modifica
        {
            //se establece el precio total según las unidades seleccionadas y el precio por unidad
            int precioT = Convert.ToInt32(LblPrecioUnidad.Text) * Convert.ToInt32(UnidadesTotal.Value);

            CompraForm.precioTotal = Convert.ToString(precioT);

            //se muestra en el label el precio total obtenido
            LblPrecioTotal.Text = Convert.ToString(CompraForm.precioTotal);
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            CompraForm.color = cmbColores.SelectedItem.ToString();
            CompraForm.talle = cmbTalles.SelectedItem.ToString();
            CompraForm.unidades = Convert.ToString(UnidadesTotal.Value);

            Close(); //se cierra el formulario al proceder a la compra

            CompraForm c = new CompraForm();

            c.Show(); //se muestra el nuevo formulario para llevar a cabo la compra
        }

    }
}
