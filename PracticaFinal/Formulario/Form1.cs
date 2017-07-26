using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        Thread Hilo;

        public Form1()
        {
            InitializeComponent();

            // Inicializo combo box
            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Azul");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hilo = new Thread(CambiarColorFondo);

            Hilo.Start();

            //Hilo.Abort();
            

        }

        private void CambiarColorFondo()
        {
            if (this.cmbColores.Text == "Rojo")
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (this.cmbColores.Text == "Azul")
            {
                this.BackColor = System.Drawing.Color.Blue;
            }

        }



    }
}
