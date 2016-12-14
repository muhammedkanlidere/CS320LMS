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
    public partial class adminLogin : Form
    {
        LMS lms;
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Personel personel = lms.Personel.FirstOrDefault(o => o.pcode == txtPcode.Text);
             if(personel.password.Equals(txtPassword.Text))
            {
                BorrowControl brw = new BorrowControl();
                brw.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Failed Password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void adminLogin_Load(object sender, EventArgs e)
        {
            lms = new LMS();
        }
    }
}
