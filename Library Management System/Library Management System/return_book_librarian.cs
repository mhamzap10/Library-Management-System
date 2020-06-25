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
    public partial class return_book_librarian : Form
    {
        SqlConnection con = new Database().GetConnection();
        public return_book_librarian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void return_book_librarian_Load(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "Update issued_books set Return_Date = GetDate(),Return_Time = Convert(Time,GetDate()) where Member_id = '" + user_ID_txtbox + "' and Book_id = '" + book_ID_txtbox + "'";
                SqlCommand Update = new SqlCommand(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                Update.CommandType = CommandType.Text;
                SqlCommand stp = new SqlCommand("Return_Book", con);
                stp.CommandType = CommandType.StoredProcedure;
                stp.ExecuteNonQuery();
                Update.BeginExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Returend Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Book Id or Member Id.." + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "select library_books.isbn_no [Book ID] , library_books.title [Book Title] , library_members.LM_ID [Member ID], library_members.full_name [Member Name] , issued_books.Issue_Date [Issue Date] from library_books left join issued_books on library_books.isbn_no = Issued_Books.Book_id right join library_members on issued_books.Member_id = library_members.LM_ID where library_books.isbn_no = " + int.Parse(search_book_ID_txtbox.Text);
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                issued_books_GV.DataSource = ds.Tables[0];
                search_book_ID_txtbox.Text = "";
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
