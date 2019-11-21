using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class F0rmFACTORIAL : Form
    {
        public F0rmFACTORIAL()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            long resultado = funciones.EjemplosBucles.factorial(num);
            this.txtFactorial.Text = resultado.ToString();


        }
    }
}
