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
    public partial class FrmBuclefor : Form
    {
        public FrmBuclefor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Sorted = false;
            this.lstNumeros.Items.Clear();
            Random r = new Random();
            for (int i=0; i<10; i++)
            {
                int num = r.Next(1, 9);
                this.lstNumeros.Items.Add(num);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Sorted = true;

        }
    }
}
