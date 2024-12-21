using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFix.Store_Staff
{
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void Add_Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.techfixData.tbllog);
            Edit(false);
        }

        private void Edit(bool Value)
        {
            textBox1.Enabled = Value;
            textBox2.Enabled = Value;
            comboBox1.Enabled = Value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                techfixData.tbllog.AddtbllogRow(techfixData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                textBox1.Focus();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techfixData.tbllog.RejectChanges();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            textBox1.Focus();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(techfixData.tbllog);
                dgv_user.Refresh();
                textBox1.Focus();
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techfixData.tbllog.RejectChanges();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this recorde?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffHomePage sform = new StaffHomePage();
            sform.Show();
            this.Hide();
        }
    }
}
