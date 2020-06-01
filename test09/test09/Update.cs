using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test09
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        SqlConnection con = Main.cnn;
        SqlCommand cmd = null;
        private void Update_Load(object sender, EventArgs e)
        {
            textBox1.Text = Main.str;
            string str1 = "select Train from dbo.TrainInfo";
            DataSet ds = new DataSet(); //数据集
            SqlDataAdapter sda = new SqlDataAdapter(str1, con);
            sda.Fill(ds, "列车");
            comboBox1.DisplayMember = "Train"; //这个是下拉框dao需要显示的内容内
            //comboBox1.ValueMember = "TrainType";  //这个是选中后，对应容返回的值
            comboBox1.DataSource = ds.Tables["列车"];

            string str2 = "select * from dbo.StationInfo";
            sda = new SqlDataAdapter(str2, con);
            sda.Fill(ds,"站台");
            comboBox2.DisplayMember = "StationName";
            comboBox2.DataSource = ds.Tables["站台"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text,
              "^([01][0-9]|2[0-3]):([0-5][0-9])$"
            ))
            {
                textBox2.Text = "00:00";
                label6.Visible = true;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text,
              "^([01][0-9]|2[0-3]):([0-5][0-9])$"
            ))
            {
                textBox3.Text = "00:00";
                label6.Visible = true;
                return;
            }
            string str1 = comboBox1.Text;
            string str2 = comboBox2.Text;
            string str3 = textBox2.Text;
            string str4 = textBox3.Text;
            string str5 = textBox1.Text;
            String sql = String.Format("UPDATE dbo.PassStationInfo SET Train = '{0}',PassStationID = '{1}',ArriveTime = '{2}',LeaveTime = '{3}' WHERE ID = '{4}'", str1, str2, str3, str4, str5);
            //String sql = "insert into dbo.PassStationInfo(Train,PassStationID,ArriveTime,LeaveTime)values('G1011','1011','10:00','11:00')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            label6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
