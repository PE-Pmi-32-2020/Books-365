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
        public string email { get; set; }
        public ForgotPassword(string emailTextBox)
        {
            InitializeComponent();
            email = emailTextBox;
        }

        private void SecretPinTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(SecretPinTextBox.Text=="SecretPin")
                SecretPinTextBox.Text = "";
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
            using (AppContext db = new AppContext())
            {
                Validator validator = new Validator();
                if(validator.IsEmpty(SecretPinTextBox)||
                    !validator.SecretPinIsCorrect(SecretPinTextBox)||
                    validator.IsEmpty(NewPasswordTextBox)||
                    validator.IsEmpty(NewPasswordConfirmTextBox) ||
                    !validator.PasswordIsCorrect(NewPasswordTextBox)||
                    !validator.ConfirmIsSame(NewPasswordConfirmTextBox, NewPasswordTextBox)){ }
                else 
                { 
                
                    var Registered_user_email = db.Users
                           .Where(u => u.Email == email).FirstOrDefault();
                    var Registered_user_pin = db.Users.Where(u => u.SecretPin == int.Parse(SecretPinTextBox.Text.ToString())&&u.Email==Registered_user_email.Email).FirstOrDefault();
                    if (Registered_user_pin == null)
                    {
                        MessageBox.Show("Wrong secret pin or email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        User u = db.Users.Single(u => u.Email == email);
                        u.Password = NewPasswordTextBox.Text;
                        db.SaveChanges();
                        this.Close();
                        Window1 w1 = new Window1();
                        w1.Show();
                    }
                }
            }
        }

        private void NewPasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (NewPasswordTextBox.Text == "New password")
                NewPasswordTextBox.Text = "";
        }
        private void ConfirmNewPasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (NewPasswordConfirmTextBox.Text == "Confirm new password")
                NewPasswordConfirmTextBox.Text = "";
        }
    }
}
