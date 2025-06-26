using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txbSoloLetras_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbSoloLetras.Text, "^[a-z]*$"))
            {
                MessageBox.Show("Por favor solo letras.");
                txbSoloLetras.Text = string.Empty;
            }

        }

        private void txbSoloNumeros_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbSoloNumeros.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo números.");
                txbSoloNumeros.Text = string.Empty;
            }

        }
    }
}
