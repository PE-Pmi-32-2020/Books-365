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
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                var Registered_user_email = db.Users
                       .Where(u => u.Email == EmailTextBox.Text.ToString()).FirstOrDefault();
                var Registered_user_password = db.Users.Where(u => u.Password == PasswordTextBox.Password.ToString()).FirstOrDefault();
                if (Registered_user_email == null || Registered_user_password == null)
                {
                    MessageBox.Show("Wrong password or email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (Registered_user_email != null && Registered_user_password != null)
                {
                    db.EmailCurrentUser.Add(new EmailOfCurrentUser
                    {
                        Email = EmailTextBox.Text.ToString()
                    }

                        );
                    db.SaveChanges();
                    this.Close();
                    Window1 w1 = new Window1();
                    w1.Show();
                }
            }
        }

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
