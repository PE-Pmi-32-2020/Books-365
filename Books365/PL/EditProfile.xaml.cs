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
            this.InitializeComponent();
            this.EditProfileFunc();
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }

        private void EditProfileFunc()
        {
            Books365.BLL.User u = new Books365.BLL.User();
            u.EditProfile(this.FirstNameTextBox, this.LastNameTextBox, this.PasswordTextBox, this.ConfirmPasswordTextBox, this.SecretPinTextBox);
        }

        private void Save_Profile_Changes_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                Validator validator = new Validator();
                if (
                validator.IsEmpty(this.LastNameTextBox) ||
                validator.IsEmpty(this.FirstNameTextBox) ||
                validator.IsEmpty(this.SecretPinTextBox) ||
                !validator.SecretPinIsCorrect(this.SecretPinTextBox) ||
                !validator.PasswordIsCorrect(this.PasswordTextBox) ||
                !validator.PasswordIsCorrect(this.ConfirmPasswordTextBox) ||
                !validator.ConfirmIsSame(this.ConfirmPasswordTextBox, this.PasswordTextBox))
                {
                }
                else
                {
                    registered_user.FirstName = this.FirstNameTextBox.Text;
                    registered_user.LastName = this.LastNameTextBox.Text;
                    registered_user.Password = this.PasswordTextBox.Password;
                    registered_user.Password = this.ConfirmPasswordTextBox.Password;
                    registered_user.SecretPin = Convert.ToInt32(this.SecretPinTextBox.Text);
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
