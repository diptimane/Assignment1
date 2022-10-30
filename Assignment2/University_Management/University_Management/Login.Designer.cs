namespace University_Management
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Passward = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Passward = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Oxford_Student_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(357, 559);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(343, 25);
            this.lbl_Error.TabIndex = 14;
            this.lbl_Error.Text = "Enter valid username && Passward";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Thistle;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Submit.Location = new System.Drawing.Point(400, 620);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(245, 80);
            this.btn_Submit.TabIndex = 13;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_Passward
            // 
            this.tb_Passward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Passward.Enabled = false;
            this.tb_Passward.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Passward.Location = new System.Drawing.Point(665, 434);
            this.tb_Passward.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Passward.Name = "tb_Passward";
            this.tb_Passward.PasswordChar = '*';
            this.tb_Passward.Size = new System.Drawing.Size(407, 56);
            this.tb_Passward.TabIndex = 12;
            this.tb_Passward.TextChanged += new System.EventHandler(this.tb_Passward_TextChanged_1);
            // 
            // tb_Username
            // 
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(665, 260);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(407, 56);
            this.tb_Username.TabIndex = 9;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged_1);
            // 
            // lbl_Passward
            // 
            this.lbl_Passward.AutoSize = true;
            this.lbl_Passward.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Passward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Passward.Font = new System.Drawing.Font("Modern No. 20", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passward.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_Passward.Location = new System.Drawing.Point(106, 434);
            this.lbl_Passward.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Passward.Name = "lbl_Passward";
            this.lbl_Passward.Size = new System.Drawing.Size(227, 56);
            this.lbl_Passward.TabIndex = 11;
            this.lbl_Passward.Text = "Passward";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_Username.Location = new System.Drawing.Point(106, 260);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(236, 56);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Oxford_Student_Login
            // 
            this.lbl_Oxford_Student_Login.AutoSize = true;
            this.lbl_Oxford_Student_Login.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Oxford_Student_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Oxford_Student_Login.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oxford_Student_Login.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Oxford_Student_Login.Location = new System.Drawing.Point(212, 63);
            this.lbl_Oxford_Student_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Oxford_Student_Login.Name = "lbl_Oxford_Student_Login";
            this.lbl_Oxford_Student_Login.Size = new System.Drawing.Size(742, 85);
            this.lbl_Oxford_Student_Login.TabIndex = 8;
            this.lbl_Oxford_Student_Login.Text = "Oxford Student Login";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Passward);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Passward);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Oxford_Student_Login);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Passward;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Passward;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Oxford_Student_Login;
    }
}

