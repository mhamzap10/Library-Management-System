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
namespace Library_Management_System
{
    public partial class Login_Form : Form
    {
        SqlConnection con = new Database().GetConnection();
        int count = 0;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Library_Member_Login where LM_username ='" + username_txt.Text + "' and LM_password ='" + password.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if(count==0)
            {
                MessageBox.Show("Username or Password does not exists");
                username_txt.Clear();
                password.Clear();
                username_txt.Text = "USERNAME";
                password.Text = "PASSWORD";
            }
            else
            {
                this.Hide();
                member_dashboard mb = new member_dashboard();
                mb.Show();

            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
