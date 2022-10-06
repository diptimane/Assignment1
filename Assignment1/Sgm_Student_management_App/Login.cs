using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sgm_Student_management_App
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
            tb_Passward.Enabled = true;
           
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
             if (tb_Username.Text == "Dipti" && tb_Passward.Text == "D123")
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
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

        private void tb_Passward_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        

       
       

    }
}
