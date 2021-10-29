using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDB
{
    public partial class user2 : Form
    {
        public user2()
        {
            InitializeComponent();
        }

        private void user2_Load(object sender, EventArgs e)
        {
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取书号
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());//获取库存
            if(number<1)
            {
                MessageBox.Show("库存不足，请联系管理员");
            }
            else
            {
                string sql = $"INSERT into t_lend(`uid`,bid,`datetime`) VALUES ('{Data.UID}','{id}',now());update t_book set number=number-1 where id='{id}'";
                Dao dao = new Dao();
                if(dao.Execute(sql)>1)//执行了两条sql，大于1才是都成功的
                {
                    MessageBox.Show($"用户{Data.UID}借出了图书{id}");
                    Table();
                }
            }
        }
    }
}
