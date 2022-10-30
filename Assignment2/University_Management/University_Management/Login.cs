using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace University_Management
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
     

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "v" && tb_Passward.Text == "v")
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Invalid username or Passward", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            tb_Username.Clear();
            tb_Passward.Clear();
            tb_Passward.Enabled = false;
            btn_Submit.Enabled = false;
            tb_Username.Focus();
        }

        private void tb_Passward_TextChanged_1(object sender, EventArgs e)
        {
              btn_Submit.Enabled = true;
        }

        private void tb_Username_TextChanged_1(object sender, EventArgs e)
        {
         lbl_Error.Visible = false;
            tb_Passward.Enabled = true;
        }
        }

     
       
    }

