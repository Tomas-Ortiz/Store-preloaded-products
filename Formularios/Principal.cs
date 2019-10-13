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
    public partial class contenedorPrincipal : Form
    {
        private static int idProducto = 0;  //identificador de cada producto registrado

        public static ArrayList camisetas = new ArrayList();
        public static ArrayList pantalones = new ArrayList();
        public static ArrayList zapatillas = new ArrayList();
        public static ArrayList carro = new ArrayList();
        private string formularioActual;

        //banderas 
        public static bool flag = false, compraDesdeCarro = false, compraDirecta = false, comprarTodo = false;

        CamisetaForm c; //se declara una instancia de cada formulario
        ZapatillaForm za;
        PantalonForm p;
        PedidoForm pe;

        ListaProductosForm l = new ListaProductosForm();

        public contenedorPrincipal()
        {
            //el programa se inicializa con el formulario inicio, con el boton de inicio activado y 
            //todos los productos disponibles

            InitializeComponent();

            abrirFormularioHijo(new InicioForm());
            BtnInicio.Select();
            tiendaToolStripMenuItem.Select();

            cargarCamisetas();
            cargarPantalones();
            cargarZapatillas();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCarrito_Click(object sender, EventArgs e)
        {

            configurarBotonPanel2(); //se desactivan y activan algunos botones

            ListaCarroForm l = new ListaCarroForm();
            l.agregarCarroALista(carro);

            abrirFormularioHijo2(l); //se envia por parámetro la instancia del formulario a cargar

        }

        private void abrirFormularioHijo(object FormHijo) //panel que se utiliza para los formularios de los productos
        {
            if (panelReemplazable.Controls.Count > 0)  //si existe un formulario ya cargado en el panel, se borra 
            {
                panelReemplazable.Controls.RemoveAt(0);
            }

            Form fh = FormHijo as Form;  //se crea nueva instancia de form (fh), que toma al  objeto FormHijo como un formulario
            fh.TopLevel = false;    //el formulario no se muestra como un formualario superior (formulario hijo)
            fh.Dock = DockStyle.Fill; //se establece la posición y la forma en la que se acopla el formulario al contenedor principal
            panelReemplazable.Controls.Add(fh); //se agrega el formulario al control 
            panelReemplazable.Tag = fh; //se establece el objeto que contiene datos sobre el control
            fh.Show(); //finalmente se muestra el formulario cargado

            if (FormHijo.GetType() == typeof(InicioForm)) //si el tipo de la instancia actual es el inicio
            {
                BtnComprar1.Visible = false;    //se desactivan dichos botones 
                BtnAñadirAlCarro.Visible = false;
            }
            else
            {
                BtnComprar1.Visible = true;
                BtnAñadirAlCarro.Visible = true; //sino, se activan en los formularios de camiseta, pantalon, zapatilla
                BtnComprar1.Location = new Point(493, 550);
                BtnAñadirAlCarro.Location = new Point(161, 550);
            }

        }

        private void abrirFormularioHijo2(object FormHijo2) //panel que se utiliza para los formularios de carrito y pedidos
        {

            if (panelReemplazable2.Controls.Count > 0)
            {
                panelReemplazable2.Controls.RemoveAt(0);
            }

            Form fh2 = FormHijo2 as Form;

            fh2.TopLevel = false;
            fh2.Dock = DockStyle.Fill;
            panelReemplazable2.Controls.Add(fh2);
            panelReemplazable2.Tag = fh2;

            fh2.Show();        
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new InicioForm());  //se pasa una nueva instancia del formulario como parámetro

            configurarTextoBusqueda();

            formularioActual = "Inicio"; //se establece el formulario cargado actualmente como bandera, para futuras verificaciones
        }

        private void BtnCamiseta_Click(object sender, EventArgs e)
        {    
            //se pasa como argumento las camisetas, para que sean cargadas en su respectiva lista
            c = new CamisetaForm(camisetas); //nueva instancia para evitar que se repitan los elementos

            formularioActual = "Camiseta";

            configurarTextoBusqueda();

            abrirFormularioHijo(c); //se pasa como parámetro la instancia del formulario (c)

            CamisetaForm.obtenerCamiseta(camisetas); //se obtiene el array de camisetas en la clase Camiseta Form       
        }

        private void borrarTextoBuscado_Click(object sender, EventArgs e)
        {
            TextoBusqueda.Clear();  //se borra el texto ingresado
        }

        private void BtnPantalones_Click(object sender, EventArgs e)
        {
            p = new PantalonForm(pantalones);

            formularioActual = "Pantalon";

            configurarTextoBusqueda();

            abrirFormularioHijo(p);

            PantalonForm.obtenerPantalon(pantalones);
        }

        private void BtnZapatillas_Click(object sender, EventArgs e)
        {
            za = new ZapatillaForm(zapatillas);

            formularioActual = "Zapatilla";

            configurarTextoBusqueda();

            abrirFormularioHijo(za);

            ZapatillaForm.obtenerZapatilla(zapatillas);
        }

        private void BtnComprar1_Click(object sender, EventArgs e)
        {
            flag = true;

            compraDirecta = true; //banderas utilizadas para saber que opción seleccionó el cliente, para futuras validaciones
            compraDesdeCarro = false;
            comprarTodo = false;

            try
            {
                indicarProductoSeleccionado(); //se intenta registrar el producto seleccionado

            }catch(ArgumentOutOfRangeException fueraDeRango) //si no se ha seleccionado ninguno ocurre excepción
            {
                MessageBox.Show(" Por favor seleccione un producto a comprar. \n \nError: "+fueraDeRango.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAñadirAlCarro_Click(object sender, EventArgs e)
        {
            try
            {
                indicarProductoSeleccionado();
            }
            catch (ArgumentOutOfRangeException fueraDeRango)
            {
                MessageBox.Show(" Por favor seleccione un producto a añadir. \n \nError: " + fueraDeRango.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void indicarProductoSeleccionado() //se intenta establecer el producto seleccionado según el formulario cargado
        {
            //se pasa un array según el formulario cargado, para posteriormente agregar el producto a la interfaz del carro

            if (panelReemplazable.Tag.GetType() == typeof(CamisetaForm))
            {
                c.mostrarInterfazCarro(camisetas); 
            }
            else if (panelReemplazable.Tag.GetType() == typeof(PantalonForm))
            {
                p.mostrarInterfazCarro(pantalones);
            }
            else if (panelReemplazable.Tag.GetType() == typeof(ZapatillaForm))
            {
                za.mostrarInterfazCarro(zapatillas);
            }
            else if(panelReemplazable.Tag.GetType() == typeof(ListaProductosForm)) //si se buscan productos por filtro
            {
                string producto = l.productoDesconocidoSeleccionado(); //se obtiene el tipo de producto seleccionado en la lista

                //según el tipo de producto se pasa el array correspondido

                if (producto == "Remera Gucci")
                {
                    l.mostrarInterfazCarro(camisetas);
                }
                else if (producto == "Pantalon Gucci")
                {
                    l.mostrarInterfazCarro(pantalones);
                }
                else if(producto == "Zapatilla Gucci")
                {
                    l.mostrarInterfazCarro(zapatillas);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void BtnCerrarVentanaCarro_Click(object sender, EventArgs e)
        {
            BtnCerrarVentanaCarro.Visible = false; //si se cierra la ventana de carrito o pedidos, se desactiva el botón

            if (panelReemplazable.Controls.Count > 0) //si hay un formulario cargado en el panel 1, se borra para cargar el inicio
            {
                panelReemplazable2.Controls.RemoveAt(0);
                panelReemplazable2.Visible = false; //se desactiva el panel 2 para mostrar el panel 1
            }

            BtnInicio.Select();
            configurarTextoBusqueda();

            abrirFormularioHijo(new InicioForm()); //se abre el formulario de inicio por defecto
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            configurarBotonPanel2(); //Se configuran los botones del panel 2 

            pe = new PedidoForm();

            pe.agregarPedidos();

            abrirFormularioHijo2(pe); //se pasa como parámetro la instancia del formulario a cargar

            pe.Show(); //se muestra 
        }

        private void configurarBotonPanel2() //se configuran los botones del panel 2, para los formularios carrito y pedidos
        {
            BtnAñadirAlCarro.Visible = false;
            BtnComprar1.Visible = false;

            BtnCerrarVentanaCarro.Visible = true;
            BtnCerrarVentanaCarro.Location = new Point(700, 147);
            panelReemplazable2.Visible = true;

        }

        private void TextoBusqueda_Click(object sender, EventArgs e)
        {

            if (TextoBusqueda.Text == "Buscar producto/s, modelo/s...")
            {
                TextoBusqueda.Clear(); //se borra el texto al hacer click en el textbox
            }

            //se establece una nueva tipografía, tamaño y color del texto

            TextoBusqueda.Font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel);
            TextoBusqueda.ForeColor = Color.Black;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = TextoBusqueda.Text.ToLower(); //se convierte el texto buscado en minúscula

            l.filtrarProducto(buscado); //se pasa el texto convertido y se filtran los productos que coincidan con el texto ingresado

            abrirFormularioHijo(l); //Se abre el formulario de la lista con los productos filtrados
            l.Show(); //se muestra          
        }

        private void TextoBusqueda_TextChanged(object sender, EventArgs e)
        {
            //si se borra todo el texto entonces vuelve a cargar el formulario en el que estaba anteriormente

            if (TextoBusqueda.Text == string.Empty) 
            {
                if(formularioActual == "Inicio")
                {
                    abrirFormularioHijo(new InicioForm());
                    BtnInicio.Select();
                }
                else if(formularioActual == "Camiseta")
                {
                    abrirFormularioHijo(c);
                    BtnCamiseta.Select();
                }
                else if(formularioActual == "Pantalon")
                {
                    abrirFormularioHijo(p);
                    BtnPantalones.Select();
                }
                else if(formularioActual == "Zapatilla")
                {
                    abrirFormularioHijo(za);
                    BtnZapatillas.Select();
                }
            }
        }

        private void TimerFecha_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString(); //se establece la cadena de fecha larga en el label  
        }

        //métodos que se encargan de agregar de forma manual cada producto a sus respectivos arrays
        private void cargarCamisetas() 
        {
            Vestimenta r = new Remera("Remera Gucci", "Jersey de algodón negro \n \n Iridiscente Gucci vintage logo print \n \n Cuello redondo \n \n Ajuste de gran tamaño \n \n 100% algodón \n \n Hecho en Italia", "Logo Gucci Tradicional", 3500, 250, idProducto);

            r.Talles.Add("M");
            r.Talles.Add("XL");
            r.Talles.Add("XXL");    //se setean los talles y colores disponibles para ese producto

            r.Colores.Add("Negro");
            r.Colores.Add("Blanco");

            idProducto++;   //cada producto tendrá su identificador único

            camisetas.Add(r); //se agrega la instancia al array, con información del producto, modelo, descripción, talles, colores etc.

            r = new Remera("Remera Gucci", "Jersey de algodón blanco roto \n \n Impresión de la boca \n \n Estampado gucci \n \n Ajuste de gran tamaño \n \n 100% algodón \n \n Hecho en Italia ", "Logo Gucci con Boca", 2300, 100, idProducto);

            r.Talles.Add("XL");
            r.Talles.Add("XXL");

            r.Colores.Add("Blanco");

            idProducto++;

            camisetas.Add(r);

            r = new Remera("Remera Gucci", "Jersey de algodón lavado negro \n \n Logo vintage de gucci \n \n Aplique de leopardo bordado \n \n Ajuste de gran tamaño \n \n 100% algodón \n \n Hecho en Italia ", "Logo Gucci con Leopardo", 3200, 75, idProducto);

            r.Talles.Add("XL");

            r.Colores.Add("Blanco");
            r.Colores.Add("Negro");

            idProducto++;

            camisetas.Add(r);
        }
        private void cargarPantalones()
        {
            Vestimenta pa = new Pantalon("Pantalon Gucci", "Azul y verde a cuadros de lana de abejas \n \n Cintura elástica con cordón \n \n Bolsillos traseros con botón a presión \n \n La altura del tobillo \n \n 15' apertura de la pierna \n \n 100% lana \n \n Hecho en Italia", "Cuadriculado con Abejas", 1500, 135, idProducto);

            pa.Talles.Add("XL");

            pa.Colores.Add("Azul");
            pa.Colores.Add("Negro");

            idProducto++;

            pantalones.Add(pa);

            pa = new Pantalon("Pantalon Gucci", "Mohair de lana de pata de gallo blanco, negro y rojo \n \n Franja verde y roja por la pierna \n \n Cintura elástica con cordón \n \n Bolsillos frontales \n \n Bolsillos traseros con solapa \n \n 88% lana y 12% mohair \n \n Hecho en Italia", "Pata de Gallo", 1350, 225, idProducto);

            pa.Talles.Add("M");
            pa.Talles.Add("XL");

            pa.Colores.Add("Azul");
            pa.Colores.Add("Gris");

            idProducto++;

            pantalones.Add(pa);

            pa = new Pantalon("Pantalon Gucci", "Gabardina biestiramiento gris \n \n Raya jacquard gucci \n \n Bolsillos delanteros inclinados \n \n Bolsillos traseros con solapa \n \n Detalle de cremallera en la abertura de la pierna \n \n Parche en el interior de la pierna \n \n 94% algodón y 6% elastano \n \n Hecho en Italia", "Rayas al Costado", 2225, 145, idProducto);

            pa.Talles.Add("XL");
            pa.Talles.Add("XXL");

            pa.Colores.Add("Gris");

            idProducto++;

            pantalones.Add(pa);

        }
        private void cargarZapatillas()
        {

            Zapatilla z = new Zapatilla("Zapatilla Gucci", "Cuero blanco con web verde y rojo \n \n Parche Boston Terrier bordado Bosco \n \n Parche bordado de Boston terrier Orso \n \n Detalle de cuero rojo metálico en la parte posterior de un zapato y detalle de cuero verde metálico en la parte posterior del otro zapato \n \n Suela de goma \n \n Hecho en Italia", "Tres Rayas con Perro", 5700, 227, idProducto);

            z.TallaZapatilla.Add(36);
            z.TallaZapatilla.Add(37);
            z.TallaZapatilla.Add(39);

            z.Colores.Add("Blanco");

            zapatillas.Add(z);

            idProducto++;

            z = new Zapatilla("Zapatilla Gucci", "Cuero blanco con web verde y rojo \n \n Detalle de serpiente ayers rojo en la parte posterior de un zapato y detalle de serpiente ayers verde en la parte posterior del otro zapato \n \n Apliques de tigre bordados \n \n Detalle de cuero rojo metálico en la parte posterior de un zapato y detalle de cuero verde metálico en la parte posterior del otro zapato \n \n Suela de goma \n \n Hecho en Italia", "Tres Rayas con Tigre", 5500, 200, idProducto);

            z.TallaZapatilla.Add(36);
            z.TallaZapatilla.Add(37);

            z.Colores.Add("Blanco");
            z.Colores.Add("Negro");

            zapatillas.Add(z);

            idProducto++;

            z = new Zapatilla("Zapatilla Gucci", "Cuero negro con tela azul y roja y abeja bordada con hilo dorado \n \n Detalle de serpiente ayers rojo en la parte posterior de un zapato y detalle de serpiente ayers azul en la parte posterior del otro zapato \n \n Suela de goma \n \n Hecho en Italia", "Tres Rayas con Abeja", 5860, 185, idProducto);

            z.TallaZapatilla.Add(38);
            z.TallaZapatilla.Add(39);

            z.Colores.Add("Negro");

            zapatillas.Add(z);

            idProducto++;

        }

        private void TextoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si se presiona enter mientras se mantiene seleccionado el textbox entonces se busca
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && TextoBusqueda.Focused == true)
            {
                BtnBuscar_Click(1, null);
            }
        }

        private void configurarTextoBusqueda()
        {
            TextoBusqueda.Text = "Buscar producto/s, modelo/s...";
            TextoBusqueda.ForeColor = Color.LightGray;
            TextoBusqueda.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Italic, GraphicsUnit.Pixel);
        }
    }
}