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
    public partial class Form3 : Form
    {
        public Form frm;

        public Form3()
        {
            InitializeComponent();
        }
        
        

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.id = textBox1.Text;
            Form1.peremen = textBox2.Text;
            Form1.znach = textBox3.Text;

            this.Close();
        }


    }
}
