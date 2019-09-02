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
using MaterialSkin;


namespace System
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        //string conInfo = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=attendanceDB;Integrated Security=True";
        //string conInfo = "Data Source=DESKTOP-CA7ENAM;Initial Catalog=attendanceDB;User ID=sa;Password=2018";
        //string conInfo = "Data Source=(localdb)\\Projects;Initial Catalog=attendanceDB;Integrated Security=True;";
        string conInfo = "Data Source=DTRT-SVR\\Projects;Initial Catalog=attendanceDB;Integrated Security=True;";
        public Login()
        {
            InitializeComponent();
            txtPassword.MaxLength = 14;
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.BlueGrey100, Primary.DeepOrange500, Accent.Blue700, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlstatement = "SELECT usernameA, passwordA FROM Credentiality WHERE usernameA = @user and passwordA =@pass";
            con = new SqlConnection(conInfo);
            cmd = new SqlCommand(sqlstatement, con);
            da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            //int execResponse = Convert.ToInt32(cmd.ExecuteScalar());

            if (cmd.ExecuteScalar() != null)
            {
                this.Hide();
                mainForm main = new mainForm();
                main.Show();
               
            }
            else
            {
                lblMessage.Text = "Wrong credentials, please try again";
            }
            con.Close();
            con.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
