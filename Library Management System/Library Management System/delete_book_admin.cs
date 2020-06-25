using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class delete_book_admin : Form
    {
        SqlConnection con = new Database().GetConnection();
        public delete_book_admin()
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
                string Query = "Select * from library_books where isbn_no = " + int.Parse(editBookDBTbxBookID.Text);
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                table.DataSource = ds.Tables[0];
                table.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int ibn = int.Parse(editBookDBTbxBookID.Text);
                string Query = "Delete from library_books where isbn_no = " + (ibn);

                SqlCommand Delete = new SqlCommand(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                Delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Deleted Successfully");

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

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

