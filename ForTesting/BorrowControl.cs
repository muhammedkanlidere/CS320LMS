using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForTesting
{
    public partial class BorrowControl : Form
    {
        LibraryEntities lms;
        public BorrowControl()
        {
             InitializeComponent();
        }

        private void BarrowControl_Load(object sender, EventArgs e)
        {
            panelBorrow.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lms = new LibraryEntities();
            getBorrowList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int convertedTxtRfid = Convert.ToInt32(txtBorrowRfid.Text);

                Book book = lms.Book.FirstOrDefault(o => o.rfid == convertedTxtRfid);
                Student std = lms.Student.FirstOrDefault(o => o.scode == txtBorrowScode.Text);

                if (book.name != null && std.name != null)
                {
                    Borrow brw = new Borrow() { Bookid = book.id, Studentid = std.id, dateOfBorrow = DateTime.Now };
                    lms.Borrow.Add(brw);
                    if (MessageBox.Show("Do you want to  give " + book.name + " named book to " + std.name + " " + std.surname + " named student ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        
                        lms.SaveChanges();
                    }

                    var count = lms.Borrow.Count(o => o.Bookid == brw.Bookid);
                    label7.Text = count.ToString();

                }
                else
                {
                    MessageBox.Show("Rfid and Scode is Not recognized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                getBorrowList();
                panelBorrow.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        public void getBorrowList()
        {
            try
            {
                var query = from b in lms.Borrow
                            join s in lms.Student on b.Studentid equals s.id
                            join book in lms.Book on b.Bookid equals book.id
                            select new
                            {
                                borrowid = b.id,
                                BookName = book.name,
                                bookRfid = book.rfid,
                                studentName = s.name,
                                stodentScode = s.scode,
                                dateofBorrow = b.dateOfBorrow,
                                dateOfReturn = b.dateOfReturn,
                                money = b.Money,

                            };

                dataGridView1.DataSource = query.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panelBorrow.Enabled = true;
            txtBorrowRfid.Focus();
           

        }
     
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    getBorrowList();
                }
                else
                {

                    var query = from b in lms.Borrow
                                join s in lms.Student on b.Studentid equals s.id
                                join book in lms.Book on b.Bookid equals book.id
                                where book.name.Contains(txtSearch.Text)  || s.scode.Contains(txtSearch.Text) || s.name.Contains(txtSearch.Text)
                                select new
                                {
                                    borrowid = b.id,
                                    BookName = book.name,
                                    bookRfid = book.rfid,
                                    studentName = s.name,
                                    stodentScode = s.scode,
                                    dateofBorrow = b.dateOfBorrow,
                                    dateOfReturn = b.dateOfReturn,
                                    money = b.Money,

                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
}
