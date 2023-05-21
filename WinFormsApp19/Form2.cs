using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox2.Text == textBox3.Text)
            {
                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into kullanici values (@gmail,@sifre,@sifre2)", cnn);

                cmd.Parameters.AddWithValue("@gmail", textBox1.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
                cmd.Parameters.AddWithValue("@sifre2", textBox3.Text);

                cmd.ExecuteNonQuery();
                cnn.Close();
 

            }
            else if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("şifre aynı olmalıdır");
            }
            else {
               
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
