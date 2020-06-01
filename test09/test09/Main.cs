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
    public partial class Main : Form
    {
        public static string str = "";
        public Main()
        {
            InitializeComponent();
        }
        //创建sqlConnectin
        public static SqlConnection cnn;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //实例化sqlConnection对象
            cnn = new SqlConnection("server=(local) ; database=csharp ; uid = sa ; pwd = 1");
            //打开sql
            cnn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建查询语句
            String find = "select * from dbo.PassStationInfo";
            //创建sqlDataAdapter
            SqlDataAdapter myDa = new SqlDataAdapter(find, cnn);
            //创建DataSet用来存储数据
            DataSet DS = new DataSet();
            //将数据填充到DataSet中
            myDa.Fill(DS, "name");
            //在DataGirdView中显示
            dataGridView1.DataSource = DS.Tables["name"];

            /*
            SqlCommand cmd = null;
            String sql = "insert into dbo.PassStationInfo(Train,PassStationID,ArriveTime,LeaveTime)values('G1011','1011','10:00','11:00')";
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            */
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            Update ud = new Update();
            ud.Show();
        }
        #region delete
        private void button4_Click(object sender, EventArgs e)
        {
            SqlTransaction tran = null;
            string id = textBox1.Text;
            if(cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            tran = cnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand("DELETE From [PassStationInfo] where [ID]=" + id, cnn, tran);
            cmd.ExecuteNonQuery();
            tran.Commit();
            button1_Click(null,null);
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            Delete sp = new Delete(); // 调用存储过程
            sp.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); //数据集
            string str2 = "select * from dbo.StationInfo";
            SqlDataAdapter sda = new SqlDataAdapter(str2, cnn);
            sda.Fill(ds, "站台");
            comboBox1.DisplayMember = "StationName";
            comboBox1.DataSource = ds.Tables["站台"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
