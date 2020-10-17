using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {

        public string month;
        public string year;
        public string day;

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            month = textBox1.Text;
            day = textBox2.Text;
            year = textBox3.Text;

            if(month.Length == 0 && year.Length == 0 && day.Length != 0)
            {
                MessageBox.Show("Please specify month and year");
            }
            else if(year.Length != 0 && month.Length == 0 && day.Length == 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from customerinformation where Year(date) like '" + year + "'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (month.Length != 0 && year.Length == 0 && day.Length == 0)
            {
                MessageBox.Show("Please specify year");
            }
            else if(month.Length != 0 && year.Length != 0 && day.Length != 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from customerinformation where Year(date) like '" + year + "' AND Month(date) like '" + month + "' AND Day(date) like '" + day + "'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if(month.Length != 0 && year.Length != 0 && day.Length == 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from customerinformation where Year(date) like '" + year + "' AND Month(date) like '" + month + "'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (month.Length == 0 && year.Length == 0 && day.Length == 0)
            {
                MessageBox.Show("Please specify month, year & day");
            }
            else if(month.Length == 0 && year.Length != 0 && day.Length != 0)
            {
                MessageBox.Show("Please specify month");
            }
            else if(month.Length != 0 && year.Length == 0 && day.Length != 0)
            {
                MessageBox.Show("Please specify year");
            }
            else
            {
                MessageBox.Show("You did some mistakes!");
            }

        }

        
    }
}
