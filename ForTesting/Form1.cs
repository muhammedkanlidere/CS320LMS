using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForTesting
{
    public partial class Form1 : Form
    {
        LMS lms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lms = new LMS();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookBindingSource.DataSource = lms.Book.ToList();

        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentControl stdForm = new StudentControl();      
            stdForm.Show();
           
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookControl bookForm = new BookControl();
            bookForm.Show();

        }

        private void boorowControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowControl formBorrow = new BorrowControl();
            formBorrow.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

         try
            {

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView1.DataSource = bookBindingSource;
                }
                else
                {

                    

                    var query = from b in lms.Book
                                where b.name.Contains(txtSearch.Text) || b.category.Contains(txtSearch.Text) || b.author.Contains(txtSearch.Text)
                                select new
                                {
                                    Name = b.name,
                                    Author = b.author,
                                    Category = b.category,
                                    RecordDate = b.recordDate,
                                    shelf = b.shelf,
                                    ActiveStock = b.activeStock,
                                };

                    dataGridView1.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RFIDController rf = new RFIDController();
            rf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = lms.Book.ToList();
        }
    }
}
