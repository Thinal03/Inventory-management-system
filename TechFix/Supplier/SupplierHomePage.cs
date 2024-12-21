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

namespace TechFix.Supplier
{
    public partial class SupplierHomePage : Form
    {
        public SupplierHomePage()
        {
            InitializeComponent();
        }

        private void SupplierHomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Supp_Quotations Sform = new Supp_Quotations();
            Sform.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Supp_close_Click(object sender, EventArgs e)
        {
            LoginForm Lform = new LoginForm();
            Lform.Show();
            this.Hide();
        }

        private void supp_prod_Click(object sender, EventArgs e)
        {
            Sup_Products sForm = new Sup_Products();
            sForm.Show();
            this.Hide();
        }

        private void sup_oder_Click(object sender, EventArgs e)
        {
            Sup_Oders sForm = new Sup_Oders();
            sForm.Show();
            this.Hide();
        }
    }
}
