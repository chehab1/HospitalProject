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

namespace yara_finalproj
{
    public partial class PartTimeDoctor : Form
    {
        
        
     
        DataTable dt1 = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P3NEORE;Initial Catalog=projtest;Integrated Security=True");
        public PartTimeDoctor(string x)
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DoctorFormTable1 where [Doctor Speciality] = 'Opthalmologist'";
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
          

            con.Close();
        }



        private void PartTimeDoctor_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "[First Name]";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = docD.CalculateSalary(123);
            MessageBox.Show(Convert.ToString(temp));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
            HelloForm f = new HelloForm();
            f.Show();
        }
    }
}
