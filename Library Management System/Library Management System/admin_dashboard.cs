using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class admin_dashboard : Form
    {
        string label_text = "";
        admin_Login_Form alf = new admin_Login_Form();
        public admin_dashboard(string s)
        {
            InitializeComponent();
            account_holder.Text = s.ToString();

        }
        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            account_holder.Text = label_text.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_books_admin sba = new show_books_admin();
            sba.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_issued_book siba = new show_issued_book();
            siba.Show();
        }

        private void admin_exit_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void add_book_Click(object sender, EventArgs e)
        {
            add_book_admin aba = new add_book_admin();
            aba.Show();
        }

        private void delete_book_Click(object sender, EventArgs e)
        {
            delete_book_admin dba = new delete_book_admin();
            dba.Show();
        }

        private void show_record_members_Click(object sender, EventArgs e)
        {
            show_members_admin sba = new show_members_admin();
            sba.Show();
        }

        private void Edit_Credentials_Click(object sender, EventArgs e)
        {
            add_member am = new add_member();
            am.Show();
        }
    }
}
