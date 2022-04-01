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
    public partial class SurgeryForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");
        public SurgeryForm()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || comboBox2.Text == "")
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    MessageBox.Show("Request Sent Successfully, Awaiting Confirmation");
                    button1.Enabled = false;
                }
            }
            catch(ArgumentNullException)
            {
                label4.Text = "*";
                label5.Text = "*";
            }
        }
    }
}
