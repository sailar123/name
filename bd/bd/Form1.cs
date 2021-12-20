using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Form1 : Form
    {
        public static string bdd, id, peremen, znach, znach2;
        public DateTime znachdate;

        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + bdd.ToString() + ".mdb;");
            myConnection.Open();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }



        private void button1_Click(object sender, EventArgs e) //отобразить
        {
            string com = null;

            if (bdd == "workers")
            {
                com = "id, w_name, w_position, w_salary";
            }
            else
            {
                com = "id, w_nameTool, w_price, w_purchaseDate";
            }

            OleDbCommand command = new OleDbCommand("SELECT " + com.ToString() + " FROM " + bdd.ToString() + " ORDER BY id", myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
            }
            reader.Close();
        }



        private void button2_Click(object sender, EventArgs e) //именить
        {
            id = null;
            peremen = null;
            znach = null;

            Form3 f3 = new Form3();
            f3.ShowDialog();
            if (bdd == "workers")
            {
                string s1 = "'", s2 = "'";
                znach = s1 + znach + s2;
            }

           

            string vopros = "UPDATE " + bdd.ToString() + " SET " + peremen.ToString() + " = " + znach.ToString() + " WHERE id = " + id;
            OleDbCommand command = new OleDbCommand(vopros, myConnection);
            command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e) //добавить
        {
            string com = null;
            peremen = null;
            znach = null;
            znach2 = null;
            if (bdd == "workers")
            {
                string s1 = "'", s2 = "'";
                com = "w_name, w_position, w_salary";
                Form4 f4 = new Form4();
                f4.ShowDialog();
                znach = s1 + znach + s2;
            }
            else
            {
                com = "w_nameTool, w_price, w_purchaseDate";
                Form5 f5 = new Form5();
                f5.ShowDialog();

            }
            
            

            string qvery = "INSERT INTO " + bdd.ToString() + " (" + com.ToString() + ") VALUES ('" + peremen.ToString() + "', " + znach.ToString() + ", " + znach2.ToString() + ")";
            OleDbCommand command = new OleDbCommand(qvery, myConnection);
            command.ExecuteNonQuery();
        }

       

        private void button5_Click(object sender, EventArgs e) //удаление
        {
            znach = null;
            Form6 f6 = new Form6();
            f6.ShowDialog();

            string qvery = "DELETE FROM " + bdd.ToString() + " WHERE id = " + znach;
            OleDbCommand command = new OleDbCommand(qvery, myConnection);
            command.ExecuteNonQuery();
        }
    }
}
