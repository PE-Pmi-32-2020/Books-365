using Books365.BLL;
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

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            Validator validator = new Validator();
            if (validator.IsEmpty(EmailTextBox) ||
            !validator.EmailIsCorrect(EmailTextBox) ||
            validator.IsEmpty(LastNameTextBox) ||
            validator.IsEmpty(FirstNameTextBox) ||
            validator.IsEmpty(SecretPinTextBox) ||
            validator.EmailExists(EmailTextBox) ||
            !validator.SecretPinIsCorrect(SecretPinTextBox) ||
            !validator.PasswordIsCorrect(PasswordTextBox) ||
            !validator.PasswordIsCorrect(ConfirmPasswordTextBox) ||
            !validator.ConfirmIsSame(ConfirmPasswordTextBox, PasswordTextBox)) { }
            else
            {
                using (AppContext db = new AppContext())
                {
                    db.Users.Add(new User
                    {
                        FirstName = FirstNameTextBox.Text.ToString(),
                        LastName = LastNameTextBox.Text.ToString(),
                        Password = PasswordTextBox.Password.ToString(),
                        Email = EmailTextBox.Text.ToString(),
                        SecretPin = Int32.Parse(SecretPinTextBox.Text.ToString())
                    });
                    db.EmailCurrentUser.Add(new EmailOfCurrentUser
                    {
                        Email = EmailTextBox.Text.ToString()
                    }
                    
                        );
                    db.SaveChanges();
                    Window1 w1 = new Window1();
                    w1.Show();
                    this.Close();
                }
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
            if (EmailTextBox.Text == "Email")
            {

                EmailTextBox.Text = "";

            }
        }

        private void FirstNameTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (FirstNameTextBox.Text == "FirstName")
            {

                FirstNameTextBox.Text = "";

            }
        }

        private void LastNameTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LastNameTextBox.Text == "LastName")
            {

                LastNameTextBox.Text = "";

            }
        }

        private void PasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (PasswordTextBox.Password.ToString() == "Password")
            {

                PasswordTextBox.Password = "";

            }
        }

        private void ConfirmPasswordTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ConfirmPasswordTextBox.Password.ToString() == "Password")
            {

                ConfirmPasswordTextBox.Password = "";

            }
        }

        private void SecretPinTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (SecretPinTextBox.Text == "SecretPin")
            {

                SecretPinTextBox.Text = "";

            }
        }
    }
}
