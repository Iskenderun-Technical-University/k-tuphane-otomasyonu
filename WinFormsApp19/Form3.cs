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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp19
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string gmail = textBox1.Text;
            string sifre = textBox2.Text;

            bool dogruluk = kontrol(gmail, sifre);

            if (dogruluk)
            {
                MessageBox.Show("giriş yapıldı");
                Form form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Gmail şifreniz yanlış veya e-posta adresi bulunamadı");
            }

         static bool kontrol(string gmail, string sifre)
            {
                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
                cnn.Open();
                string query = $"select count(*) FROM kullanici WHERE gmail = '{gmail}' AND sifre = '{sifre}'";


                using (SqlCommand cmd2 = new SqlCommand(query, cnn))
                {
                    

                    int count = (int)cmd2.ExecuteScalar();
                    
                    return count > 0;
                }
            }
               



            }
               

                

            }



        }
    

