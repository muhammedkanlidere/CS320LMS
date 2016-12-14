using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForTesting
{
    public partial class BookControl : Form
    {
        public BookControl()
        {
            InitializeComponent();
        }

        
        LMS lms;
         private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                 if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView1.DataSource = bookBindingSource;
                }
                else
                 {
                     try
                    {
                        var query = from o in bookBindingSource.DataSource as List<Book>
                                    where o.name.Contains(txtSearch.Text)
                                    select o;
                        dataGridView1.DataSource = query.ToList();
                    }
                        catch(Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                
                }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            label8.Visible = true;
            try
            {
                panel.Enabled = true;
                txtRfid.Focus();
                Book b = new Book();
                b.recordDate = DateTime.Now;
                lms.Book.Add(b);
                bookBindingSource.Add(b);
                bookBindingSource.MoveLast();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtRfid.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            label8.Visible = false;
            btnNew.Enabled = true;
            bookBindingSource.ResetBindings(false);
            try
            {
                foreach (DbEntityEntry entry in lms.ChangeTracker.Entries())
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            bookBindingSource.MovePrevious();

                            break;
                        case EntityState.Modified:
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Deleted:
                            entry.Reload();
                            break;

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void success()
        {
            MessageBox.Show("Register Successful","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            label8.Visible = false;
            try
            {
                
                var count = lms.Book.Count(t => t.rfid == txtRfid.Text);
                if (count > 0)
                {
                    MessageBox.Show("This book has already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRfid.Text = "";
                }
                else
                {
                    //int istock = Convert.ToInt32(txtStock.Text);
                    //Book book = new Book() { rfid = txtRfid.Text,name = txtName.Text, author = txtAuthor.Text, shelf = txtShelf.Text,stock = istock };
                    //lms.Book.Add(book);
                    //success();


                    bookBindingSource.EndEdit();
                    lms.SaveChangesAsync();
                    bookBindingSource.MoveLast();
                    MessageBox.Show("Transaction Complete ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel.Enabled = false;

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookBindingSource.ResetBindings(false);
            }
        }

        private void BookControl_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            lms = new LMS();
            bookBindingSource.DataSource = lms.Book.ToList();
            int i =Convert.ToInt32(lms.Book.Count());
            dataGridView1.ClearSelection();
            dataGridView1.Rows[i].Selected = true;

          
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                
                if (MessageBox.Show("Are you sure  want to delete this ?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        lms.Book.Remove(bookBindingSource.Current as Book);
                        bookBindingSource.RemoveCurrent();
                        lms.SaveChanges();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            RFIDController rf = new RFIDController();
            txtRfid.Text = rf.getUid();
            rf.clearUid();
        }
    }
}
