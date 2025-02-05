﻿using System;
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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            try
            {
                string str = "INSERT INTO employee(username,full_name,password,gender,email,mobile,address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(emp_id) from employee; ";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Dear Employee, your id is '" + dr.GetInt32(0) + "'. You are registered successfully..");
                    this.Hide();
                    Home obj2 = new Home();
                    obj2.ShowDialog();
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
