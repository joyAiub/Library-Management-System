namespace LibraryManagement
{
    partial class borrower_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrower_info));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserFaculty = new System.Windows.Forms.RadioButton();
            this.UserStudent = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InactiveUser = new System.Windows.Forms.RadioButton();
            this.ActiveUser = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userMobile = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 400);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.userPass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.userEmail);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.userAddress);
            this.groupBox1.Controls.Add(this.userMobile);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.userId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 361);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserFaculty);
            this.panel1.Controls.Add(this.UserStudent);
            this.panel1.Location = new System.Drawing.Point(110, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 27);
            this.panel1.TabIndex = 57;
            // 
            // UserFaculty
            // 
            this.UserFaculty.AutoSize = true;
            this.UserFaculty.Location = new System.Drawing.Point(79, 3);
            this.UserFaculty.Name = "UserFaculty";
            this.UserFaculty.Size = new System.Drawing.Size(62, 19);
            this.UserFaculty.TabIndex = 12;
            this.UserFaculty.TabStop = true;
            this.UserFaculty.Text = "Faculty";
            this.UserFaculty.UseVisualStyleBackColor = true;
            // 
            // UserStudent
            // 
            this.UserStudent.AutoSize = true;
            this.UserStudent.Location = new System.Drawing.Point(3, 3);
            this.UserStudent.Name = "UserStudent";
            this.UserStudent.Size = new System.Drawing.Size(62, 19);
            this.UserStudent.TabIndex = 11;
            this.UserStudent.TabStop = true;
            this.UserStudent.Text = "Student";
            this.UserStudent.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Password:";
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(110, 74);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.Size = new System.Drawing.Size(164, 21);
            this.userPass.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Email:";
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(110, 208);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(164, 21);
            this.userEmail.TabIndex = 53;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(199, 317);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 51;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InactiveUser);
            this.panel2.Controls.Add(this.ActiveUser);
            this.panel2.Location = new System.Drawing.Point(110, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 27);
            this.panel2.TabIndex = 50;
            // 
            // InactiveUser
            // 
            this.InactiveUser.AutoSize = true;
            this.InactiveUser.Location = new System.Drawing.Point(79, 3);
            this.InactiveUser.Name = "InactiveUser";
            this.InactiveUser.Size = new System.Drawing.Size(63, 19);
            this.InactiveUser.TabIndex = 12;
            this.InactiveUser.TabStop = true;
            this.InactiveUser.Text = "Inactive";
            this.InactiveUser.UseVisualStyleBackColor = true;
            // 
            // ActiveUser
            // 
            this.ActiveUser.AutoSize = true;
            this.ActiveUser.Location = new System.Drawing.Point(3, 3);
            this.ActiveUser.Name = "ActiveUser";
            this.ActiveUser.Size = new System.Drawing.Size(57, 19);
            this.ActiveUser.TabIndex = 11;
            this.ActiveUser.TabStop = true;
            this.ActiveUser.Text = "Active";
            this.ActiveUser.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Borrower Information";
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(110, 174);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(164, 21);
            this.userAddress.TabIndex = 49;
            // 
            // userMobile
            // 
            this.userMobile.Location = new System.Drawing.Point(110, 142);
            this.userMobile.Name = "userMobile";
            this.userMobile.Size = new System.Drawing.Size(164, 21);
            this.userMobile.TabIndex = 48;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(110, 109);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(164, 21);
            this.userName.TabIndex = 47;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(110, 40);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(164, 21);
            this.userId.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Borrower Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mobile No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID:";
            // 
            // borrower_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "borrower_info";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton UserFaculty;
        private System.Windows.Forms.RadioButton UserStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton InactiveUser;
        private System.Windows.Forms.RadioButton ActiveUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userMobile;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}