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
    public partial class frmLeerDatos : Form
    {
        StreamReader leer;
        static String fichero = "Usuarios.txt";
        public frmLeerDatos()
        {
            InitializeComponent();
        }

        private void frmLeerDatos_Shown(object sender, EventArgs e)
        {
            leer = new StreamReader(fichero);
            txbDatos.Text = leer.ReadToEnd();
            leer.Close();
        }
    }
}
