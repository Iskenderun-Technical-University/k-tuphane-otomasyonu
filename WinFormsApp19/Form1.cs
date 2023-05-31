

using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }







        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into uusertab values (@Id,@Name,@Author,@Sayfa)", cnn);


            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Author", textBox4.Text);
            cmd.Parameters.AddWithValue("@Sayfa", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("create islemi yapildi");
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Update uusertab set Name=@Name,Author=@Author,Sayfa=@Sayfa where Id=@Id", cnn);

            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Author", textBox4.Text);
            cmd.Parameters.AddWithValue("@Sayfa", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("update islemi yapildi");
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("delete uusertab where Id=@Id", cnn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("delete islemi yapildi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from uusertab order by Id", cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //s
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}