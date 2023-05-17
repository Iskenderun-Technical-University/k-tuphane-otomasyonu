using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
                SqlCommand cmd = new SqlCommand("insert into kullanici values (@kullanici,@gmail,@sifre)", cnn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read())
                {
                    MessageBox.Show("d");
                }
                cmd.Parameters.AddWithValue("@kullanici", textBox1.Text);
                cmd.Parameters.AddWithValue("@gmail", textBox2.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox3.Text);

                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            else if(textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("şifre aynı olmalıdır");
            }
            

        }
    }
}
