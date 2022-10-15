using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Authori
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string connStr = "server=10.90.12.110;port=44444;user=st_3_20_16;database=is_3_20_st16_KURS;password=81461500;";
        MySqlConnection conn = new MySqlConnection();

        public void GetUserInfo(string login_user)
        {
            string selected_id_stud = textBox1.Text;
            conn.Open();
            string sql = $"SELECT * FROM VrachiTEST WHERE Login='{login_user}'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

        }

            private void button1_Click(object sender, EventArgs e)
        {
                string sql = "SELECT * FROM VrachiTEST WHERE Login = @un and  Password= @up";
                conn.Open();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
                command.Parameters.Add("@up", MySqlDbType.VarChar, 25);
                command.Parameters["@un"].Value = textBox1.Text;
                command.Parameters["@up"].Value = textBox2.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
