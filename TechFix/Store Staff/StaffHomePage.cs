using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechFix.User_authtication;
using TechFix.Supplier;

namespace TechFix.Store_Staff
{
    public partial class StaffHomePage : Form
    {
        public StaffHomePage()
        {
            InitializeComponent();
        }

        private void reg_close_Click(object sender, EventArgs e)
        {
            LoginForm sForm = new LoginForm();
            sForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Add_Supplier sForm = new Add_Supplier();
            sForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Store_Qote_Click(object sender, EventArgs e)
        {
            Quotation_Req sForm = new Quotation_Req();
            sForm.Show();
            this.Hide();
        }

        private void Store_oder_Click(object sender, EventArgs e)
        {
            Order_TechFix sForm = new Order_TechFix();
            sForm.Show();
            this.Hide();
        }

        private void Store_prod_Click(object sender, EventArgs e)
        {
            Sup_Products Sform = new Sup_Products();
            Sform.Show();
            this.Hide();
        }
    }
}
