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
    public partial class FullTimeDoctorForn : Form
    {
        
      
        string mail;
        DataTable dt1 = new DataTable();
        DateTime t;
        SqlConnection con = new SqlConnection("Data Source=CHEHAB\\SQLEXPRESS;Initial Catalog=projtest;Integrated Security=True");
        public FullTimeDoctorForn(string x)
        {
            mail = x;

            InitializeComponent();
            t = DateTime.Now;

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [Doctor Speciality] from Login where email = '" + mail + "' ";
               
                string y = (string)cmd.ExecuteScalar();
                cmd.CommandText= "select * from DoctorFormTable1 where [Doctor Speciality] = '" + y + "' ";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt1);
                

                con.Close();
            
        }


        private void doctorFormTable1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorFormTable1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projtestDataSet1);

        }

        private void FullTimeDoctorForn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projtestDataSet1.DoctorFormTable1' table. You can move, or remove it, as needed.
            //this.doctorFormTable1TableAdapter.Fill(dt1);
            doctorFormTable1ComboBox.DataSource = dt1;
            doctorFormTable1ComboBox.DisplayMember = "[First Name]";


        }




        private void doctorFormTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       internal DataTable dt = new DataTable();
        int flag = 0;
        private void doctorFormTable1ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if (flag == 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from DoctorFormTable1 where [First Name] = '" + doctorFormTable1ComboBox.Text + "'";
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                

                con.Close();
                flag++;
            }
            else
            {
                dt.Rows.RemoveAt(0);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from DoctorFormTable1 where [First Name] = '" + doctorFormTable1ComboBox.Text + "'";
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
               
                con.Close();
            }
            


        }
        
        
        

        private void button5_Click(object sender, EventArgs e)
        {
            PatientData f = new PatientData(dt);
            f.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Worked Hours] from Login where email = '" + mail + "' ";

           double y = (int)cmd.ExecuteScalar();
            Doctor x = new Doctor();
            con.Close();
    
            MessageBox.Show(Convert.ToString(x.CalculateSalary(y)));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Days Since Last Vacation] from Login where email = '" + mail + "' ";

            double y = (int)cmd.ExecuteScalar();
            Doctor x = new Doctor();

            MessageBox.Show(Convert.ToString(x.CalculateVacationDays(y)));
            con.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
                DateTime t2 = DateTime.Now;
                double m=0;
                m+= Convert.ToDouble((t2 - t).Hours);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Login Set [Worked Hours] = [Worked Hours] + " + m +" where email = '" + mail + "'";
                cmd.ExecuteNonQuery();

                 con.Close();
                 this.Hide();

                 HelloForm f = new HelloForm();
                  f.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SurgeryForm f = new SurgeryForm();
            f.ShowDialog();
        }
    }
}
