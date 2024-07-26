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
using System.Configuration;

namespace CollegeManagementSystem
{
    public partial class NewAdmission : Form
    {
        public NewAdmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string gender = string.Empty;
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked == true)
                {
                    gender = "Female";
                }
                String sq1 = "INSERT INTO student(name,mother,gender,cast,mobile,email,dob,standard,medium,privious_school,year,address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + gender + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + textBox7.Text + "')";
                SqlCommand cmd = new SqlCommand(sq1, con);
                cmd.ExecuteNonQuery();
                String sql1 = "Select max(std_id) from student";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader dr;
                dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Dear Student, Your Data Inserted Successfully.. ");
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
