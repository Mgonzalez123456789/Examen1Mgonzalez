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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
            decimal Precio = Convert.ToDecimal(N2textBox2.Text);
            decimal Cantidad = Convert.ToDecimal(N3textBox3.Text);

            decimal resultado = await FacturaAsyn(Precio, Cantidad);

            MessageBox.Show($"El Total A Pagar es: {resultado}");
        }

        private async Task<decimal> FacturaAsyn(decimal precio,decimal cantidad)
        {
            decimal total = await Task.Run(() =>
            {
                decimal compra = precio * cantidad;
                return compra * 15 / 100;
            });
         return total;
        }
    }
}

