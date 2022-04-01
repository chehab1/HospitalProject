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

namespace Hospital
{
    public partial class HelloForm : Form

    {
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");

        public HelloForm()
        {
            InitializeComponent();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projtestDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projtestDataSet.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.projtestDataSet.Login);

        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "" || passwordTextBox.Text == "")
            {
                label3.Text = "*";
                label4.Text = "*";
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from login where email='" + emailTextBox.Text + "'" + " and password = '" + passwordTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (emailTextBox.Text.Contains("Doctor") || emailTextBox.Text.Contains("doctor"))
                    {
                        FullTimeDoctorForn f3 = new FullTimeDoctorForn(emailTextBox.Text);
                        f3.Show();
                    }
                    else if (emailTextBox.Text.Contains("Nurse") || emailTextBox.Text.Contains("nurse"))
                    {

                        NurseForm f3 = new NurseForm(emailTextBox.Text);
                        f3.ShowDialog();

                    }
                    else if (emailTextBox.Text.Contains("Tech") || emailTextBox.Text.Contains("tech"))
                    {


                        TechForm f3 = new TechForm(emailTextBox.Text);
                        f3.ShowDialog();

                    }
                    else if (emailTextBox.Text.Contains("Moderator") || emailTextBox.Text.Contains("moderator"))
                    {
                        ModeratorForm f = new ModeratorForm();
                        f.Show();
                    }
                    con.Close();
                    this.Hide();
                }
                else
                {
                    label1.Text = "*Login Failed";
                    label3.Text = "";
                    label4.Text = "";
                    con.Close();
                }

            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }

        }

        private void frgtntn_Click_1(object sender, EventArgs e)
        {

            Forgetpasswordform f2 = new Forgetpasswordform();
            f2.ShowDialog();
        }
    }
}
    

