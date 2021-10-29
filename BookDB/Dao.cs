using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BookDB
{
    class Dao
    {
        /*SqlConnection sc;
        public SqlConnection connet()
        {//LAPTOP-TS5F66GS
            string str = @"Data Source=127.0.0.1;Initial Catalog=BookDB;Integrated Security=True"; //数据库连接字符串
            SqlConnection sc = new SqlConnection(str); //创建数据库连接对象
            sc.Open(); //打开数据库
            return sc; //返回数据库连接对象
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connet());
            return cmd;
        }
        public int Execute(string sql) //更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql) //读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }*/
        MySqlConnection conn;
        public MySqlConnection connet()
        {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=;database=bookdb;";
            MySqlConnection con = new MySqlConnection(connetStr);
            con.Open();
            conn = con;
            return con;
        }
        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connet());
            return cmd;
        }
        public int Execute(string sql) //更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public MySqlDataReader read(string sql) //读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            conn.Close();
        }
    }
}
