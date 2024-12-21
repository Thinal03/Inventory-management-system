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
    public partial class Sup_Oders : Form
    {
        public Sup_Oders()
        {
            InitializeComponent();
        }

        private void Sup_Oders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techFixDBDataSet_Sup1.tblsupoder' table. You can move, or remove it, as needed.
            this.tblsupoderTableAdapter.Fill(this.techFixDBDataSet_Sup1.tblsupoder);
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
            textBox6.Enabled = Value;
            textBox7.Enabled = Value;
            textBox8.Enabled = Value;
            textBox9.Enabled = Value;
            textBox10.Enabled = Value;
            textBox11.Enabled = Value;
            textBox12.Enabled = Value;
            textBox13.Enabled = Value;
            textBox14.Enabled = Value;
            textBox15.Enabled = Value;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            SupplierHomePage Sform = new SupplierHomePage();
            Sform.Show();
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                techFixDBDataSet_Sup1.tblsupoder.AddtblsupoderRow(techFixDBDataSet_Sup1.tblsupoder.NewtblsupoderRow());
                tblsupoderBindingSource.MoveLast();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet_Sup1.tblsupoder.RejectChanges();
            }
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
                tblsupoderBindingSource.EndEdit();
                tblsupoderTableAdapter.Update(techFixDBDataSet_Sup1.tblsupoder);
                dgv_supoder.Refresh();
                textBox1.Focus();
                MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                techFixDBDataSet_Sup1.tblsupoder.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this recorde?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tblsupoderBindingSource.RemoveCurrent();
            }
        }
    }
}
