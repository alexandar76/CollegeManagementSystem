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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            try
            {
                string str = "INSERT INTO fees VALUES('"+textBox1.Text+"','"+textBox2.Text+"')";

                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Your Fees Submitted..");
                    this.Hide();
                    Fees obj2 = new Fees();
                    obj2.ShowDialog();
                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            if (textBox1.Text != "")
            {
                if (textBox1.TextLength == 2)
                {
                    try
                    {
                        string getCust = "SELECT name, standard, medium FROM student WHERE std_id =" + Convert.ToInt32(textBox1.Text) + ";";

                        SqlCommand cmd = new SqlCommand(getCust, con);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            label9.Text = dr.GetValue(0).ToString();
                            label6.Text = dr.GetValue(1).ToString();
                            label7.Text = dr.GetValue(2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Sorry '" + textBox1.Text + "' This Registration Id is Invalid, Please Insert Correct Id");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }

                    }
                    catch (SqlException excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                    con.Close();
                }
            }
        }
    }
}
