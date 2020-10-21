using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioExcepciones
{
    public partial class Form1 : Form
    {
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
            String aux;
            int aux2;
            String aux3;
            aux = NIF.Substring(0,NIF.Length-2);
            aux3 = NIF.Substring(NIF.Length-1);
            aux2 = Int32.Parse(aux);

            aux2 = aux2 % 23;

            if (letrasArray[aux2].Equals(aux3))
            {
                MessageBox.Show("Mensaje","El NIF es correcto");
                return true;
            }
            else
            {
                MessageBox.Show("Mensaje", "El NIF no es correcto");
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

            texto1 = txtNombre.Text.ToString();
            texto1 = texto1.Trim();

            texto2 = txmNIF.Text.ToString();
            texto2 = texto2.Trim();

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

            if (!texto1.Equals(""))
            {
                epNombre.Clear();
            }

            if (texto2.Equals(""))
            {
                epNIF.Clear();
            }

            if (texto3.Equals(""))
            {
                epMovil.Clear();
            }

            if (texto4.Equals(""))
            {
                epMatricula.Clear();
            }

            if (texto5.Equals(""))
            {
                epEmail.Clear();
            }

            if (texto6.Equals(""))
            {
                epCuenta.Clear();
            }

            if (!texto7.Equals(""))
            {
                epApellidos.Clear();
            }

            
        }
    }
}
