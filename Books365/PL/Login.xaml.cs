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

        //private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        DragMove();
        //    }
        //}

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

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Close();
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
            ForgotPassword fg = new ForgotPassword(this.EmailTextBox.Text);
            fg.Show();
            this.Close();
        }
    }
}
