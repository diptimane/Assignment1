using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University_Management
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=University_Management_DB;Integrated Security=True");

        void con_open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        void con_close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            con_open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con;
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username = @Uname And Password = @pwd";
            Cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_Passward.Text;

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (cnt>0)
            {
                
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Shared_Class.username = " Welcome " + tb_Username.Text;
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

