namespace Books365.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using Books365;

    internal class User
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Password { get; private set; }

        public string Email { get; private set; }

        public int SecretPin { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }

        /// GFDGD FGDF GDF
        public bool Login(TextBox text, PasswordBox password)
        {

            using (Books365.AppContext db = new Books365.AppContext())
            {
                var registered_user_email = db.Users
                       .Where(u => u.Email == text.Text.ToString()).FirstOrDefault();
                var registered_user_password = db.Users.Where(u => u.Password == password.Password.ToString()).FirstOrDefault();
                if (registered_user_email == null || registered_user_password == null)
                {
                    MessageBox.Show("Wrong password or email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                if (registered_user_email != null && registered_user_password != null)
                {
                    db.EmailCurrentUser.Add(new EmailOfCurrentUser
                    {
                        Email = text.Text.ToString(),
                    });
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public void AddNewUser(TextBox firstNameTextBox, TextBox lastNameTextBox, PasswordBox passwordTextBox, TextBox emailTextBox, TextBox secretPinTextBox)
        {
            using (Books365.AppContext db = new Books365.AppContext())
            {
                db.Users.Add(new Books365.User
                {
                    FirstName = firstNameTextBox.Text.ToString(),
                    LastName = lastNameTextBox.Text.ToString(),
                    Password = passwordTextBox.Password.ToString(),
                    Email = emailTextBox.Text.ToString(),
                    SecretPin = int.Parse(secretPinTextBox.Text.ToString()),
                });
                db.EmailCurrentUser.Add(new EmailOfCurrentUser
                {
                    Email = emailTextBox.Text.ToString(),
                });
            }
        }
    }
}
