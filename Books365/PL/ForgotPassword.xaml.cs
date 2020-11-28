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
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        public string Email { get; set; }

        public ForgotPassword(string emailTextBox)
        {
            this.InitializeComponent();
            this.Email = emailTextBox;
        }

        private void SecretPinTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.SecretPinTextBox.Text == "SecretPin")
            {
                this.SecretPinTextBox.Text = string.Empty;
            }
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Submit(object sender, RoutedEventArgs e)
        {
            Validator validator = new Validator();
            if (validator.IsEmpty(this.SecretPinTextBox) ||
                !validator.SecretPinIsCorrect(this.SecretPinTextBox) ||
                validator.IsEmpty(this.NewPasswordTextBox) ||
                validator.IsEmpty(this.NewPasswordConfirmTextBox) ||
                !validator.PasswordIsCorrect(this.NewPasswordTextBox) ||
                !validator.ConfirmIsSame(this.NewPasswordConfirmTextBox, this.NewPasswordTextBox))
            {
            }
            else
            {
                Books365.BLL.User u = new Books365.BLL.User();
                bool answer = u.ChangePassword(this.Email, this.SecretPinTextBox, this.NewPasswordTextBox);
                if (!answer)
                {
                    MessageBox.Show("Wrong secret pin or email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    this.Close();
                    Window1 w1 = new Window1();
                    w1.Show();
                }
            }
        }

        private void NewPasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.NewPasswordTextBox.Text == "New password")
            {
                this.NewPasswordTextBox.Text = string.Empty;
            }
        }

        private void ConfirmNewPasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.NewPasswordConfirmTextBox.Text == "Confirm new password")
            {
                this.NewPasswordConfirmTextBox.Text = string.Empty;
            }
        }
    }
}
