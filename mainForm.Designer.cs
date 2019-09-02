namespace System
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cmbAccessLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.txtAddEmployeeID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAttMessage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.datePickTo = new System.Windows.Forms.DateTimePicker();
            this.datePickFrom = new System.Windows.Forms.DateTimePicker();
            this.rdBtnEmpID = new System.Windows.Forms.RadioButton();
            this.rdBtnDept = new System.Windows.Forms.RadioButton();
            this.dataGridAtt = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.lblAddImage);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.cmbDept);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.imgImage);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.dataGridEmp);
            this.tabPage1.Controls.Add(this.btnClearImage);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmpID);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblusername);
            this.tabPage1.Controls.Add(this.txtMname);
            this.tabPage1.Controls.Add(this.txtFirstname);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MANAGE EMPLOYEE";
            this.tabPage1.UseWaitCursor = true;
            // 
            // lblAddImage
            // 
            this.lblAddImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAddImage.Location = new System.Drawing.Point(17, 38);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(146, 155);
            this.lblAddImage.TabIndex = 38;
            this.lblAddImage.Text = "CLICK \r\nTO ADD IMAGE";
            this.lblAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddImage.UseWaitCursor = true;
            this.lblAddImage.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(309, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 28);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.UseWaitCursor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Administration",
            "Human Resource",
            "Accounts",
            "Bangladesh",
            "Compliance",
            "Cutting",
            "House Keeping",
            "Expats",
            "Finishing",
            "Garment Cleaning",
            "Security",
            "Industrial Engineering",
            "IT"});
            this.cmbDept.Location = new System.Drawing.Point(186, 387);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(232, 28);
            this.cmbDept.TabIndex = 36;
            this.cmbDept.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(441, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 30);
            this.label6.TabIndex = 25;
            this.label6.UseWaitCursor = true;
            // 
            // imgImage
            // 
            this.imgImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.imgImage.Location = new System.Drawing.Point(17, 38);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(146, 155);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 24;
            this.imgImage.TabStop = false;
            this.imgImage.UseWaitCursor = true;
            this.imgImage.Click += new System.EventHandler(this.picUploadImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "DEPARTMENT:";
            this.label5.UseWaitCursor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(186, 163);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(232, 30);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.UseWaitCursor = true;
            this.lblMessage.Click += new System.EventHandler(this.lblmessage_Click);
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Location = new System.Drawing.Point(456, 38);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.Size = new System.Drawing.Size(472, 377);
            this.dataGridEmp.TabIndex = 18;
            this.dataGridEmp.UseWaitCursor = true;
            this.dataGridEmp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridEmp_RowHeaderMouseClick);
            // 
            // btnClearImage
            // 
            this.btnClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearImage.Location = new System.Drawing.Point(186, 123);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(232, 28);
            this.btnClearImage.TabIndex = 17;
            this.btnClearImage.Text = "CLEAR IMAGE";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.UseWaitCursor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(309, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.UseWaitCursor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "EMPLOYEE ID:";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "LAST NAME:";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(186, 202);
            this.txtEmpID.Multiline = true;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(232, 27);
            this.txtEmpID.TabIndex = 14;
            this.txtEmpID.UseWaitCursor = true;
            this.txtEmpID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(186, 340);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(232, 27);
            this.txtSurname.TabIndex = 13;
            this.txtSurname.UseWaitCursor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(186, 81);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 28);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.UseWaitCursor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(186, 38);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 28);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.UseWaitCursor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "MIDDLE NAME:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(57, 248);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(106, 20);
            this.lblusername.TabIndex = 9;
            this.lblusername.Text = "FIRSTNAME:";
            this.lblusername.UseWaitCursor = true;
            this.lblusername.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.Location = new System.Drawing.Point(186, 293);
            this.txtMname.Multiline = true;
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(232, 27);
            this.txtMname.TabIndex = 8;
            this.txtMname.UseWaitCursor = true;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(186, 245);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(232, 27);
            this.txtFirstname.TabIndex = 7;
            this.txtFirstname.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.btnDeleteUser);
            this.tabPage2.Controls.Add(this.cmbAccessLevel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataGridUser);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtAddConfirmPassword);
            this.tabPage2.Controls.Add(this.txtAddPassword);
            this.tabPage2.Controls.Add(this.btnRegisterUser);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtAddUsername);
            this.tabPage2.Controls.Add(this.txtAddEmployeeID);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD NEW USER";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(345, 285);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(110, 28);
            this.btnDeleteUser.TabIndex = 36;
            this.btnDeleteUser.Text = "DELETE";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.UseWaitCursor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // cmbAccessLevel
            // 
            this.cmbAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessLevel.FormattingEnabled = true;
            this.cmbAccessLevel.Items.AddRange(new object[] {
            "Superadmin",
            "Admin"});
            this.cmbAccessLevel.Location = new System.Drawing.Point(223, 229);
            this.cmbAccessLevel.Name = "cmbAccessLevel";
            this.cmbAccessLevel.Size = new System.Drawing.Size(232, 28);
            this.cmbAccessLevel.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "ACCESS LEVEL:";
            this.label7.UseWaitCursor = true;
            // 
            // dataGridUser
            // 
            this.dataGridUser.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(481, 47);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(425, 373);
            this.dataGridUser.TabIndex = 32;
            this.dataGridUser.UseWaitCursor = true;
            this.dataGridUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellContentClick);
            this.dataGridUser.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridUser_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "CONFIRM PASSWORD:";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "PASSWORD:";
            this.label9.UseWaitCursor = true;
            // 
            // txtAddConfirmPassword
            // 
            this.txtAddConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddConfirmPassword.Location = new System.Drawing.Point(224, 179);
            this.txtAddConfirmPassword.Multiline = true;
            this.txtAddConfirmPassword.Name = "txtAddConfirmPassword";
            this.txtAddConfirmPassword.Size = new System.Drawing.Size(232, 27);
            this.txtAddConfirmPassword.TabIndex = 29;
            this.txtAddConfirmPassword.UseSystemPasswordChar = true;
            this.txtAddConfirmPassword.UseWaitCursor = true;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPassword.Location = new System.Drawing.Point(224, 134);
            this.txtAddPassword.Multiline = true;
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(232, 27);
            this.txtAddPassword.TabIndex = 28;
            this.txtAddPassword.UseSystemPasswordChar = true;
            this.txtAddPassword.UseWaitCursor = true;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegisterUser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegisterUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnRegisterUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegisterUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(223, 285);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(110, 28);
            this.btnRegisterUser.TabIndex = 26;
            this.btnRegisterUser.Text = "ADD USER";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.UseWaitCursor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "USERNAME:";
            this.label10.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "EMPOYEE ID:";
            this.label11.UseWaitCursor = true;
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUsername.Location = new System.Drawing.Point(224, 90);
            this.txtAddUsername.Multiline = true;
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(232, 27);
            this.txtAddUsername.TabIndex = 23;
            this.txtAddUsername.UseWaitCursor = true;
            // 
            // txtAddEmployeeID
            // 
            this.txtAddEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAddEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmployeeID.Location = new System.Drawing.Point(224, 47);
            this.txtAddEmployeeID.Multiline = true;
            this.txtAddEmployeeID.Name = "txtAddEmployeeID";
            this.txtAddEmployeeID.Size = new System.Drawing.Size(232, 27);
            this.txtAddEmployeeID.TabIndex = 22;
            this.txtAddEmployeeID.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.btnExport);
            this.tabPage3.Controls.Add(this.lblAttMessage);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.lblFromDate);
            this.tabPage3.Controls.Add(this.datePickTo);
            this.tabPage3.Controls.Add(this.datePickFrom);
            this.tabPage3.Controls.Add(this.rdBtnEmpID);
            this.tabPage3.Controls.Add(this.rdBtnDept);
            this.tabPage3.Controls.Add(this.dataGridAtt);
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(945, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VIEW ATTENDANCE";
            // 
            // lblAttMessage
            // 
            this.lblAttMessage.ForeColor = System.Drawing.Color.Red;
            this.lblAttMessage.Location = new System.Drawing.Point(61, 120);
            this.lblAttMessage.Name = "lblAttMessage";
            this.lblAttMessage.Size = new System.Drawing.Size(523, 30);
            this.lblAttMessage.TabIndex = 27;
            this.lblAttMessage.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "To:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(61, 96);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(50, 20);
            this.lblFromDate.TabIndex = 26;
            this.lblFromDate.Text = "From:";
            // 
            // datePickTo
            // 
            this.datePickTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickTo.CustomFormat = "MM-dd-yyyy";
            this.datePickTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickTo.Location = new System.Drawing.Point(384, 91);
            this.datePickTo.Name = "datePickTo";
            this.datePickTo.Size = new System.Drawing.Size(200, 26);
            this.datePickTo.TabIndex = 25;
            this.datePickTo.Value = new System.DateTime(2019, 4, 11, 0, 0, 0, 0);
            // 
            // datePickFrom
            // 
            this.datePickFrom.CustomFormat = "MM-dd-yyyy";
            this.datePickFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickFrom.Location = new System.Drawing.Point(117, 91);
            this.datePickFrom.Name = "datePickFrom";
            this.datePickFrom.Size = new System.Drawing.Size(200, 26);
            this.datePickFrom.TabIndex = 25;
            this.datePickFrom.Value = new System.DateTime(2019, 4, 19, 0, 0, 0, 0);
            // 
            // rdBtnEmpID
            // 
            this.rdBtnEmpID.AutoSize = true;
            this.rdBtnEmpID.Location = new System.Drawing.Point(460, 48);
            this.rdBtnEmpID.Name = "rdBtnEmpID";
            this.rdBtnEmpID.Size = new System.Drawing.Size(142, 24);
            this.rdBtnEmpID.TabIndex = 24;
            this.rdBtnEmpID.TabStop = true;
            this.rdBtnEmpID.Text = "by Employee ID:";
            this.rdBtnEmpID.UseVisualStyleBackColor = true;
            this.rdBtnEmpID.CheckedChanged += new System.EventHandler(this.rdBtnEmpID_CheckedChanged);
            // 
            // rdBtnDept
            // 
            this.rdBtnDept.AutoSize = true;
            this.rdBtnDept.Location = new System.Drawing.Point(323, 46);
            this.rdBtnDept.Name = "rdBtnDept";
            this.rdBtnDept.Size = new System.Drawing.Size(131, 24);
            this.rdBtnDept.TabIndex = 23;
            this.rdBtnDept.TabStop = true;
            this.rdBtnDept.Text = "by Deparment:";
            this.rdBtnDept.UseVisualStyleBackColor = true;
            // 
            // dataGridAtt
            // 
            this.dataGridAtt.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridAtt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAtt.Location = new System.Drawing.Point(54, 153);
            this.dataGridAtt.Name = "dataGridAtt";
            this.dataGridAtt.Size = new System.Drawing.Size(838, 268);
            this.dataGridAtt.TabIndex = 22;
            this.dataGridAtt.UseWaitCursor = true;
            this.dataGridAtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(739, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 28);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.UseWaitCursor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(627, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 28);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.UseWaitCursor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "SEARCH:";
            this.label4.UseWaitCursor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(117, 45);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.UseWaitCursor = true;
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(627, 89);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(209, 28);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "EXPORT TO EXCEL";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.UseWaitCursor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.TabControl tabControl1;
        private Windows.Forms.TabPage tabPage1;
        private Windows.Forms.TabPage tabPage2;
        private Windows.Forms.TabPage tabPage3;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label3;
        private Windows.Forms.TextBox txtEmpID;
        private Windows.Forms.TextBox txtSurname;
        private Windows.Forms.Button btnUpdate;
        private Windows.Forms.Button btnRegister;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label lblusername;
        private Windows.Forms.TextBox txtMname;
        private Windows.Forms.TextBox txtFirstname;
        private Windows.Forms.Button btnDelete;
        private Windows.Forms.DataGridView dataGridEmp;
        private Windows.Forms.Label lblMessage;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label label7;
        private Windows.Forms.DataGridView dataGridUser;
        private Windows.Forms.Label label8;
        private Windows.Forms.Label label9;
        private Windows.Forms.TextBox txtAddConfirmPassword;
        private Windows.Forms.TextBox txtAddPassword;
        private Windows.Forms.Button btnRegisterUser;
        private Windows.Forms.Label label10;
        private Windows.Forms.Label label11;
        private Windows.Forms.TextBox txtAddUsername;
        private Windows.Forms.TextBox txtAddEmployeeID;
        private Windows.Forms.ComboBox cmbAccessLevel;
        private Windows.Forms.Button btnDeleteUser;
        private Windows.Forms.DataGridView dataGridAtt;
        private Windows.Forms.Button btnSearch;
        private Windows.Forms.Label label4;
        private Windows.Forms.TextBox txtSearch;
        private Windows.Forms.Label label6;
        private Windows.Forms.PictureBox imgImage;
        private Windows.Forms.Button btnClearImage;
        private Windows.Forms.ComboBox cmbDept;
        private Windows.Forms.Button btnRefresh;
        private Windows.Forms.DateTimePicker datePickFrom;
        private Windows.Forms.RadioButton rdBtnEmpID;
        private Windows.Forms.RadioButton rdBtnDept;
        private Windows.Forms.Label label12;
        private Windows.Forms.Label lblFromDate;
        private Windows.Forms.DateTimePicker datePickTo;
        private Windows.Forms.Label lblAttMessage;
        private Windows.Forms.Label lblAddImage;
        private Windows.Forms.Button btnClear;
        private Windows.Forms.Button btnExport;
    }
}