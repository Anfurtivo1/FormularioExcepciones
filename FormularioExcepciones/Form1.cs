using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioExcepciones
{
    
    public partial class Form1 : Form
    {
        static String fichero = "Usuarios.txt";
        StreamReader leer;
        StreamWriter escribir;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            String texto;
            texto=txtNombre.Text.ToString();
            texto=texto.Trim();

            if (texto.Equals(""))
            {
                epNombre.SetError(txtNombre,"Tiene que estar relleno");
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            String texto;
            texto = txtApellido.Text.ToString();
            texto = texto.Trim();

            if (texto.Equals(""))
            {
                epNombre.SetError(txtApellido, "Tiene que estar relleno");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            String texto;
            texto = txtEmail.Text.ToString();
            texto = texto.Trim();

            if (texto.Equals(""))
            {
                epNombre.SetError(txtEmail, "Tiene que estar relleno");
            }
        }

        private void txmMovil_TextChanged(object sender, EventArgs e)
        {
            if (!txmMovil.MaskFull)
            {
                epMovil.SetError(txmMovil, "Tiene que estar relleno");
            }
        }

        private void txmMatricula_TextChanged(object sender, EventArgs e)
        {
            if (!txmMatricula.MaskFull)
            {
                epMatricula.SetError(txmMatricula, "Tiene que estar relleno");
            }
        }

        private void txmCuenta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!txmCuenta.MaskFull)
            {
                epMatricula.SetError(txmCuenta, "Tiene que estar relleno");
            }
        }

        private void txmNIF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!txmNIF.MaskFull && !comprobarNIF(txmNIF.Text.ToString()))
            {
                epMatricula.SetError(txmNIF, "Tiene que estar relleno");
            }
        }

        public static bool comprobarNIF(String NIF)
        {
            string[] letrasArray = new string[] { "T", "R", "W", "A", "G", "M", "Y","F","P","D","X","B","N","J","Z","S","Q","V","H","L","C","K","E" };
            String aux;//Primera substring que tendrá los numeros
            int aux2;//Para convertir la primera substring en int para calcular la letra
            String aux3;//Tercer substring que tendrá la letra
            String aux4;//Substring que servirá para comprobar si esta vacia el string NIF
            aux = NIF.Substring(0,NIF.Length-2);
            aux3 = NIF.Substring(NIF.Length-1);
            aux4 = NIF;
            aux4 = aux4.Trim();
            try
            {
                if (aux4.Equals("-"))
                {
                    throw new ErrorNIFVacio("El NIF no puede estar vacio o con formato erroneo");
                }
                aux2 = Int32.Parse(aux);
                aux2 = aux2 % 23;

                if (letrasArray[aux2].Equals(aux3))
                {
                    MessageBox.Show("El NIF es correcto", "Mensaje de informacion");
                    return true;
                }
                else
                {
                    throw new ErrorNIFVacio("El NIF no puede estar vacio o con formato erroneo");
                }
            }
            catch (ErrorNIFVacio e)
            {
                MessageBox.Show(e.Message, "Tienes que rellenar el NIF ademas de los demas campos");
                return false;
            }

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String texto1;
            String texto2;
            String texto3;
            String texto4;
            String texto5;
            String texto6;
            String texto7;
            String lectura="Texto";

            texto2 = txmNIF.Text.ToString();
            texto2 = texto2.Trim();

                texto1 = txtNombre.Text.ToString();
                texto1 = texto1.Trim();

                texto3 = txmMovil.Text.ToString();
                texto3 = texto3.Trim();

                texto4 = txmMatricula.Text.ToString();
                texto4 = texto4.Trim();

                texto5 = txtEmail.Text.ToString();
                texto5 = texto5.Trim();

                texto6 = txmCuenta.Text.ToString();
                texto6 = texto6.Trim();

                texto7 = txtApellido.Text.ToString();
                texto7 = texto7.Trim();

                comprobarNIF(txmNIF.Text.ToString());
                if (!texto1.Equals("") && !texto2.Equals("") && !texto3.Equals("") && !texto4.Equals("") && !texto5.Equals("") && !texto6.Equals("") && !texto7.Equals(""))
                {
                epNombre.Clear();
                epNIF.Clear();
                epMovil.Clear();
                epMatricula.Clear();
                epEmail.Clear();
                epCuenta.Clear();
                epApellidos.Clear();

                escribir = new StreamWriter(fichero);
                

                escribir.WriteLine("************USUARIOS************");
                escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("Nombre:");
                escribir.WriteLine(texto1);
                //escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("Apellido:");
                escribir.WriteLine(texto7);
                //escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("Telefono:");
                escribir.WriteLine(texto3);
                //escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("Matricula:");
                escribir.WriteLine(texto4);
                //escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("Email:");
                escribir.WriteLine(texto5);
                //escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("Cuenta Bancaria:");
                escribir.WriteLine(texto6);
                //escribir.WriteLine(Environment.NewLine);
                escribir.WriteLine("NIF:");
                escribir.WriteLine(texto2);
                escribir.Close();

            }
        }
    }
}
