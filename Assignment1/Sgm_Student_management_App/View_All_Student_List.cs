﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sgm_Student_management_App
{
    public partial class frm_View_All_Student_list : Form
    {
        public frm_View_All_Student_list()
        {
            InitializeComponent();
        }

        private void frm_View_All_Student_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_DBDataSet.Student_Details);

        }

        private void lbl_Add_New_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
            obj.Show();
            this.Hide();
        }
    }
}
