using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multilique_dos_numeros
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero1.Text, out int numero1) || !int.TryParse(txtNumero2.Text, out int numero2))
            {
                MessageBox.Show("Por favor, ingresa números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int resultado = MultiplicarSinOperador(numero1, numero2);

            
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }
        private int MultiplicarSinOperador(int a, int b)
        {
            int resultado = 0;
            bool esNegativo = false;

            
            if (a < 0 && b < 0)
            {
                a = -a;
                b = -b;
            }
            else if (a < 0)
            {
                a = -a;
                esNegativo = true;
            }
            else if (b < 0)
            {
                b = -b;
                esNegativo = true;
            }

            
            for (int i = 0; i < b; i++)
            {
                resultado += a;
            }

           
            if (esNegativo)
            {
                resultado = -resultado;
            }

            return resultado;
        }
    }
}
