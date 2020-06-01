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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        SqlConnection con = Main.cnn;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            textBox1.Text = Main.str;
            SqlCommand cmd = new SqlCommand("up_PassStationInfo_Select", con); //存储过程名
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", DbType.String));
            cmd.Parameters["@ID"].Value = int.Parse(textBox1.Text); //储存参数输入
            cmd.ExecuteNonQuery();
            SqlDataAdapter myda = new SqlDataAdapter();
            myda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            myda.Fill(ds,"p");
            textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
            // dataGridView1.DataSource = ds.Tables["p"];
            /*cmd.ExecuteNonQuery();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = cmd;
            DataSet MyDataSet = new DataSet();
            DataAdapter.Fill(MyDataSet, "table");
            //this.textBox3.Text = cmd.Parameters["Train"].Value.ToString();
            */
        }
    }
}
