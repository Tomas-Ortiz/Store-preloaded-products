using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public abstract class Vestimenta
    {
        //atributos propios de cada vestimenta
        protected List<string> talles = new List<string>(); //listas parametrizadas
        protected List<string> colores = new List<string>();

        protected string modelo, producto, descripcion, talle, color;
        protected float precio;
        protected int stock, unidades, totalVendido;

        //get y set de los atributos
        public List<string> Colores { get => colores; set => colores = value; }
        public List<string> Talles { get => talles; set => talles = value; }

        //contador del total de productos registrados
        public static int totalProductos = 0;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Talle { get => talle; set => talle = value; }
        public string Color { get => color; set => color = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public int TotalVendido { get => totalVendido; set => totalVendido = value; }

        public string Producto()
        {
            return producto;
        }

        public string Modelo()
        {
            return modelo;
        }

        public float Precio()
        {
            return precio;
        }


        public Vestimenta(string producto, string descripcion, string modelo, float precio, int stock, int idproducto)
        {
            this.producto = producto;
            this.modelo = modelo;
            this.Descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;

            totalProductos++; //incrementa el total de productos registrados
        }

        public Vestimenta()
        {

        }

    }

    //clases hijas de la clase padre Vestimenta

    public class Remera : Vestimenta
    {
        //constructor que se encarga de agregar una camiseta

        //se recibe como parámetro la información del producto y se invoca el constructor de la clase padre
        public Remera(string producto, string descripcion, string modelo, float precio, int stock, int idproducto)
           : base(producto, descripcion, modelo, precio, stock, idproducto)
        {

        }
        public Remera()
        {

        }

        public void agregarCamisetasLista(ArrayList camisetas, ListView ListaCamisetas)
        {
            for (int i = 0; i < contenedorPrincipal.camisetas.Count; i++) //se agregan los productos a la ListView de camisetas
            {
                ListViewItem lista = new ListViewItem(((Remera)contenedorPrincipal.camisetas[i]).Producto());
                lista.SubItems.Add(((Remera)contenedorPrincipal.camisetas[i]).Modelo());
                lista.SubItems.Add(Convert.ToString(((Remera)contenedorPrincipal.camisetas[i]).Precio()));

                ListaCamisetas.Items.Add(lista); //se lo agrega a la lista
            }
        }

        public void ordenarListaCamiseta(string item, ArrayList camisetas, ListView ListaCamisetas)
        {
            switch (item)
            {
                case "        Producto":

                    //se ordenan los productos de forma alfabética según el producto
                    var ordenadoPorProducto = camisetas.Cast<Remera>().OrderBy(r => r.Producto());

                    foreach (Remera r in ordenadoPorProducto)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaCamisetas.Items.Add(l); //se agrega a la lsita los elementos ya ordenados
                    }

                    break;

                case "               A-Z":

                    //se ordenan los productos de forma ascendente según el modelo
                    var ordenadoPorAZ = camisetas.Cast<Remera>().OrderBy(r => r.Modelo());

                    foreach (Remera r in ordenadoPorAZ)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaCamisetas.Items.Add(l);
                    }

                    break;

                case "               Z-A":
                    var ordenadoPorZA = camisetas.Cast<Remera>().OrderByDescending(r => r.Modelo());

                    foreach (Remera r in ordenadoPorZA)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaCamisetas.Items.Add(l);
                    }

                    break;


                case "      Precio Menor":

                    //se ordenan los productos de forma ascendente según el precio
                    var ordenadoPorPrecioMenor = camisetas.Cast<Remera>().OrderBy(r => r.Precio());

                    foreach (Remera r in ordenadoPorPrecioMenor)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaCamisetas.Items.Add(l);
                    }

                    break;

                case "      Precio Mayor":

                    //se ordenan los productos de forma descendente según el modelo

                    var ordenadoPorPrecioMayor = camisetas.Cast<Remera>().OrderByDescending(r => r.Precio());

                    foreach (Remera r in ordenadoPorPrecioMayor)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaCamisetas.Items.Add(l);
                    }
                    break;

                case "       Más vendido":

                    //se ordenan los productos de forma descendente según los más vendidos

                    var ordenadoPorMasVendido = contenedorPrincipal.camisetas.Cast<Remera>().OrderByDescending(r => r.TotalVendido);

                    foreach (Remera r in ordenadoPorMasVendido)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaCamisetas.Items.Add(l);
                    }

                    break;
            }

        }
    }

    public class Pantalon : Vestimenta
    {

        //constructor que se encarga de agregar un pantalon
        public Pantalon(string producto, string descripcion, string modelo, float precio, int stock, int idproducto)
                   : base(producto, descripcion, modelo, precio, stock, idproducto)
        {

        }

        public Pantalon()
        {

        }

        public void agregarPantalonesLista(ArrayList pantalones, ListView ListaPantalones)
        {
            for (int i = 0; i < contenedorPrincipal.pantalones.Count; i++)
            {
                ListViewItem lista = new ListViewItem(((Pantalon)contenedorPrincipal.pantalones[i]).Producto());
                lista.SubItems.Add(((Pantalon)contenedorPrincipal.pantalones[i]).Modelo());
                lista.SubItems.Add(Convert.ToString(((Pantalon)contenedorPrincipal.pantalones[i]).Precio()));

                ListaPantalones.Items.Add(lista);
            }
        }

        public void ordenarListaPantalones(string item, ArrayList pantalones, ListView ListaPantalones)
        {
            switch (item)
            {
                case "        Producto":

                    var ordenadoPorProducto = pantalones.Cast<Pantalon>().OrderBy(r => r.Producto());

                    foreach (Pantalon r in ordenadoPorProducto)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaPantalones.Items.Add(l); 
                    }

                    break;

                case "               A-Z":

                    var ordenadoPorAZ = pantalones.Cast<Pantalon>().OrderBy(r => r.Modelo());

                    foreach (Pantalon r in ordenadoPorAZ)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaPantalones.Items.Add(l);
                    }

                    break;

                case "               Z-A":
                    var ordenadoPorZA = pantalones.Cast<Pantalon>().OrderByDescending(r => r.Modelo());

                    foreach (Pantalon r in ordenadoPorZA)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaPantalones.Items.Add(l);
                    }

                    break;


                case "      Precio Menor":

                    var ordenadoPorPrecioMenor = pantalones.Cast<Pantalon>().OrderBy(r => r.Precio());

                    foreach (Pantalon r in ordenadoPorPrecioMenor)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaPantalones.Items.Add(l);
                    }

                    break;

                case "      Precio Mayor":

                    var ordenadoPorPrecioMayor = pantalones.Cast<Pantalon>().OrderByDescending(r => r.Precio());

                    foreach (Pantalon r in ordenadoPorPrecioMayor)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaPantalones.Items.Add(l);
                    }
                    break;

                case "       Más vendido":

                    var ordenadoPorMasVendido = contenedorPrincipal.pantalones.Cast<Pantalon>().OrderByDescending(r => r.TotalVendido);

                    foreach (Pantalon r in ordenadoPorMasVendido)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaPantalones.Items.Add(l);
                    }

                    break;
            }
        }

    }

    public class Zapatilla : Vestimenta
    {
        //atributo propio de Zapatilla
        protected List<int> tallaZapatilla = new List<int>();

        //get y set de la lista
        public List<int> TallaZapatilla
        {
            get
            {
                return tallaZapatilla;
            }

            set
            {
                tallaZapatilla = value;
            }
        }

        public Zapatilla(string producto, string descripcion, string modelo, float precio, int stock, int idproducto)
           : base(producto, descripcion, modelo, precio, stock, idproducto)
        {

        }

        public Zapatilla()
        {

        }


        public void agregarZapatillasLista(ArrayList zapatillas, ListView ListaZapatillas)
        {
            for (int i = 0; i < contenedorPrincipal.zapatillas.Count; i++)
            {
                ListViewItem lista = new ListViewItem(((Zapatilla)contenedorPrincipal.zapatillas[i]).Producto());
                lista.SubItems.Add(((Zapatilla)contenedorPrincipal.zapatillas[i]).Modelo());
                lista.SubItems.Add(Convert.ToString(((Zapatilla)contenedorPrincipal.zapatillas[i]).Precio()));

                ListaZapatillas.Items.Add(lista);
            }
        }

        public void ordenarListaZapatillas(string item, ArrayList zapatillas, ListView ListaZapatillas)
        {
            switch (item)
            {
                case "        Producto":

                    var ordenadoPorProducto = zapatillas.Cast<Zapatilla>().OrderBy(r => r.Producto());

                    foreach (Zapatilla r in ordenadoPorProducto)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaZapatillas.Items.Add(l);
                    }

                    break;

                case "               A-Z":

                    var ordenadoPorAZ = zapatillas.Cast<Zapatilla>().OrderBy(r => r.Modelo());

                    foreach (Zapatilla r in ordenadoPorAZ)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaZapatillas.Items.Add(l);
                    }

                    break;

                case "               Z-A":

                    var ordenadoPorZA = zapatillas.Cast<Zapatilla>().OrderByDescending(r => r.Modelo());

                    foreach (Zapatilla r in ordenadoPorZA)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaZapatillas.Items.Add(l);
                    }

                    break;


                case "      Precio Menor":

                    var ordenadoPorPrecioMenor = zapatillas.Cast<Zapatilla>().OrderBy(r => r.Precio());

                    foreach (Zapatilla r in ordenadoPorPrecioMenor)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaZapatillas.Items.Add(l);
                    }

                    break;

                case "      Precio Mayor":

                    var ordenadoPorPrecioMayor = zapatillas.Cast<Zapatilla>().OrderByDescending(r => r.Precio());

                    foreach (Zapatilla r in ordenadoPorPrecioMayor)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaZapatillas.Items.Add(l);
                    }

                    break;

                case "       Más vendido":

                    var ordenadoPorMasVendido = contenedorPrincipal.zapatillas.Cast<Zapatilla>().OrderByDescending(r => r.TotalVendido);

                    foreach (Zapatilla r in ordenadoPorMasVendido)
                    {
                        ListViewItem l = new ListViewItem(r.Producto());
                        l.SubItems.Add(r.Modelo());
                        l.SubItems.Add(Convert.ToString(r.Precio()));

                        ListaZapatillas.Items.Add(l);
                    }

                    break;
            }
        }

    }
}


