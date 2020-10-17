using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static String[] Customerdishlist = new String[142];
        public static String[] Customercount = new String[142];
        public static String[] Chefdishlist = new String[142];
        public static String[] Chefcount = new String[142];
        public static String[] Customerprice = new String[142];
        public int Sum1 = 0;
        public int Sum2 = 0;
        public string tablenum;
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Dish", 300);
            listView1.Columns.Add("Number of Times Order", 250);
            listView1.Columns.Add("Total Price of Dish", 250);

            if (Retail.dishlist.Length == 0)
            {

            }
            else 
            {
                for (int count = 0; count < Retail.dishlist.Length; count++)
                {

                    if (Retail.dishlist[count] != null)
                    {
                        ListViewItem listItem = new ListViewItem(Retail.dishlist[count]);
                        listItem.SubItems.Add(Retail.dishcount[count]);
                        listItem.SubItems.Add(Retail.dishprice[count]);
                        listView1.Items.Add(listItem);
                        Sum1 = Sum1 + int.Parse(Retail.dishcount[count]);
                        Sum2 = Sum2 + int.Parse(Retail.dishprice[count]);
                    }
                }
                this.Controls.Add(listView1);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            tablenum = textBox1.Text;

            if(tablenum.Length == 0)
            {
                MessageBox.Show("Firstly enter table number");
            }
            else
            {
                Retail.dishlist.CopyTo(Chefdishlist, 0);
                Retail.dishcount.CopyTo(Chefcount, 0);

                printPreviewDialog2.Document = printDocument2;
                printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprn", 285, 600);
                printPreviewDialog2.ShowDialog();
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            tablenum = textBox1.Text;

            if (tablenum.Length == 0)
            {
                MessageBox.Show("Firstly enter table number");
            }
            else
            {

                Retail.dishlist.CopyTo(Customerdishlist, 0);
                Retail.dishcount.CopyTo(Customercount, 0);
                Retail.dishprice.CopyTo(Customerprice, 0);

                string date = DateTime.UtcNow.ToString("d");
                string sql = "";
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
                cnn.Open();
                sql = "INSERT INTO customerinformation (tablenum,listofitems,totalprice,date) VALUES ('" + tablenum + " ','" + Sum1 + " ','" + Sum2 + "','" + date + "' )";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();

                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprn", 285, 600);
                printPreviewDialog1.ShowDialog();
            }
           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.Capture;
            
            e.Graphics.DrawImage(image, 50, 12, image.Width - 15, image.Height - 15);
            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 175));
            e.Graphics.DrawString("Table Number: " + tablenum, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Dish Name:                               Quantity:                    Price", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, 225));
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, 235));
            int i = 245;
            for (int count = 0; count < Form2.Customerdishlist.Length; count++)
            {

                if (Form2.Customerdishlist[count] != null)
                {
                    e.Graphics.DrawString("" + Form2.Customerdishlist[count], new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, i));
                    e.Graphics.DrawString("                                       " + Form2.Customercount[count] + "                                       " + Form2.Customerprice[count], new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(25, i));
                    i += 20;

                }



            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, i));
            i += 20;
            e.Graphics.DrawString("Total Price                                                                   " + Sum2, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, i));
            i += 50;
            e.Graphics.DrawString("                                    Thank You ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(5, i));
            i += 20;
            e.Graphics.DrawString("                               FOR ORDER & DELIVERY ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(5, i));
            i += 20;
            e.Graphics.DrawString("                                  0310 - 2671747 ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(25, i));
            i += 20;
            e.Graphics.DrawString("                                  0336 - 6860162 ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(25, i));
        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.Capture;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprn", 285, 600);
            e.Graphics.DrawImage(image, 50, 12, image.Width - 15, image.Height - 15);
            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 175));
            e.Graphics.DrawString("Table number: " + tablenum, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Dish Name:                                       Quantity:                                       ", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, 225));
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, 235));
            int i = 245;
            for (int count = 0; count < Form2.Chefdishlist.Length; count++)
            {

                if (Form2.Chefdishlist[count] != null)
                {
                    e.Graphics.DrawString("" + Form2.Chefdishlist[count], new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, i));
                    e.Graphics.DrawString("                                                         " + Form2.Chefcount[count], new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(25, i));
                    i += 20;

                }

            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, i));
            i += 50;
            e.Graphics.DrawString("                                      Thank You ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(5, i));
            i += 20;
            e.Graphics.DrawString("                                  FOR ORDER & DELIVERY ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(5, i));
            i += 20;
            e.Graphics.DrawString("                                   0310 - 2671747 ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(25, i));
            i += 20;
            e.Graphics.DrawString("                                   0336 - 6860162 ", new Font("Arial", 7, FontStyle.Regular), Brushes.Maroon, new Point(25, i));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
