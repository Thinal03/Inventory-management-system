using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TechFix.Store_Staff;
using TechFix.Supplier;

namespace TechFix.User_authtication
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.TechFixDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT Role FROM tbllog WHERE Username = @username AND Password = @password";
                cmd = new SqlCommand(query, con);

                // Use parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@username", login_username.Text);
                cmd.Parameters.AddWithValue("@password", login_password.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["Role"].ToString();

                    if (role == " Staff_TechFix")
                    {
                        StaffHomePage sf = new StaffHomePage();
                        sf.Show();
                    }
                    else if (role == "Supplier")
                    {
                        SupplierHomePage sup = new SupplierHomePage();
                        sup.Show();
                    }

                    this.Hide();  // Hide login form after successful login
                }
                else
                {
                    MessageBox.Show("Please check your username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0'; // Show password
            }
            else
            {
                login_password.PasswordChar = '*'; // Hide password
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm sForm = new RegisterForm();
            sForm.Show();
            this.Hide(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techFixDataSet.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.techFixDataSet.tbllog);

        }
    }
}
