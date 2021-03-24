using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime Za100Dni(out DateTime datum) //metoda funguje
        {
            datum = DateTime.Now.AddDays(100);
            return datum;
        }

        double Metoda2(double a) //umocní číslo z textbocu na druhou, funguje
        {
            return a * a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime datum100 = Za100Dni(out dt);
            MessageBox.Show("Za 100 dnů od aktuálního data bude " + datum100.ToString());
            double a = double.Parse(textBox1.Text);
            MessageBox.Show("Druhá mocnina čísla z textboxu je: " + Metoda2(a));
        }
    }
}
