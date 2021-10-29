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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }
        //登录方法，验证是否允许登录，允许返回真
        public void Login()
        {
            //用户
            if (radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                //string sql = "select * from t_user where id='" + textBox1.Text + "' and psw='" + textBox1.Text + "'";
                //string sql = String.Format("select * from t_user where id='{0}' and psw='{1}'", textBox1.Text, textBox1.Text)
                string sql = $"select * from t_user where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if(dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.Name = dc["name"].ToString(); 

                    MessageBox.Show("登录成功");

                    User1 user = new User1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                    //return true;
                }
                else
                {
                    MessageBox.Show("登录失败");
                    //return false;
                }
                dao.DaoClose();

            }
            //管理员
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select * from t_admin where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功");
                    Admin1 a = new Admin1();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                    //return true;
                }
                else
                {
                    MessageBox.Show("登录失败");
                    //return false;
                }
                dao.DaoClose();
            }
            //MessageBox.Show("单选框请先选中");
            //return false;
        }
    }
}
