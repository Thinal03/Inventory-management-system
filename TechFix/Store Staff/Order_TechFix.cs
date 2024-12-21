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
    public partial class Order_TechFix : Form
    {
        public Order_TechFix()
        {
            InitializeComponent();
        }

        private void Order_TechFix_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techFixDBDataSet2.tblorder' table. You can move, or remove it, as needed.
            this.tblorderTableAdapter.Fill(this.techFixDBDataSet2.tblorder);
            Edit(false);
        }

        private void Edit(bool Value)
        {
            textBox1.Enabled = Value;
            textBox2.Enabled = Value;
            textBox3.Enabled = Value;
            textBox4.Enabled = Value;
            textBox5.Enabled = Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffHomePage sForm = new StaffHomePage();
            sForm.Show();
            this.Hide();
        }

        private void Quotation_id_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                techFixDBDataSet2.tblorder.AddtblorderRow(techFixDBDataSet2.tblorder.NewtblorderRow());
                tblorderBindingSource.MoveLast();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet2.tblorder.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            textBox1.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tblorderBindingSource.ResetBindings(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblorderBindingSource.EndEdit();
                tblorderTableAdapter.Update(techFixDBDataSet2.tblorder);
                dgv_orders.Refresh();
                textBox1.Focus();
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet2.tblorder.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to delete this recorde?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tblorderBindingSource.RemoveCurrent();
            }
        }
    }
}
