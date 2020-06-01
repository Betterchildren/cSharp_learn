using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace test09
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        SqlConnection con = Main.cnn;
        SqlCommand cmd = null;
        private void Add_Load(object sender, EventArgs e)
        {
            if(con.State== ConnectionState.Open)
            {
                ;
            }
            else
            {
                con.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            string str3 = textBox3.Text;
            string str4 = textBox4.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text,
              "^([01][0-9]|2[0-3]):([0-5][0-9])$"
            ))
            {
                textBox3.Text = "00:00";
                label7.Visible = true;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text,
              "^([01][0-9]|2[0-3]):([0-5][0-9])$"
            ))
            {
                textBox4.Text = "00:00";
                label7.Visible = true;
                return;
            }
            
            //string sql = "insert into dbo.PassStationInfo(ID,Train,PassStationID,ArriveTime,LeaveTime)values('{0}','{1}')", aa, bb);
            String sql = String.Format("insert into dbo.PassStationInfo(Train,PassStationID,ArriveTime,LeaveTime)values('{0}','{1}','{2}','{3}')", str1, str2,str3,str4);
            //String sql = "insert into dbo.PassStationInfo(Train,PassStationID,ArriveTime,LeaveTime)values('G1011','1011','10:00','11:00')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            label5.Visible = true;
            label7.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
