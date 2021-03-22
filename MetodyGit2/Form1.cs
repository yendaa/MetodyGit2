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
        DateTime Za100Dni()
        {
            DateTime dt = DateTime.Now;
            DateTime datum100 = dt.AddDays(100);
            return datum100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime datum100 = dt.AddDays(100);
            MessageBox.Show("Za 100 dnů od aktuálního data bude " + datum100.ToString());
        }
    }
}
