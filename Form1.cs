using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            funcControl1.Func = Math.Sin;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            funcControl1.Func = Math.Cos;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            funcControl1.Func = Math.Tan;
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            
            funcControl1.Func = (x) => a * x * x + b * x + c;
        }
    }
}
