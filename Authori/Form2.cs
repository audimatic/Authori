using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authori
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form17_auth1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1_auth = new Form1();
            form1_auth.ShowDialog();
            //if (Auth.auth)
            //{
            //    this.Show();
            //    label1.Text = "Успешна!";
            //    label1.ForeColor = Color.Green;
            //}
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
