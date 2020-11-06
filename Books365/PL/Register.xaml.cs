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

            if (EmailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter an email", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                EmailTextBox.Focus();
            }
            else if (!Regex.IsMatch(EmailTextBox.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                EmailTextBox.Select(0, EmailTextBox.Text.Length);
                EmailTextBox.Focus();
            }


            else if (LastNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a LastName", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                LastNameTextBox.Focus();
            }

            else if (FirstNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a FirstName", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                FirstNameTextBox.Focus();
            }

            else if (SecretPinTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter a FirstName", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                FirstNameTextBox.Focus();
            }
            else if (!Regex.IsMatch(SecretPinTextBox.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Secret pin must contain 4 numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                SecretPinTextBox.Select(0, EmailTextBox.Text.Length);
                SecretPinTextBox.Focus();
            }
            else if (PasswordTextBox.Password.Length == 0)
            {
                MessageBox.Show("Enter a Password", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                PasswordTextBox.Focus();
            }
            else if (!Regex.IsMatch(PasswordTextBox.Password, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,30}"))
            {
                MessageBox.Show("Password must contain \n" +
                    "At least one digit [0-9] \n" +
                    "At least one lowercase character[a - z]\n" +
                    "At least one uppercase character[A - Z]\n" +
                    "At least 6 characters in length, but no more than 30.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                PasswordTextBox.Focus();
            }

            else if (ConfirmPasswordTextBox.Password.Length == 0)
            {
                MessageBox.Show("Enter a ConfirmPassword", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                ConfirmPasswordTextBox.Focus();
            }
            else if (PasswordTextBox.Password != ConfirmPasswordTextBox.Password)
            {
                MessageBox.Show("Confirm password must be same as password.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning); ;
                ConfirmPasswordTextBox.Focus();
            }
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
    }
}
