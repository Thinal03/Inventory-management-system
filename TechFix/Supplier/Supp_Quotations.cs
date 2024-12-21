using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFix.Supplier
{
    public partial class Supp_Quotations : Form
    {
        public Supp_Quotations()
        {
            InitializeComponent();
        }

        private void Supp_Quotations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techFixDBDataset_Sup.tblsupquotation' table. You can move, or remove it, as needed.
            this.tblsupquotationTableAdapter.Fill(this.techFixDBDataset_Sup.tblsupquotation);
            this.tblquotationsTableAdapter.Fill(this.techFixDBDataSet1.tblquotations);
            Edit(false);
        }

        private void Edit(bool value)
        {
            textBox1.Enabled = value;
            textBox2.Enabled = value;
            textBox3.Enabled = value;
            textBox4.Enabled = value;
            textBox5.Enabled = value;
            textBox6.Enabled = value;
            textBox7.Enabled = value;
            textBox8.Enabled = value;
            textBox9.Enabled = value;
            textBox10.Enabled = value;
            textBox11.Enabled = value;
            textBox12.Enabled = value;
            textBox13.Enabled = value;
            textBox14.Enabled = value;
            textBox15.Enabled = value;
        }

        private void wel_supp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblsupquotationBindingSource.EndEdit();
                tblsupquotationTableAdapter.Update(techFixDBDataset_Sup.tblsupquotation);
                dgv_supquotation.Refresh();
                textBox1.Focus();
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataset_Sup.tblsupquotation.RejectChanges();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SupplierHomePage sForm = new SupplierHomePage();
            sForm.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                techFixDBDataset_Sup.tblsupquotation.AddtblsupquotationRow(techFixDBDataset_Sup.tblsupquotation.NewtblsupquotationRow());
                tblsupquotationBindingSource.MoveLast();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataset_Sup.tblsupquotation.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            textBox1.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this recorde?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tblsupquotationBindingSource.RemoveCurrent();
            }
        }
    }
}
