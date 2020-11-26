namespace Books365.PL
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using Books365.BLL;

    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            Validator validator = new Validator();
            if (validator.IsEmpty(this.EmailTextBox) ||
            !validator.EmailIsCorrect(this.EmailTextBox) ||
            validator.IsEmpty(this.LastNameTextBox) ||
            validator.IsEmpty(this.FirstNameTextBox) ||
            validator.IsEmpty(this.SecretPinTextBox) ||
            validator.EmailExists(this.EmailTextBox) ||
            !validator.SecretPinIsCorrect(this.SecretPinTextBox) ||
            !validator.PasswordIsCorrect(this.PasswordTextBox) ||
            !validator.PasswordIsCorrect(this.ConfirmPasswordTextBox) ||
            !validator.ConfirmIsSame(this.ConfirmPasswordTextBox, this.PasswordTextBox)) { }
            else
            {
                Books365.BLL.User user = new Books365.BLL.User();
                user.AddNewUser(this.FirstNameTextBox, this.LastNameTextBox, this.PasswordTextBox, this.EmailTextBox, this.SecretPinTextBox);
                Window1 w1 = new Window1();
                w1.Show();
                this.Close();
            }
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void EmailTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.EmailTextBox.Text == "Email")
            {
                this.EmailTextBox.Text = string.Empty;
            }
        }

        private void FirstNameTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.FirstNameTextBox.Text == "FirstName")
            {
                this.FirstNameTextBox.Text = string.Empty;
            }
        }

        private void LastNameTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.LastNameTextBox.Text == "LastName")
            {
                this.LastNameTextBox.Text = string.Empty;
            }
        }

        private void PasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.PasswordTextBox.Password.ToString() == "Password")
            {
                this.PasswordTextBox.Password = string.Empty;
            }
        }

        private void ConfirmPasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.ConfirmPasswordTextBox.Password.ToString() == "Password")
            {
                this.ConfirmPasswordTextBox.Password = string.Empty;
            }
        }

        private void SecretPinTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.SecretPinTextBox.Text == "SecretPin")
            {
                this.SecretPinTextBox.Text = string.Empty;
            }
        }
    }
}
