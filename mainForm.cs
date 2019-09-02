using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using MaterialSkin;

namespace System
{
    public partial class mainForm : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        public string host;
       // public string conInfo;
        //string conInfo = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=attendanceDB;Integrated Security=True";
        //public string conInfo = "Data Source=DESKTOP-CA7ENAM;Initial Catalog=attendanceDB;User ID=sa;Password=2018";
        //string conInfo = "Data Source=(localdb)\\Projects;Initial Catalog=attendanceDB;Integrated Security=True";
        string conInfo = "Data Source=DTRT-SVR\\Projects;Initial Catalog=attendanceDB;Integrated Security=True";
        public mainForm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.BlueGrey100, Primary.DeepOrange500, Accent.Blue700, TextShade.WHITE);
            //conInfo = "Data Source =" + this.host + "; Initial Catalog = attendanceDB; user =sa; password = 2018";

            //con = new SqlConnection(conInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conInfo);
            string sqlstate = "DELETE Employee WHERE Employee_ID = @empID";
            cmd = new SqlCommand(sqlstate, con);
            cmd.Parameters.AddWithValue("@empID", txtEmpID.Text.Trim());



            if (txtEmpID.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete employee " + txtEmpID.Text + "?", "DELETING EMPLOYEE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               // MessageBox.Show("Are you sure you want to delete employee " + txtEmpID.Text + "?", "DELETING EMPLOYEE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if(result == DialogResult.Yes)
                {
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        txtEmpID.BackColor = Color.Red;
                        DisplayData("Select * from employee", dataGridEmp);
                        con.Close();
                        txtEmpID.BackColor = Color.White;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(lblMessage, "Deletion of employee " + txtEmpID.Text + " completed successfully");
                        }
                        else
                        {
                            MessageBox.Show("Employee " + txtEmpID.Text + " does not exist in the system", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch(SqlException ex)
                    {
                        var sqlException = ex.InnerException as SqlException;

                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot delete employee " + txtAddEmployeeID.Text + " because employee is an admin.", "Deletion Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                    
                    

                }
                //if(|MessageBoxButtons.YesNo = ye)
            }
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblAddPlayer_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == String.Empty)
            {
                lblMessage.Text = "Employee ID is required";
            }
            else if (txtFirstname.Text == String.Empty)
            {
                lblMessage.Text = "Firstname is required";
            }
            else if (txtSurname.Text == String.Empty)
            {
                lblMessage.Text = "Lastname is required";
            }
            else if (cmbDept.Text == String.Empty)
            {
                lblMessage.Text = "Department is required";
            }
            else if (imgImage.Image == null)
            {
                con = new SqlConnection(conInfo);
                string sqlstate = "INSERT INTO Employee(Employee_ID,Firstname,Middlename,Lastname,Dept_name) VALUES(@empID,@fname,@mname,@lname,@dept)";
                cmd = new SqlCommand(sqlstate, con);
                cmd.Parameters.AddWithValue("@empID", txtEmpID.Text.Trim());
                cmd.Parameters.AddWithValue("@fname", txtFirstname.Text.Trim());
                cmd.Parameters.AddWithValue("@mname", txtMname.Text.Trim());
                cmd.Parameters.AddWithValue("@lname", txtSurname.Text.Trim());
                cmd.Parameters.AddWithValue("@dept", cmbDept.Text.Trim());
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //.Show("Employee :" + txtEmpID + " " + txtFirstname.Text + " " + txtSurname.Text + " added succesfully!");
                    lblMessage.ForeColor = Color.Green;
                    // lblMessage.Text = "Employee: " + txtEmpID.Text + " " + txtFirstname.Text + " " + txtSurname.Text + " added successfully!";
                    MessageBox.Show(lblMessage, "Employee: " + txtEmpID.Text + " " + txtFirstname.Text + " " + txtSurname.Text + " added successfully!");
                }
                catch (SqlException ex)
                {
                    var sqlException = ex.InnerException as SqlException;


                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Employee ID has been registered already; cannot create duplicate record");
                    }
                    //else
                    //{
                    //    MessageBox.Show("Employee registration failed");
                    //}
                }
                clearAll();
                DisplayData("Select * from employee", dataGridEmp);
                con.Close();
            }
            else
            {
                con = new SqlConnection(conInfo);
                string sqlstate = "INSERT INTO Employee VALUES(@empID,@fname,@mname,@lname,@Picture,@dept)";
                cmd = new SqlCommand(sqlstate, con);
                cmd.Parameters.AddWithValue("@empID", txtEmpID.Text.Trim());
                cmd.Parameters.AddWithValue("@fname", txtFirstname.Text.Trim());
                cmd.Parameters.AddWithValue("@mname", txtMname.Text.Trim());
                cmd.Parameters.AddWithValue("@lname", txtSurname.Text.Trim());
                cmd.Parameters.AddWithValue("@dept", cmbDept.Text.Trim());
                conv_photo();
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //.Show("Employee :" + txtEmpID + " " + txtFirstname.Text + " " + txtSurname.Text + " added succesfully!");
                    lblMessage.ForeColor = Color.Green;
                    // lblMessage.Text = "Employee: " + txtEmpID.Text + " " + txtFirstname.Text + " " + txtSurname.Text + " added successfully!";
                    MessageBox.Show(lblMessage, "Employee: " + txtEmpID.Text + " " + txtFirstname.Text + " " + txtSurname.Text + " added successfully!");
                }
                catch (SqlException ex)
                {
                    var sqlException = ex.InnerException as SqlException;


                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Employee ID has been registered already; cannot create duplicate record");
                    }
                    else
                    {
                        MessageBox.Show("Employee registration failed");
                    }
                }

                clearAll();
                DisplayData("Select * from employee", dataGridEmp);
                con.Close();


            }
        }

        private void DisplayData(string sqlStatement, DataGridView grid)
        {
            //con.Open();
            con = new SqlConnection(conInfo);
            DataTable dt = new DataTable();
            SqlDataAdapter dat = new SqlDataAdapter(sqlStatement, con);
            dat.Fill(dt);
            grid.DataSource = dt;
           
        }

        public void conv_photo()
        {
            //There must be a picture in the picture box
            if (imgImage.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                //ms = new MemoryStream();
                //Saving the format of the picture into the memorystream
                imgImage.Image.Save(ms, ImageFormat.Jpeg);

                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                //placing the converted picture inside the parameter of the insert statement
                cmd.Parameters.AddWithValue("@Picture", photo_aray);
            }
        }
        
        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            imgImage.Image = null;
            lblAddImage.Visible = true;
        }

        private void clearAll()
        {
            txtEmpID.Text = String.Empty;
            txtFirstname.Text = String.Empty;
            txtMname.Text = String.Empty;
            txtSurname.Text = String.Empty;
            cmbDept.Text = String.Empty;
            imgImage.Image = null;
            lblMessage.Text = String.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conInfo);
            string empUpdate= "Employee_ID = @empID ";
            string fnameUpdate = "Firstname = @fname, ";
            string mnameUpdate = "Middlename = @mname, ";
            string lnameUpdate = "Lastname = @lname, ";
            string deptUpdate = "Dept_name = @dept,";
            string picUpdate = "Picture = @Picture, ";
            string updatestatement = "UPDATE Employee SET " + fnameUpdate + mnameUpdate + lnameUpdate + deptUpdate + picUpdate + empUpdate + "WHERE Employee_ID = @empID";
            //string newupdate;
         
           // cmd.Parameters.AddWithValue("@Picture", cmbDept.Text);
            cmd = new SqlCommand(updatestatement, con);
            if (txtEmpID.Text == String.Empty)
            {
                MessageBox.Show(lblMessage, "Please provide an employee ID");
            }
            else 
            {
               
                cmd.Parameters.AddWithValue("@empID", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@mname", txtMname.Text);
                cmd.Parameters.AddWithValue("@lname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@dept", cmbDept.Text);
                conv_photo();
            }
            int rowAffect;
            
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                rowAffect = cmd.ExecuteNonQuery();
                DisplayData("Select * from employee", dataGridEmp);

            if (rowAffect == 0)
            {
                MessageBox.Show(lblMessage, "Employee ID " + txtEmpID.Text + " does not exist in the system");
            }
            else
            {
                MessageBox.Show(lblMessage, "Update of employee " + txtEmpID.Text + " completed successfully");
            }

            con.Close();
            con.Dispose();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conInfo);
            
            //da = new SqlDataAdapter("SELECT * FROM EMPLOYEE", con);
            //da.Fill(ds, "EMPLOYEE");
            ////adds information into the datagrid view
            //dataGridEmp.DataSource = ds.Tables["EMPLOYEE"].DefaultView;
            DisplayData("SELECT * FROM EMPLOYEE",dataGridEmp);
            DisplayData("SELECT EMPLOYEE_ID,USERNAMEA,ACCESSLV FROM CREDENTIALITY",dataGridUser);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string sqlstatement = "INSERT INTO Credentiality values(@User,@Pass,@Acc,@Emp)";
            con = new SqlConnection(conInfo);
            cmd = new SqlCommand(sqlstatement, con);
            cmd.Parameters.AddWithValue("@Emp", txtAddEmployeeID.Text.Trim());
            cmd.Parameters.AddWithValue("@User", txtAddUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@Pass", txtAddConfirmPassword.Text.Trim());
            cmd.Parameters.AddWithValue("@Acc", cmbAccessLevel.Text.Trim());

            if (txtAddEmployeeID.Text == String.Empty)
            {
                MessageBox.Show("Employee ID is mandatory");
            }
            else if (txtAddUsername.Text.Equals(String.Empty) || txtAddPassword.Text.Equals(txtAddUsername.Text.Equals(String.Empty) || txtAddConfirmPassword.Text.Equals(String.Empty) || cmbAccessLevel.SelectedItem.Equals(null)))
            {
                MessageBox.Show("Please input all information");
            }
            else if (txtAddPassword.Text != txtAddConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match input password again");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DisplayData("Select Employee_ID,UsernameA,AccessLV from Credentiality ", dataGridUser);
                    MessageBox.Show("New User added successfully!");

                }
                catch (SqlException ex)
                {
                    var sqlException = ex.InnerException as SqlException;

                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Employee ID " + txtAddEmployeeID.Text + " does not exist please specify an existing Employee ID");
                    }
                    else if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Employee ID or username already in use, please specify a new employee ID or username");
                    }

                    else
                    {
                        MessageBox.Show("User creation failed");
                    }
                }
            }
            con.Dispose();
            con.Close();
            txtAddEmployeeID.Clear();
            txtAddUsername.Clear();
            txtAddPassword.Clear();
            txtAddConfirmPassword.Clear();
            cmbAccessLevel.SelectedItem = null;
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conInfo);
            string sqlstate = "DELETE Credentiality WHERE Employee_ID = @empID";
            cmd = new SqlCommand(sqlstate, con);
            cmd.Parameters.AddWithValue("@empID", txtAddEmployeeID.Text.Trim());

            if (txtAddEmployeeID.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete user " + txtAddEmployeeID.Text + "?", "DELETING USER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // MessageBox.Show("Are you sure you want to delete employee " + txtEmpID.Text + "?", "DELETING EMPLOYEE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DisplayData("Select Employee_ID,UsernameA,AccessLV from Credentiality ",dataGridUser);
                    con.Close();
                    
                }
                else if (result == DialogResult.No)
                {
                    
                }
                //if(MessageBoxButtons.YesNo = ye)
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdBtnEmpID_CheckedChanged(object sender, EventArgs e)
        {

        }

        DataTable dtView = new DataTable();
        string sqlStates;

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            dataGridAtt.DataSource = dtView;
            if (datePickFrom.Value == datePickTo.Value)
            {
                lblAttMessage.Text = "Please make sure a proper range of dates is selected";
            }
            else if (rdBtnDept.Checked == true)
            {
                sqlStates = " SELECT EMPLOYEE.EMPLOYEE_ID, FIRSTNAME,MIDDLENAME,LASTNAME, DEPT_NAME, DATE_IN,TIME_IN, DATE_OUT,TIME_OUT " +
               "FROM EMPLOYEE JOIN ATTENDIN ON EMPLOYEE.EMPLOYEE_ID = ATTENDIN.EMPLOYEE_ID JOIN ATTENDOUT " +
               "ON ATTENDIN.ATTENDIN_ID = ATTENDOUT.ATTENDIN_ID WHERE DATE_IN  BETWEEN '" + datePickFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + datePickTo.Value.ToString("yyyy/MM/dd") + "' " +
             "AND Employee.Dept_name = '" + txtSearch.Text.Trim() + "'";

                da = new SqlDataAdapter(sqlStates, con);

                da.Fill(dtView);
                dataGridAtt.DataSource = dtView;
            }
            else if (rdBtnEmpID.Checked == true)
            {
            
                sqlStates = " SELECT EMPLOYEE.EMPLOYEE_ID, FIRSTNAME,MIDDLENAME,LASTNAME, DEPT_NAME, DATE_IN,TIME_IN, DATE_OUT,TIME_OUT " +
                "FROM EMPLOYEE JOIN ATTENDIN ON EMPLOYEE.EMPLOYEE_ID = ATTENDIN.EMPLOYEE_ID JOIN ATTENDOUT "+
                "ON ATTENDIN.ATTENDIN_ID = ATTENDOUT.ATTENDIN_ID WHERE DATE_IN  BETWEEN '"+datePickFrom.Value.ToString("yyyy/MM/dd") + "' AND '"+datePickTo.Value.ToString("yyyy/MM/dd") + "' " +
              "AND Employee.Employee_ID = '" + txtSearch.Text.Trim()+"'";
                da = new SqlDataAdapter(sqlStates, con);

                da.Fill(dtView);
                dataGridAtt.DataSource = dtView;
            }
            else
            {
                sqlStates = " SELECT TOP 100 EMPLOYEE.EMPLOYEE_ID, FIRSTNAME,MIDDLENAME,LASTNAME, DEPT_NAME, DATE_IN,TIME_IN, DATE_OUT,TIME_OUT " +
                "FROM EMPLOYEE JOIN ATTENDIN ON EMPLOYEE.EMPLOYEE_ID = ATTENDIN.EMPLOYEE_ID JOIN ATTENDOUT " +
                "ON ATTENDIN.ATTENDIN_ID = ATTENDOUT.ATTENDIN_ID WHERE DATE_IN  BETWEEN '" + datePickFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + datePickTo.Value.ToString("yyyy/MM/dd")+"'";
             

                da = new SqlDataAdapter(sqlStates, con);

                da.Fill(dtView);
                dataGridAtt.DataSource = dtView;
            }
        }

        private void dataGridEmp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEmpID.Text = dataGridEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dataGridEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMname.Text = dataGridEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dataGridEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
            Image img1 = byteToImage((byte[])dataGridEmp.Rows[e.RowIndex].Cells[4].Value);
            imgImage.Image = img1;
            cmbDept.Text = dataGridEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //Converting from byte to image
        public Image byteToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void dataGridUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtAddEmployeeID.Text = dataGridUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAddUsername.Text = dataGridUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbAccessLevel.Text = dataGridUser.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch(ArgumentOutOfRangeException)
            {
                
            }
            
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData("SELECT * FROM EMPLOYEE",dataGridEmp);
        }

        private void picUploadImage_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
