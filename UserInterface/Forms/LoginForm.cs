using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            try
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введи цифры неуч!!!");
                return;
            }
           
            if (age >=18)
            {
                var main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Еще юн щегол!!!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Login form has been show");
        }
    }
}
