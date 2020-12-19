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
using MaterialSkin;
using System.Text;
using System.Net;


namespace System
{
    public partial class Dashoboard : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        string conInfo = "Data Source=DESKTOP-CA7ENAM;Initial Catalog=attendanceDB;User ID=sa;Password=2018";
        //string conInfo = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=attendanceDB;Integrated Security=True;";
        //string conInfo = "Data Source=(localdb)\\Projects;Initial Catalog=attendanceDB;Integrated Security=True;";
        //string conInfo = "Data Source=DTRT-SVR\\Projects;Initial Catalog=attendanceDB;Integrated Security=True;";

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public string host;

        public Dashoboard()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.BlueGrey100, Primary.DeepOrange500, Accent.Blue700, TextShade.WHITE);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOfficial_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(conInfo);
            DataSet dsb = new DataSet("AttendanceDB");
            DataTable dTableEmployee = new DataTable("Employee");
            DataTable dTablelastRecord = new DataTable("LastSignOUT");
            DataTable dTableAttendIN = new DataTable("LastAttendIN");
            DataTable dTableFirstAttendIn = new DataTable("AllAttendIN");
            // DataTable datAttendOUT = new DataTable();

            txtEmpID.MaxLength = 7;

            if (txtEmpID.TextLength == 7)
            {
                //try
                //{
                    string sqlSelectEmp = "Select * from employee where employee_ID = '" + txtEmpID.Text.Trim() + "'";
                    SqlDataAdapter dapEmp = new SqlDataAdapter(sqlSelectEmp, con);
                    dapEmp.Fill(dTableEmployee);

                    
                    string lastSigning = "SELECT MAX(ATTENDIN_ID) AS LASTONE FROM ATTENDOUT WHERE ATTENDIN_ID IN (SELECT MAX(ATTENDIN_ID) FROM ATTENDIN WHERE EMPLOYEE_ID = '"+txtEmpID.Text+"')";

                    //string lastSig = "SELECT TOP 1 * FROM ATTENDIN JOIN ATTENDOUT ON ATTENDIN.ATTENDIN_ID = ATTENDOUT.ATTENDIN_ID " +
                    //        "WHERE ATTENDIN.ATTENDIN_ID IN ATTENDOUT.ATTENDIN_ID = ATTENDIN.ATTENDIN_ID AND EMPLOYEE_ID = '" + txtEmpID.Text + "' ORDER BY ATTENDIN.ATTENDIN_ID DESC";
                    SqlDataAdapter dapLastSign = new SqlDataAdapter(lastSigning, con);
                    dapLastSign.Fill(dTablelastRecord);

                    string sqlGetAttInID = "SELECT TOP 1 * FROM ATTENDIN WHERE EMPLOYEE_ID = '" + txtEmpID.Text + "' ORDER BY ATTENDIN_ID DESC";
                    SqlDataAdapter dapLastRec = new SqlDataAdapter(sqlGetAttInID, con);
                    dapLastRec.Fill(dTableAttendIN);

                    string AttendnoRecord = "SELECT * FROM ATTENDIN WHERE EMPLOYEE_ID = '" + txtEmpID.Text + "'";
                    SqlDataAdapter dapNoAttendIN = new SqlDataAdapter(AttendnoRecord, con);
                    dapNoAttendIN.Fill(dTableFirstAttendIn);

                    dsb.Tables.Add(dTableEmployee);
                    dsb.Tables.Add(dTablelastRecord);
                    dsb.Tables.Add(dTableAttendIN);
                    dsb.Tables.Add(dTableFirstAttendIn);
 
                //}
                //catch (SqlException)
                //{
                //    lblmessage.Text = "Database not available: \n Check connection ";

                //}

                if (dTableEmployee.Rows.Count == 0)
                {
                    lblmessage.Text = "Employee does not exist in the system";
                    var t = new Timer();
                    t.Interval = 1500;
                    lblmessage.ForeColor = Color.Red;
                    t.Tick += (s, x) =>
                    {
                        lblFullname.Text = String.Empty;
                        lblDateIN.Text = String.Empty;
                        lblTimeIN.Text = String.Empty;
                        lblDept.Text = String.Empty;
                        imgImage.Image = null;
                        txtEmpID.Text = String.Empty;
                        lblmessage.Text = String.Empty;
                        t.Stop();
                    };
                    t.Start();
                }
                else
                {
                    con = new SqlConnection(conInfo);
                    lblFullname.Text = dTableEmployee.Rows[0]["Firstname"].ToString() + " " + dTableEmployee.Rows[0]["Middlename"].ToString() + " " + dTableEmployee.Rows[0]["Lastname"];
                    //lblFullname.Text = dsb.Tables["Employee"].Rows[0]["Firstname"].ToString() + " " + dsb.Tables["Employee"].Rows[0]["Middlename"].ToString() + " " + dsb.Tables[0].Rows[0]["Lastname"].ToString();
                    lblDateIN.Text = DateTime.Today.ToString("dddd, dd MMMM yyyy");
                    // lblTimeIN.Text = DateTime.Now.TimeOfDay.ToString();
                    lblTimeIN.Text = DateTime.Now.ToString("hh:mm tt");
                    //lblDept.Text = dsb.Tables["Employee"].Rows[0]["Dept_name"].ToString();
                    lblDept.Text = dTableEmployee.Rows[0]["Dept_name"].ToString();
                    var t = new Timer();
                    t.Interval = 1500; // it will Tick in 3 seconds
                    t.Tick += (s, x) =>
                    {
                        lblFullname.Text = String.Empty;
                        lblDateIN.Text = String.Empty;
                        lblTimeIN.Text = String.Empty;
                        lblDept.Text = String.Empty;
                        imgImage.Image = null;
                        txtEmpID.Text = String.Empty;
                        lblmessage.Text = String.Empty;
                        t.Stop();
                    };
                    t.Start();

                    //var tClear = new Timer();
                    //tClear.Interval = 1000; // it will Tick in 3 seconds
                    //tClear.Tick += (s, e) =>
                    //{
                    //    tClear.Start();
                    //    lblDateIN.Text = String.Empty;
                    //    lblDept.Text = String.Empty;
                    //    lblFullname.Text = String.Empty;
                    //    lblTimeIN.Text = String.Empty;
                    //    lblmessage.Text = String.Empty;
                    //    txtEmpID.Text = String.Empty;
                    //    imgImage.Image = null;
                    //    tClear.Stop();
                    //};
                    Image img;
                    try
                    {
                        //img = byteToImage((byte[])dsb.Tables["Employee"].Rows[0]["Picture"]);
                        img = byteToImage((byte[])dTableEmployee.Rows[0]["Picture"]);
                        imgImage.Image = img;
                    }
                    catch (SystemException)
                    {
                        lblmessage.Text = "ERROR: Employee image unavailable";
                        lblmessage.ForeColor = Color.Red;
                        clearAll();
                    }



                    if (dTableFirstAttendIn.Rows.Count == 0)
                    {
                        string insertAttendIN = "INSERT INTO ATTENDIN(DATE_IN,TIME_IN,EMPLOYEE_ID,DATETIMEIN) VALUES(@DATE_IN,@TIME_IN,@EMPID,@DATETIMEIN)";
                        cmd = new SqlCommand(insertAttendIN, con);
                        cmd.Parameters.AddWithValue("@DATE_IN", DateTime.Today);
                        cmd.Parameters.AddWithValue("@TIME_IN", DateTime.Now.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@EMPID", txtEmpID.Text);
                        cmd.Parameters.AddWithValue("@DATETIMEIN", DateTime.Now);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblmessage.Text = "first one sign in ";
                        lblmessage.ForeColor = Color.Blue;
                        clearAll();
                    }
                    else
                    {
                        if (dTableAttendIN.Rows[0]["DateTimeIN"] != DBNull.Value)
                        {

                            DateTime current = DateTime.Now;
                            TimeSpan restriction = current.Subtract(Convert.ToDateTime((dTableAttendIN.Rows[0]["DateTimeIN"])));


                            if (dTablelastRecord.Rows[0]["LASTONE"] != DBNull.Value)
                            {
                                string insertAttendIN = "INSERT INTO ATTENDIN(DATE_IN,TIME_IN,EMPLOYEE_ID,DATETIMEIN) VALUES(@DATE_IN,@TIME_IN,@EMPID,@DATETIMEIN)";
                                cmd = new SqlCommand(insertAttendIN, con);
                                cmd.Parameters.AddWithValue("@DATE_IN", DateTime.Today);
                                cmd.Parameters.AddWithValue("@TIME_IN", DateTime.Now.ToString("HH:mm:ss"));
                                cmd.Parameters.AddWithValue("@EMPID", txtEmpID.Text);
                                cmd.Parameters.AddWithValue("@DATETIMEIN", DateTime.Now);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                lblmessage.Text = "Second one sign in";
                                lblmessage.ForeColor = Color.Green;
                                clearAll();
                            }
                            else if (restriction.TotalHours > 0.167 && dTablelastRecord.Rows[0]["LASTONE"] == DBNull.Value)
                            {
                                string insertAttendIN = "INSERT INTO ATTENDOUT VALUES(@ATTENDIN_ID,@DATE_OUT,@TIME_OUT,@DATETIMEOUT)";
                                cmd = new SqlCommand(insertAttendIN, con);
                                cmd.Parameters.AddWithValue("@ATTENDIN_ID", dTableAttendIN.Rows[0]["ATTENDIN_ID"]);
                                cmd.Parameters.AddWithValue("@DATE_OUT", DateTime.Today);
                                cmd.Parameters.AddWithValue("@TIME_OUT", DateTime.Now.ToString("HH:mm:ss"));
                                cmd.Parameters.AddWithValue("@DATETIMEOUT", DateTime.Now);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                lblmessage.Text = "last one Sign out successful";
                                lblmessage.ForeColor = Color.Green;
                            }
                            else
                            {
                                lblmessage.Text = "Sign Out Denied (10 minutes restriction)";
                                lblmessage.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            lblmessage.Text = "DateTime Error";
                            lblmessage.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        public Image byteToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void clearAll()
        {
            var tClear = new Timer();
            tClear.Interval = 1000; // it will Tick in 3 seconds
            tClear.Tick += (s, e) =>
            {
                tClear.Start();
                lblDateIN.Text = String.Empty;
                lblDept.Text = String.Empty;
                lblFullname.Text = String.Empty;
                lblTimeIN.Text = String.Empty;
                lblmessage.Text = String.Empty;
                txtEmpID.Text = String.Empty;
                imgImage.Image = null;
                tClear.Stop();
            };
        }

        private void Dashoboard_Load(object sender, EventArgs e)
        {
            this.host = Dns.GetHostName();//"IP Address/Hostname";
            //string IP = Dns.GetHostEntry(host).ToString();
            //InputBox.InputBoxCreate("Hostname", "Please specify server hostname:", ref this.host);
        }
    }
}



