using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AddMemberForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            
            if (checkBox2.Checked)
                textBox2.Enabled = false;
            else
                textBox2.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            if (checkBox3.Checked)
                textBox2.Enabled = false;
            else
                textBox2.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox3.Checked = false;
            checkBox2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (textBox1.Text == "" || textBox3.Text == "")
                {
                    throw new ArgumentNullException();
                }
                else if (checkBox1.Checked == true)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into  login (email,password,[Doctor Speciality],Name,[Worked Hours],[Days Since Last Vacation]) VALUES( 'Doctor" + textBox3.Text + "@kindnesshospital.com','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + 0 + "','" + 0 + "')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Close();
                    MessageBox.Show("Member Added Successfully");
                    button1.Enabled = false;
                }
                else if (checkBox2.Checked == true)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into  login (email,password,[Worked Hours],[Days Since Last Vacation],Name) VALUES( 'Nurse" + textBox3.Text + "@kindnesshospital.com','" + textBox1.Text + "','" + 0 + "','" + 0 + "','" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Close();
                    MessageBox.Show("Member Added Successfully");
                    button1.Enabled = false;

                }
                else if (checkBox3.Checked == true)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into  login (email,password,[Worked Hours],[Days Since Last Vacation],Name) VALUES( 'Tech" + textBox3.Text + "@kindnesshospital.com','" + textBox1.Text + "','" + 0 + "','" + 0 + "','" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //da.Fill(dt);
                    con.Close();
                    MessageBox.Show("Member Added Successfully");
                    button1.Enabled = false;
                }

            }
            catch(ArgumentNullException)
            {
                label6.Text = "*Fill in fields";
            }


        }
    }
}
