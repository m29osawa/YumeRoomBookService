using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 予約データを取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            //DataSource for DataGrid Init
            dataSet1 = new DataSet();
            textBox1.Clear();
            textBox1.Refresh();

            using (ServiceReference1.YoyakuServiceClient client = new ServiceReference1.YoyakuServiceClient())
            {
                var ret = client.GetData();
                textBox1.AppendText(ret);

                //受信データをDataSetに読取りする
                System.IO.StringReader reader = new System.IO.StringReader(ret);
                dataSet1.ReadXml(reader);
                reader.Close();
                //DataGridViewに表示
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = dataSet1.Tables[0].TableName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataSet1 = new DataSet();
            textBox1.Clear();
            textBox1.Refresh();

            using (ServiceReference1.YoyakuServiceClient client = new ServiceReference1.YoyakuServiceClient())
            {
                var ret = client.GetStay();
                textBox1.AppendText(ret);

                System.IO.StringReader reader = new System.IO.StringReader(ret);
                dataSet1.ReadXml(reader);
                reader.Close();

                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = dataSet1.Tables[0].TableName;

            }
        }

        /// <summary>
        /// TextBox DataGridViewをクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            dataGridView1.DataMember = null;
            dataGridView1.DataSource = null;
        }
    }
}
