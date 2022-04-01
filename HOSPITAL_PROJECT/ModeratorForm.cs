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
    public partial class ModeratorForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");
        public ModeratorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide();
            AddMemberForm f = new AddMemberForm();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hide();
            RemoveStaffForm f = new RemoveStaffForm();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update login set [worked hours]= 0";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Reset Complete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelloForm f = new HelloForm();
            f.Show();
            this.Hide();
            
        }
    }
}
