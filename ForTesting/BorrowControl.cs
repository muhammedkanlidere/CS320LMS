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
        LMS lms;
        public BorrowControl()
        {
             InitializeComponent();
        }

        private void BarrowControl_Load(object sender, EventArgs e)
        {
            panelBorrow.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lms = new LMS();
            getBorrowList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                Book book = lms.Book.FirstOrDefault(o => o.rfid == txtBorrowRfid.Text);
                Student std = lms.Student.FirstOrDefault(o => o.scode == txtBorrowScode.Text);
                if (book.activeStock == null)
                {
                    book.activeStock = book.stock;
                }
                if (book.name != null && std.name != null && book.activeStock > 0)
                {
                    Borrow brw = new Borrow() { Bookid = book.id, Studentid = std.id, dateOfBorrow = DateTime.Now };
                    lms.Borrow.Add(brw);
                   
                    book.activeStock -= 1;
                    if (MessageBox.Show("Do you want to  give " + book.name + " named book to " + std.name + " " + std.surname + " named student ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        
                        lms.SaveChanges();
                    }

                     var count = lms.Borrow.Count(o => o.Bookid == brw.Bookid);
                     label7.Text = count.ToString();

                }
                else
                {
                    MessageBox.Show("Rfid and Scode is Not recognized or There is no active Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int borrowId = Convert.ToInt32(txtBarrowId.Text);
            var borrow = lms.Borrow.FirstOrDefault(t => t.id == borrowId);
            if (borrow.dateOfReturn == null )
            {
                borrow.Money = Convert.ToInt32(txtMoney.Text);
                borrow.dateOfReturn = DateTime.Now;
                var book = lms.Book.FirstOrDefault(o => o.id == borrow.Bookid);
                book.activeStock++;
                lms.SaveChanges();
                MessageBox.Show("Book Returned");
                getBorrowList();
            }
            else
            {
                MessageBox.Show("Error This Book is already Returned","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtReturnRfid.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtReturnScode.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                txtBarrowId.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                DateTime tookDate =Convert.ToDateTime( dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                DateTime returnDate = tookDate.AddDays(15);
                txtReturnDate.Text = returnDate.ToString();
                TimeSpan differnce = returnDate.Subtract(DateTime.Now);

                if (Convert.ToInt32(differnce.TotalDays) < 0)
                {
                    txtLate.Text = differnce.TotalDays.ToString("00");
                    txtMoney.Text = (Convert.ToInt32(differnce.TotalDays) * 2).ToString();

                }
                else
                {
                    txtLate.Text = "0";
                    txtMoney.Text = "0";
                }
               

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RFIDController rf = new RFIDController();
            txtBorrowRfid.Text = rf.getUid();
            rf.clearUid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();
        }
    }
}
