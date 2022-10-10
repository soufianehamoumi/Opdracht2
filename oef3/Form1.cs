using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Euro.Text !="")
            {
                double eu = double.Parse(Euro.Text) * 1.02;
                Dollar.Text = eu.ToString();

            }

            if(Pounds.Text != "")
            {
                double po = double.Parse(Pounds.Text) * 0.88;
                Dollar.Text = po.ToString();
            }

            if (Yen.Text != "")
            {
                double ye = double.Parse(Yen.Text) * 144.50;
                Dollar.Text = ye.ToString();
            }

            if (Rupees.Text != "")
            {
                double ru = double.Parse(Rupees.Text) * 81.50;
                Dollar.Text = ru.ToString();
            }

            if (Franken.Text != "")
            {
                double fr = double.Parse(Franken.Text) * 0.99;
                Dollar.Text = fr.ToString();
            }


            if(Dollar.Text != "")
            {
                USD euro = new USD(double.Parse(Dollar.Text));
                USD dollar = new Euro(double.Parse(Dollar.Text));
                USD pounds = new Pounds(double.Parse(Dollar.Text));
                USD yen = new Yen(double.Parse(Dollar.Text));
                USD rupees = new Rupees(double.Parse(Dollar.Text));
                USD franken = new Franken(double.Parse(Dollar.Text));

                Euro.Text = euro.ToString();
                Dollar.Text = dollar.ToString();
                Pounds.Text = pounds.ToString();
                Yen.Text = yen.ToString();
                Rupees.Text = rupees.ToString();
                Franken.Text = franken.ToString();


            }


        }
    }
}
