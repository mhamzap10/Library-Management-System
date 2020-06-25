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
    public partial class member_dashboard : Form
    {
        public member_dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            issue_book_librarian ibl = new issue_book_librarian();
            ibl.Show();
        }

        private void admin_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            return_book_librarian rbl = new return_book_librarian();
            rbl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_issued_book sib = new show_issued_book();
            sib.Show();
        }
    }
}
