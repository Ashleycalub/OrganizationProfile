namespace OrganizationProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtContactNo=new TextBox();
            btnRegistration=new Button();
            cbProgram=new ComboBox();
            cbGender=new ComboBox();
            label10=new Label();
            label9=new Label();
            label8=new Label();
            txtMiddleInitial=new TextBox();
            label7=new Label();
            datePickerBirthday=new DateTimePicker();
            label5=new Label();
            txtAge=new TextBox();
            txtFirstName=new TextBox();
            label6=new Label();
            txtLastName=new TextBox();
            txtStudentNo=new TextBox();
            label4=new Label();
            label3=new Label();
            label1=new Label();
            label11=new Label();
            SuspendLayout();
            // 
            // txtContactNo
            // 
            txtContactNo.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNo.Location=new Point(535, 208);
            txtContactNo.Name="txtContactNo";
            txtContactNo.Size=new Size(145, 29);
            txtContactNo.TabIndex=64;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor=Color.LightCoral;
            btnRegistration.FlatStyle=FlatStyle.Flat;
            btnRegistration.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistration.Location=new Point(298, 272);
            btnRegistration.Name="btnRegistration";
            btnRegistration.Size=new Size(112, 34);
            btnRegistration.TabIndex=63;
            btnRegistration.Text="Register";
            btnRegistration.UseVisualStyleBackColor=false;
            btnRegistration.Click+=button1_Click;
            // 
            // cbProgram
            // 
            cbProgram.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbProgram.FormattingEnabled=true;
            cbProgram.Location=new Point(412, 75);
            cbProgram.Name="cbProgram";
            cbProgram.Size=new Size(268, 29);
            cbProgram.TabIndex=62;
            // 
            // cbGender
            // 
            cbGender.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled=true;
            cbGender.Location=new Point(408, 161);
            cbGender.Name="cbGender";
            cbGender.Size=new Size(139, 29);
            cbGender.TabIndex=61;
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location=new Point(428, 216);
            label10.Name="label10";
            label10.RightToLeft=RightToLeft.No;
            label10.Size=new Size(101, 21);
            label10.TabIndex=60;
            label10.Text="Contact No:";
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location=new Point(337, 169);
            label9.Name="label9";
            label9.RightToLeft=RightToLeft.No;
            label9.Size=new Size(69, 21);
            label9.TabIndex=59;
            label9.Text="Gender:";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location=new Point(328, 83);
            label8.Name="label8";
            label8.RightToLeft=RightToLeft.No;
            label8.Size=new Size(78, 21);
            label8.TabIndex=58;
            label8.Text="Program:";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiddleInitial.Location=new Point(612, 123);
            txtMiddleInitial.Name="txtMiddleInitial";
            txtMiddleInitial.Size=new Size(68, 29);
            txtMiddleInitial.TabIndex=57;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location=new Point(565, 126);
            label7.Name="label7";
            label7.RightToLeft=RightToLeft.No;
            label7.Size=new Size(41, 21);
            label7.TabIndex=56;
            label7.Text="M.I:";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerBirthday.Location=new Point(137, 208);
            datePickerBirthday.Name="datePickerBirthday";
            datePickerBirthday.Size=new Size(273, 29);
            datePickerBirthday.TabIndex=55;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(54, 216);
            label5.Name="label5";
            label5.RightToLeft=RightToLeft.No;
            label5.Size=new Size(77, 21);
            label5.TabIndex=54;
            label5.Text="Birthday:";
            // 
            // txtAge
            // 
            txtAge.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location=new Point(133, 166);
            txtAge.Name="txtAge";
            txtAge.Size=new Size(161, 29);
            txtAge.TabIndex=53;
            // 
            // txtFirstName
            // 
            txtFirstName.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location=new Point(412, 123);
            txtFirstName.Name="txtFirstName";
            txtFirstName.Size=new Size(135, 29);
            txtFirstName.TabIndex=52;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(310, 131);
            label6.Name="label6";
            label6.RightToLeft=RightToLeft.No;
            label6.Size=new Size(96, 21);
            label6.TabIndex=51;
            label6.Text="First Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location=new Point(133, 123);
            txtLastName.Name="txtLastName";
            txtLastName.Size=new Size(161, 29);
            txtLastName.TabIndex=50;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentNo.Location=new Point(133, 80);
            txtStudentNo.Name="txtStudentNo";
            txtStudentNo.Size=new Size(161, 29);
            txtStudentNo.TabIndex=49;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(87, 174);
            label4.Name="label4";
            label4.RightToLeft=RightToLeft.No;
            label4.Size=new Size(44, 21);
            label4.TabIndex=48;
            label4.Text="Age:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(37, 131);
            label3.Name="label3";
            label3.RightToLeft=RightToLeft.No;
            label3.Size=new Size(94, 21);
            label3.TabIndex=47;
            label3.Text="Last Name:";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(27, 88);
            label1.Name="label1";
            label1.RightToLeft=RightToLeft.No;
            label1.Size=new Size(104, 21);
            label1.TabIndex=46;
            label1.Text="Student No.:";
            // 
            // label11
            // 
            label11.AutoSize=true;
            label11.BackColor=Color.Gainsboro;
            label11.FlatStyle=FlatStyle.Popup;
            label11.Font=new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location=new Point(27, 31);
            label11.Name="label11";
            label11.RightToLeft=RightToLeft.No;
            label11.Size=new Size(139, 26);
            label11.TabIndex=45;
            label11.Text="Registration";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Info;
            ClientSize=new Size(706, 332);
            Controls.Add(txtContactNo);
            Controls.Add(btnRegistration);
            Controls.Add(cbProgram);
            Controls.Add(cbGender);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label7);
            Controls.Add(datePickerBirthday);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label11);
            Name="frmRegistration";
            Text="Organization Profile";
            Load+=frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContactNo;
        private Button btnRegistration;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtMiddleInitial;
        private Label label7;
        private DateTimePicker datePickerBirthday;
        private Label label5;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtStudentNo;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label11;
    }
}