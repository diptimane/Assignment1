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
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_Management_DBDataSet1.university_student_details' table. You can move, or remove it, as needed.
            this.university_student_detailsTableAdapter.Fill(this.university_Management_DBDataSet1.university_student_details);
            lbl_UName.Text = Shared_Class.username;
        }


    }
}
