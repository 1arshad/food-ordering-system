using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace food_ordering_system
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MBA12\SQLEXPRESS01;Initial Catalog=Food;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into signup values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();


            con.Close();
            if (i > 0)
            {
                MessageBox.Show("Data inserted successfully!");
            }
            else
            {
                MessageBox.Show("There is some problem");
            }
        }
    }
}
