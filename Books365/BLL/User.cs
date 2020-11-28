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

        public void AddBook(TextBox titleText, TextBox yearText, TextBox authorText)
        {
            using (Books365.AppContext db = new Books365.AppContext())
            {

                db.Books.Add(new Book
                {
                    Title = titleText.Text,
                    Year = Convert.ToInt32(yearText.Text),
                    Author = authorText.Text,
                });

                db.SaveChanges();
            }
        }

        public void EditProfile(TextBox firstNameTextBox, TextBox lastNameTextBox, PasswordBox passwordTextBox, PasswordBox confirmPasswordTextBox, TextBox secretPinTextBox)
        {
            using (Books365.AppContext db = new Books365.AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                firstNameTextBox.Text = registered_user.FirstName;
                lastNameTextBox.Text = registered_user.LastName;
                passwordTextBox.Password = registered_user.Password;
                confirmPasswordTextBox.Password = registered_user.Password;
                secretPinTextBox.Text = registered_user.SecretPin.ToString();
            }
        }

        public bool ChangePassword(string email, TextBox secretPinTextBox, TextBox newPasswordTextBox)
        {
            using (Books365.AppContext db = new Books365.AppContext())
            {
                var registered_user_email = db.Users
                        .Where(u => u.Email == email).FirstOrDefault();
                var registered_user_pin = db.Users.Where(u => u.SecretPin == int.Parse(secretPinTextBox.Text.ToString()) && u.Email == registered_user_email.Email).FirstOrDefault();
                if (registered_user_pin == null)
                {
                    return false;
                }
                else
                {
                    Books365.User u = db.Users.Single(u => u.Email == email);
                    u.Password = newPasswordTextBox.Text;
                    db.SaveChanges();
                    return true;
                }
            }
    }
}
