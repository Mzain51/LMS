using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Manage_Book : Form
    {
        public Manage_Book()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LMSEntities1 context = new LMSEntities1();
            Book book = new Book();
            book.ISBN = bookisbntxt.Text;
            book.Title = bookTtxt.Text;
            book.Category = catecombo.SelectedText;
            book.Quantity = Convert.ToInt32(quantitytxt.Text);
            context.Books.Add(book);
            context.SaveChanges();
        }


        private void Button2_Click(object sender, EventArgs e)
        {

        }
        private void Button3_Click(object sender, EventArgs e)
        {
           



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            LMSEntities1 context = new LMSEntities1();
            var book = context.Books.Where(b => b.ISBN == risbntxt.Text).FirstOrDefault();
           var bookqty = book.Quantity - Convert.ToInt32(removetxt.Text);
           book.Quantity = bookqty;
            context.SaveChanges();
            MessageBox.Show($"Book {removetxt.Text }Removed");

        }
        private void button7_Click(object sender, EventArgs e)
        {
            LMSEntities1 context = new LMSEntities1();   

            var book = context.Books.Where(b => b.ISBN ==risbntxt.Text).FirstOrDefault();
            rtitletxt.Text = book.Title;
            rcatetxt.Text = book.Category;
            rqtytxt.Text = Convert.ToString(book.Quantity);
            rtitletxt.ReadOnly = true;
            rcatetxt.ReadOnly = true;
            rqtytxt.ReadOnly = true;


        }

        private void rcattxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


