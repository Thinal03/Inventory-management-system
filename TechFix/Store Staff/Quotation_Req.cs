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
    public partial class Quotation_Req : Form
    {
        public Quotation_Req()
        {
            InitializeComponent();
        }

        private void wel_supp_Click(object sender, EventArgs e)
        {

        }

        private void Quotation_Req_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techFixDBDataset_Sup.tblsupquotation' table. You can move, or remove it, as needed.
            this.tblsupquotationTableAdapter.Fill(this.techFixDBDataset_Sup.tblsupquotation);
            // TODO: This line of code loads data into the 'techFixDBDataSet1.tblquotations' table. You can move, or remove it, as needed.
            this.tblquotationsTableAdapter.Fill(this.techFixDBDataSet1.tblquotations);
            Edit(false);
        }

        private void Edit(bool value)
        {
            textBox1.Enabled = value;
            textBox2.Enabled = value;
            textBox3.Enabled = value;
            textBox4.Enabled = value;
           
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                techFixDBDataSet1.tblquotations.AddtblquotationsRow(techFixDBDataSet1.tblquotations.NewtblquotationsRow());
                tblquotationsBindingSource.MoveLast();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet1.tbllog.RejectChanges();
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
            tblquotationsBindingSource.ResetBindings(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblquotationsBindingSource.EndEdit();
                tblquotationsTableAdapter.Update(techFixDBDataSet1.tblquotations);
                dgv_quotations.Refresh();
                textBox1.Focus();
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet1.tbllog.RejectChanges();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to delete this recorde?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tblquotationsBindingSource.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffHomePage sForm = new StaffHomePage();
            sForm.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
