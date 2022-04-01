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
    public partial class NurseForm : Form
    {
        DateTime t = DateTime.Now;
        DataTable dt1 = new DataTable();
        string mail;
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");
        public NurseForm(string x)
        {
            mail = x;
            InitializeComponent();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from Login where email = '" + mail + "' ";

            string y = (string)cmd.ExecuteScalar();
            cmd.CommandText = "select * from NurseFormTable where [Nurse name] = '" + y + "' ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            nurseFormTableDataGridView.DataSource = dt1;
            con.Close();
        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projtestDataSet.NurseFormTable' table. You can move, or remove it, as needed.
            this.nurseFormTableTableAdapter.Fill(this.projtestDataSet.NurseFormTable);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Worked Hours] from Login where email = '" + mail + "' ";

            double y = (int)cmd.ExecuteScalar();
            Nurse x = new Nurse();
            con.Close();

            MessageBox.Show(Convert.ToString(x.CalculateSalary(y)));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Days Since Last Vacation] from Login where email =  '" + mail + "' ";

            double y = (int)cmd.ExecuteScalar();
            Nurse x = new Nurse();

            MessageBox.Show(Convert.ToString(x.CalculateVacationDays(y)));
            con.Close();
        }

        private void nurseFormTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nurseFormTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projtestDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime t2 = DateTime.Now;
            double m = 0;
            m += Convert.ToDouble((t2 - t).Hours);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Login Set [Worked Hours] = [Worked Hours] + " + m + " where email = '" + mail + "'";
            cmd.ExecuteNonQuery();



            con.Close();
            this.Hide();

            HelloForm f = new HelloForm();
            f.Show();
        }
    }
}
