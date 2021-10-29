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
    public partial class User1 : Form
    {
        public User1()
        {
            InitializeComponent();
            label1.Text = $"欢迎{Data.UID}登录";
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 user2 = new user2();
            user2.ShowDialog();
        }

        private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 user3 = new user3();
            user3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
