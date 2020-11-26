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
using Books365.BLL;


namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        public EditProfile()
        {
            InitializeComponent();
            EditProfileFunc();
        }
        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }
        void EditProfileFunc()
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var Registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                FirstNameTextBox.Text = Registered_user.FirstName;
                LastNameTextBox.Text = Registered_user.LastName;
                PasswordTextBox.Password = Registered_user.Password;
                ConfirmPasswordTextBox.Password = Registered_user.Password;
                SecretPinTextBox.Text = Registered_user.SecretPin.ToString();
            }
        }

        private void Save_Profile_Changes_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var Registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                Validator validator = new Validator();
                if (
                validator.IsEmpty(LastNameTextBox) ||
                validator.IsEmpty(FirstNameTextBox) ||
                validator.IsEmpty(SecretPinTextBox) ||
                !validator.SecretPinIsCorrect(SecretPinTextBox) ||
                !validator.PasswordIsCorrect(PasswordTextBox) ||
                !validator.PasswordIsCorrect(ConfirmPasswordTextBox) ||
                !validator.ConfirmIsSame(ConfirmPasswordTextBox, PasswordTextBox)) { }
                else
                {
                    Registered_user.FirstName = FirstNameTextBox.Text;
                    Registered_user.LastName = LastNameTextBox.Text;
                    Registered_user.Password = PasswordTextBox.Password;
                    Registered_user.Password = ConfirmPasswordTextBox.Password;
                    Registered_user.SecretPin = Convert.ToInt32(SecretPinTextBox.Text);
                    db.SaveChanges();
                    Application.Current.Windows.OfType<Window>().
                    Where(w => !w.IsVisible).FirstOrDefault().Visibility = Visibility.Visible;
                    this.Close();
                }

            }
        }

        private void CancelChanges_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<Window>().
            Where(w => !w.IsVisible).FirstOrDefault().Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
