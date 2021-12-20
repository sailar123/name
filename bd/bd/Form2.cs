using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Form2 : Form
    {
        public string bd = "1";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd = "workers";
            Form1 f = new Form1();
            Form1.bdd = bd;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bd = "tools";
            Form1 f = new Form1();
            Form1.bdd = bd;
            f.Show();  
        }
    }
}
