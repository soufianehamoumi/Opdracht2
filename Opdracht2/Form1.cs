using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTDieren_Click(object sender, EventArgs e)
        {
            Dier koe = new Koe(850);
            Dier Varken = new Varken(220);
            Dier Slang = new Slang(9);


            if(CBKoe.Checked)
            {
                MessageBox.Show(koe.ToString());
            }
            if (CBSlang.Checked)
            {
                MessageBox.Show(Slang.ToString());
            }
            if (CBVarken.Checked)
            {
                MessageBox.Show(Varken.ToString());
            }


        }
    }
}
