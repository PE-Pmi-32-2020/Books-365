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
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        public EditProfile()
        {
            InitializeComponent();
            EditProfileFunc();
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
                Registered_user.FirstName=FirstNameTextBox.Text;
                Registered_user.LastName = LastNameTextBox.Text;
                Registered_user.Password= PasswordTextBox.Password;
                Registered_user.Password=ConfirmPasswordTextBox.Password ;
                Registered_user.SecretPin= Convert.ToInt32(SecretPinTextBox.Text);
                db.SaveChanges();
            }
        }
    }
}
