using Books365.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            Books365.BLL.User u = new Books365.BLL.User();
            if (u.Login(this.EmailTextBox, this.PasswordTextBox))
            {
                Window1 w1 = new Window1();
                w1.Show();
                this.Close();
            }
            else
            {
            }
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }


        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void EmailTextBox_Click(object sender, MouseEventArgs e)
        {
            if (this.EmailTextBox.Text == "Email")
            {
                this.EmailTextBox.Text = string.Empty;
            }
        }

        private void PasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.PasswordTextBox.Password.ToString() == "Password")
            {
                this.PasswordTextBox.Password = string.Empty;
            }
            else if (this.Password_Register.Password.ToString() == "Password")
            {
                this.Password_Register.Password = string.Empty;
            }
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            this.LabelForgot.Opacity = 0.4;
        }

        private void LabelForgot_MouseLeave(object sender, MouseEventArgs e)
        {
            this.LabelForgot.Opacity = 1;
        }

        private void LabelForgot_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword fg = new ForgotPassword();
            fg.Show();
            this.Close();
        }

        private void SecretPinTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.SecretPinTextBox.Text == "Enter your secret pin")
            {
                this.SecretPinTextBox.Text = string.Empty;
            }
        }

        private void FirstNameTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.FirstNameTextBox.Text == "Your first name")
            {
                this.FirstNameTextBox.Text = string.Empty;
            }
        }

        private void LastNameTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.LastNameTextBox.Text == "Your last name")
            {
                this.LastNameTextBox.Text = string.Empty;
            }
        }

        private void Button_Click_Reg(object sender, RoutedEventArgs e)
        {
            Validator validator = new Validator();
            if (validator.IsEmpty(this.Email_Register) ||
            !validator.EmailIsCorrect(this.Email_Register) ||
            validator.IsEmpty(this.LastNameTextBox) ||
            validator.IsEmpty(this.FirstNameTextBox) ||
            validator.IsEmpty(this.SecretPinTextBox) ||
            validator.EmailExists(this.Email_Register) ||
            !validator.SecretPinIsCorrect(this.SecretPinTextBox) ||
            !validator.PasswordIsCorrect(this.Password_Register))
            {
            }
            else
            {
                Books365.BLL.User user = new Books365.BLL.User();
                user.AddNewUser(this.FirstNameTextBox, this.LastNameTextBox, this.Password_Register, this.Email_Register, this.SecretPinTextBox);
                Window1 w1 = new Window1();
                w1.Show();
                this.Close();
            }
        }

        private void Email_Register_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.Email_Register.Text == "Enter your email")
            {
                this.Email_Register.Text = string.Empty;
            }
        }
    }
}