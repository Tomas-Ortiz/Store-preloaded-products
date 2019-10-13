using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    class ControlExcepcion
    {
        //banderas utilizadas para futuras validaciones
        public static bool vacio, errorFormato, errorCvc;

        public ControlExcepcion()
        {

        }

        //método que se encarga de verificar la validación de cada campo del formulario de compra
        public static void detectarCampoError(TextBox nombre, TextBox apellidos, TextBox pais, TextBox localidad, TextBox direccion, string fechaExpiracion, TextBox nroTarjeta, TextBox cvc, DateTimePicker fecha, ErrorProvider mensajeError)
        {
            //se setean los textbox a atributos de tipo string
            string nomb = nombre.Text;
            string apellido = apellidos.Text;
            string nacion = pais.Text;
            string estado = localidad.Text;
            string domicilio = direccion.Text;

            //se reinician las banderas 
            vacio = false;
            errorFormato = false;
            errorCvc = false;

            //si el textbox está vacío la compra no es válida, se setea el tipo de error y muestra mensaje del error
            //si el textbox no está vacío pero contiene algún caracter no válido se setea el tipo de error y se produce una excepción propia
            //en la excepción propia se pasa como argumento el textbox y el elemento ErrorProvider
            //sino no se muestra ningún error y la compra es valida
                if (nombre.Text == string.Empty)
                {
                    CompraForm.compraValida = false;

                    vacio = true;

                    mostrarMensajeError(nombre, mensajeError);
                
                }

                else if (nombre.Text != string.Empty && retornarValidez(nomb) == false)
                {

                    errorFormato = true;

                    throw new ExcepcionPropia(nombre, mensajeError);
                }
                else
                {
                    mensajeError.SetError(nombre, "");
                }

            if (apellidos.Text == string.Empty)
                {
                    CompraForm.compraValida = false;
                    vacio = true;

                    mostrarMensajeError(apellidos, mensajeError);
            }

            else if (apellidos.Text != string.Empty && retornarValidez(apellido) == false)
                {
                    errorFormato = true;

                    throw new ExcepcionPropia(apellidos, mensajeError);
                }

                else
                {
                    mensajeError.SetError(apellidos, "");
                }


            if (pais.Text == string.Empty)
                {
                    CompraForm.compraValida = false;
                    vacio = true;

                    mostrarMensajeError(pais, mensajeError);
            }

            else if (pais.Text != string.Empty && retornarValidez(nacion) == false)
                {
                    errorFormato = true;

                    throw new ExcepcionPropia(pais, mensajeError);
                }

                else
                {
                    mensajeError.SetError(pais, "");
                }


            if (localidad.Text == string.Empty)
                {
                    CompraForm.compraValida = false;
                    vacio = true;

                    mostrarMensajeError(localidad, mensajeError);
            }

            else if (localidad.Text != string.Empty && retornarValidez(estado) == false)
                {
                    errorFormato = true;

                    throw new ExcepcionPropia(localidad, mensajeError);

                }
                else
                {
                    mensajeError.SetError(localidad, "");
                }


            if (direccion.Text == string.Empty)
                {
                    CompraForm.compraValida = false;
                    vacio = true;

                    mostrarMensajeError(direccion, mensajeError);
                }

            else if (direccion.Text != string.Empty && retornarValidezDireccion(domicilio) == false)
                {
                    errorFormato = true;

                    throw new ExcepcionPropia(direccion, mensajeError);
                }
        
                else
                {
                    mensajeError.SetError(direccion,"");
                }

            try
            {
                if (nroTarjeta.Text == string.Empty)
                {
                    CompraForm.compraValida = false;
                    vacio = true;

                    mostrarMensajeError(nroTarjeta, mensajeError);
                }
                //se intenta convertir a un entero de 64 bits, si devuelve falso entonces se produce la excepción
                else if(!Int64.TryParse(nroTarjeta.Text, out long value))
                {
                    throw new FormatException();
                }
                else
                {
                    mensajeError.SetError(nroTarjeta, "");
                }

            }
            catch(FormatException)
            {
                errorFormato = true;
                mostrarMensajeError(nroTarjeta, mensajeError);

                CompraForm.compraValida = false;
            }

            try
            {
                if (cvc.Text == string.Empty)
                {
                    CompraForm.compraValida = false;
                    vacio = true;

                    mostrarMensajeError(cvc, mensajeError);
                }

                //se intenta convertir a un entero de 32 bits, si devuelve falso entonces se produce la excepción
                else if (!Int32.TryParse(cvc.Text, out int value))
                {
                    throw new FormatException();
                }

                //si el cvc ingresado es menor a 3 o mayor a 4 dígitos se produce la excepción propia
                else if (cvc.Text.Length < 3 || cvc.Text.Length > 4)
                {
                    errorCvc = true;

                    throw new ExcepcionPropia(cvc, mensajeError);
                }

                else
                {
                   mensajeError.SetError(cvc, "");
                }
            }

            catch (FormatException)
            {
                errorFormato = true;

                mostrarMensajeError(cvc, mensajeError);

                CompraForm.compraValida = false;
            }

        }

        //método que retorna la validez de un campo según los carácteres ingresados
        public static bool retornarValidez(string campo) 
        {
            //se utiliza el codigo ascii para validar las cadenas
            bool esValido = true;

            for (int i = 0; i < campo.Length; i++)
            {
                if ((campo[i] >= 33 && campo[i] <= 64) || (campo[i] >= 91 && campo[i] <= 96) || (campo[i] >= 123 && campo[i] <= 126) || (campo[i] >= 155 && campo[i] <= 159) || (campo[i] >= 166 && campo[i] <= 223) || (campo[i] >= 238 && campo[i] <= 255))
                {
                    esValido = false;

                    return esValido;
                }
            }

            return esValido;
        }
        //método que retorna la validez de  la dirección según los carácteres ingresados
        public static bool retornarValidezDireccion(string domicilio)
        {
            bool direccionValida = true;

            for (int i = 0; i < domicilio.Length; i++)
            {
                if ((domicilio[i] >= 33 && domicilio[i] <= 47) || (domicilio[i] >= 58 && domicilio[i] <= 64) || (domicilio[i] >= 91 && domicilio[i] <= 96) || (domicilio[i] >= 123 && domicilio[i] <= 126) || (domicilio[i] >= 155 && domicilio[i] <= 159) || (domicilio[i] >= 166 && domicilio[i] <= 223) || (domicilio[i] >= 238 && domicilio[i] <= 255))
                {
                    direccionValida = false;

                    return direccionValida;
                }
            }

            return direccionValida;
        }

        public static void mostrarMensajeError(TextBox campo, ErrorProvider msjError)
        {
            //se establece el errorProvider con su mensaje en cada textbox que se produzca un error
            if(vacio == true)
            {
                msjError.SetError(campo, "Campo vacío, por favor complételo.");
            }

            if (errorFormato == true)
            {
                msjError.SetError(campo, "Símbolos y/o números no permitidos.");
            }
        }

    }

    class ExcepcionPropia: Exception
    {
        //al producirse una excepción propia, se recibe como parámetro el campo donde ocurrió la excepción y el ErrorProvider
        //se establece el errorProvider con su mensaje en cada textbox que se produzca un error
        public ExcepcionPropia(TextBox campo, ErrorProvider msjError)
        {
            if(ControlExcepcion.errorCvc == true)
            {
                msjError.SetError(campo, "El cvc debe contener entre 3 y 4 dígitos numéricos.");

            }

            else if(ControlExcepcion.errorFormato == true)
            {
                msjError.SetError(campo, "Símbolos y/o números no permitidos.");
            }
        }
    }
}
