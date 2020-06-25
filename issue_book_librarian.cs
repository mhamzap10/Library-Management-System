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
    public partial class issue_book_librarian : Form
    {
        SqlConnection con = new Database().GetConnection();
        public issue_book_librarian()
        {
            InitializeComponent();
        }

        private void issue_book_librarian_Load(object sender, EventArgs e)
        {

        }

        private void admIssueBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issue_btn_Click(object sender, EventArgs e)
        {

            try
            {

                string Query = "Insert into issued_books (Member_id, Book_id,Issue_Date,Issue_Time) values (" + int.Parse(user_ID_txtbox.Text) + "," + int.Parse(book_ID_txtbox.Text) + ",GetDate(),CONVERT(Time,GetDate()))";
                SqlCommand Insert = new SqlCommand(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                Insert.CommandType = CommandType.Text;
                Insert.BeginExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Issued Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Book is already isued.." + ex);
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
                string Query = "select library_books.isbn_no[Book ISBN #],library_books.title [Book Title], library_books.book_publisher [Book Publishers],library_books._book_author [Book Author] from library_books inner join Issued_Books_Record on  library_books.isbn_no <> Issued_Books_Record.Book_id where library_books.isbn_no = " + int.Parse(search_txtbox.Text);
                SqlDataAdapter Search = new SqlDataAdapter(Query, con);
                if (con.State == ConnectionState.Open)
                    con.Close();
                DataSet ds = new DataSet();
                con.Open();
                Search.Fill(ds);
                con.Close();
                if (ds == null)
                    MessageBox.Show("No Such Book Exist");
                show_non_issued_books_GV.DataSource = ds.Tables[0];
                search_txtbox.Text = "";
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
