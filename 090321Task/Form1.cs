using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _090321Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UsernameTxtB_MouseEnter(object sender, EventArgs e)
        {
            if (this.UsernameTxtB.Text == "User Name")
            {
                this.UsernameTxtB.Text = string.Empty;
                this.UsernameTxtB.ForeColor = Color.Black;
            }
        }

        private void UsernameTxtB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.UsernameTxtB.Text))
            {
                this.UsernameTxtB.ForeColor = SystemColors.WindowFrame;
                this.UsernameTxtB.Text = "User Name";
            }

        }

        private void PasswordTxtB_MouseEnter(object sender, EventArgs e)
        {
            if (this.PasswordTxtB.Text == "Password")
            {
                this.PasswordTxtB.Text = string.Empty;
                this.PasswordTxtB.ForeColor =  Color.Black;
                this.PasswordTxtB.PasswordChar = '*';
            }
        }

        private void PasswordTxtB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.PasswordTxtB.Text))
            {
                this.PasswordTxtB.PasswordChar = default;
                this.PasswordTxtB.ForeColor = SystemColors.WindowFrame;
                this.PasswordTxtB.Text = "Password";
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (this.UsernameTxtB.Text != "admin")
            {

                if (this.UsernameTxtB.Text == "User Name")
                    this.UsernameStatusLbl.Text = "Username is blank!";
                else
                    this.UsernameStatusLbl.Text = "Username is wrong!"; 

                this.UsernameStatusLbl.Visible = true;

                FocusUserInput(this.UsernameTxtB);
                return;
            }

            this.UsernameStatusLbl.Visible = false;

            if (this.PasswordTxtB.Text != "admin")
            {
                if (this.UsernameTxtB.Text == "Password")
                    this.UsernameStatusLbl.Text = "Password is blank!";
                else
                    this.PasswordStatusLbl.Text = "Password is wrong!";
                this.PasswordStatusLbl.Visible = true;

                FocusUserInput(this.PasswordTxtB);
                return;
            }

            this.PasswordStatusLbl.Visible = false;

            MessageBox.Show("Login successfully!", "Login info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void FocusUserInput(TextBox textBox)
        {
            textBox.Focus();
            //textBox.SelectionStart = textBox.Text.Length;
        }
    }
}
