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
    public partial class StudentControl : Form
    {
        LMS lms;
        public StudentControl()
        {
            InitializeComponent();
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            lms = new LMS();
            panel.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentBindingSource.DataSource = lms.Student.ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            lblWarning.Visible = true;
            try
            {
                panel.Enabled = true;
                txtScode.Focus();
                Student s = new Student();
                s.dateOfRecord = DateTime.Now;
                lms.Student.Add(s);
                studentBindingSource.Add(s);
                studentBindingSource.MoveLast();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtScode.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            lblWarning.Visible = false;
            btnNew.Enabled = true;
            studentBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in lms.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        studentBindingSource.MovePrevious();
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            lblWarning.Visible = false;

           
            try
            {
                studentBindingSource.EndEdit();
                lms.SaveChangesAsync();
                studentBindingSource.MoveLast();
                panel.Enabled = false;
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentBindingSource.ResetBindings(false);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show("Are you sure  want to delete this ?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        lms.Student.Remove(studentBindingSource.Current as Student);
                        studentBindingSource.RemoveCurrent();
                        lms.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } 
        }

        private void StudentControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Enabled = true;
            this.Dispose();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridView1.DataSource = studentBindingSource;
            }
            else
            {
                try
                {
                    var query = from o in studentBindingSource.DataSource as List<Student>
                                where o.name.Contains(txtSearch.Text) || o.scode.Contains(txtSearch.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
