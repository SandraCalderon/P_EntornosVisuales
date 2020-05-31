using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Dim valor1 As integer 
            Dim valor2 As integer
            Dim Suma As integer

                valor1=Val(txtValor1.text)
                valor2=Val(txtValor2.text)

                suma=valor1 + valor2

                txtSuma.Text= Suma
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            End
        }
    }
}
