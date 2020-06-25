using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class show_members_admin : Form
    {
        SqlConnection con = new Database().GetConnection();
        public show_members_admin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "select LM_ID [Member ID], full_name [Member Name] , department [Department], designation [Designation] from library_members where LM_ID = " + int.Parse(search_member_txtbox.Text);
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                member_show_GV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_members_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "select LM_ID [Member ID], full_name [Member Name] , department [Department], designation [Designation] from library_members";
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                member_show_GV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
