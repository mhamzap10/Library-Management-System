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
    public partial class add_member : Form
    {
        SqlConnection con = new Database().GetConnection();
        
        public void clearFields()
        {
            member_ID_txtbox.Text = string.Empty;
            name_txtbox.Text = string.Empty;
            combo_dep.Text = string.Empty;
            combo_des.Text = string.Empty;
            EnS_no_txtbox.Text = string.Empty;
        }
        public add_member()
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

               string Query = "insert into library_members values (" + (int.Parse(member_ID_txtbox.Text)) + ", '" + name_txtbox.Text + "','" + combo_dep.SelectedItem+ "', '" + combo_des.SelectedItem + "'," + int.Parse(EnS_no_txtbox.Text) + ")";
                SqlCommand Insert = new SqlCommand(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                Insert.CommandType = CommandType.Text;
                Insert.BeginExecuteNonQuery();
                con.Close();
                MessageBox.Show("Member successfully added.");
                clearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("The Member is already Registered in youir library with following ISBN # ( " + Convert.ToString(member_ID_txtbox) + " )." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_book_admin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
