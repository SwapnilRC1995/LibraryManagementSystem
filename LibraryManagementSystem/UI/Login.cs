using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagementSystem.UI;
using LibraryManagementSystem.Service;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Exceptions;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string Username_field = string.Empty;
        string Password_field = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            Username_field = usernameField.Text;
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            Password_field = passwordField.Text;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(Username_field != string.Empty && Password_field != string.Empty)
            {
                UserService UserService = new UserService();
                try
                {
                    USER User = UserService.GetUserByUsername(Username_field, Password_field);
                    if (User != null)
                    {
                        result.Text = "Login Successful. Redirecting to application...";
                        Dashboard dashboard = new Dashboard(User.USERNAME, User.PERMISSION);
                        this.Hide();
                        dashboard.Show();
                    }
                }
                catch(UserNotFoundException)
                {
                    result.Text = "This user is not available. Please try again with a registered user.";
                }
                catch (PasswordMissmatchException)
                {
                    result.Text = "Incorrect password entered. Please try again.";
                }

            }
            else
            {
                if(Username_field == string.Empty && Password_field == string.Empty)
                {
                    result.Text = "Please enter your Username and Password";
                }
                else
                {
                    result.Text = Username_field == string.Empty ? "Please enter your Username." : "";
                    result.Text = Password_field == string.Empty ? "Please enter your Password." : "";
                }
            }
        }
    }
}