//Creating an openfildialog object to use the openfiledialog
            OpenFileDialog opf = new OpenFileDialog();

            //specifying the format of the image that can be included
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            //
            if (opf.ShowDialog() == DialogResult.OK)
            {
                //adds image to the picturebox if open is clicked
                imgImage.Image = Image.FromFile(opf.FileName);
                //hides label after picture is added
                lblAddImage.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            rdBtnDept.Checked = false;
            rdBtnEmpID.Checked = false;
            txtSearch.Text = String.Empty;
            dataGridAtt.DataSource = null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter(sqlStates, con);
            da.Fill(dtView);
            Microsoft.Office.Interop.Excel.Application ExcApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wkB = ExcApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet wkS = null;
            Microsoft.Office.Interop.Excel.Range range;

            if (ExcApp == null)
            {
                MessageBox.Show("Application failed to start");
            }

            wkS = wkB.ActiveSheet;

            string value = "AttendanceSheet 1";
            if (InputBox.InputBoxCreate("New document", "New attendance sheet name:", ref value) == DialogResult.OK)
            {
                wkS.Name = value;
            }

            int rowIndex = 1;
            int columnIndex = 1;

            for (rowIndex = 1; rowIndex < dtView.Rows.Count + 1; rowIndex++)
            {
                for (columnIndex = 1; columnIndex <= dtView.Columns.Count; columnIndex++)
                {
                    if (rowIndex == 1)
                    {
                        wkS.Cells[rowIndex, columnIndex] = dtView.Columns[columnIndex - 1].ColumnName;
                        wkS.Cells[rowIndex + 1, columnIndex] = dtView.Rows[rowIndex - 1][columnIndex - 1].ToString();
                    }
                    else
                    {
                        wkS.Cells[rowIndex + 1, columnIndex] = dtView.Rows[rowIndex - 1][columnIndex - 1].ToString();
                    }
                }
            }

            range = wkS.Range[wkS.Cells[1, 1], wkS.Cells[dtView.Rows.Count + 1, dtView.Columns.Count]];
            range.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = range.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;
            ExcApp.Visible = true;
            //var headerRow = wkS.Rows[1];
            //headerRow.Style.

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                wkB.SaveAs(saveDialog.FileName);
                MessageBox.Show("Export Successful");
            }

            ExcApp.Quit();
            wkB = null;
            ExcApp = null;
        }

        private void btnGenerateDB_Click(object sender, EventArgs e)
        {
           
        }
    }
}
