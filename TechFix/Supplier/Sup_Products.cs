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
    public partial class Sup_Products : Form
    {
        public Sup_Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sup_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techFixDBDataSet.tblproduct' table. You can move, or remove it, as needed.
            this.tblproductTableAdapter.Fill(this.techFixDBDataSet.tblproduct);
            Edit(false);
        }

        private void Edit(bool value)
        {
            textbox1.Enabled = value;
            textBox2.Enabled = value;
            comboBox1.Enabled = value;
            textBox4.Enabled = value;
            textBox5.Enabled = value;
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);

                // Create a new row
                var newRow = techFixDBDataSet.tblproduct.NewtblproductRow();

                // Generate a new ID with the "Pd_" prefix and a timestamp
                string newProductId = "00";
                newRow["id"] = newProductId;

                techFixDBDataSet.tblproduct.AddtblproductRow(newRow);
                tblproductBindingSource.MoveLast();
                textbox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet.tblproduct.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            textbox1.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tblproductBindingSource.ResetBindings(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblproductBindingSource.EndEdit();
                tblproductTableAdapter.Update(techFixDBDataSet.tblproduct);
                dgv_product.Refresh();
                textbox1.Focus();
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet.tblproduct.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this recorde?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tblproductBindingSource.RemoveCurrent();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SupplierHomePage sForm = new SupplierHomePage();
            sForm.Show();
            this.Hide();
        }
    }
}
