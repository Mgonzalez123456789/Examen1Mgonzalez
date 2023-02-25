using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            string[] Vector1 = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto ", "Septiembre", "Octubre", "Noviembre", "Dicieimbre" };

            for (int i = 0; i < Vector1.Length; i++)
            {
                double deposito = Convert.ToDouble(Numero1textBox1.Text);
                double interes = deposito * 1.5 / 100 * i;
                double total = interes + deposito;
                listBox1.Items.Add(Vector1[i] + "=" + interes);


            }
        }
    }
}
