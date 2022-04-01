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
    public partial class Forgetpasswordform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");
        public Forgetpasswordform()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ForgotEmail.Text == "")
                {
                    throw new ArgumentNullException();

                }
                else if (ForgotEmail.Text.Contains('@') && ForgotEmail.Text.Contains(".com"))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from login where email='" + ForgotEmail.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Email sent successfully!");
                        button1.Enabled = false;
                        con.Close();
                    }
 
                    else
                    {
                        throw new IncorrectMail(); 
                    }

                }
                else if (!(ForgotEmail.Text.Contains('@') && ForgotEmail.Text.Contains(".com")))
                {
                    throw new InvalidEmail();
                    
                }
            }catch(ArgumentNullException)
            {
                label4.Text = "*Please Fill Field";
            }
            catch(IncorrectMail)
            {
                label4.Text = "*Incorrect Email";
                con.Close();
            }
            catch(InvalidEmail)
            {
                label4.Text = "*Enter a vaild E-mail";
            }
            
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projtestDataSet);

        }

        private void Forgetpasswordform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projtestDataSet.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.projtestDataSet.Login);

        }

        private void loginDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
