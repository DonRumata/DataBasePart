using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBasePart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if((textBox1.Text.Length>20)||(textBox2.Text.Length>20)||(textBox1.Text=="")||(textBox2.Text==""))
            //{
            //    MessageBox.Show("Неправильное имя пользователя или пароль", "WrongPN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{

            //    if(Program.MainConnectionClass.CreateConnection(textBox1.Text, textBox2.Text, 2))
            //    {
            //        Program.NowUsingForm.MainForm = (new MainBaseInterfaceForm());
            //        Program.NowUsingForm.MainForm.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Не удалось подключится к серверу", "ConnectionErr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}
