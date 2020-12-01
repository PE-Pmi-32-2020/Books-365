using Xunit;
using System.Linq;
using System.Windows.Controls;

namespace Books365Tests
{
    public class TestUser
    {
        [StaFact]
       public void TestAddNewUser()
        {
            TextBox testFirstNameBox = new TextBox();
            TextBox testLastNameBox = new TextBox();
            PasswordBox testPasswordBox = new PasswordBox();
            TextBox testEmailBox = new TextBox();
            TextBox testSecretPinBox = new TextBox();
            testFirstNameBox.Text = "name";
            testLastNameBox.Text = "surname";
            testPasswordBox.Password = "Testpwd1";
            testEmailBox.Text = "testemail@gmail.com";
            testSecretPinBox.Text = "1234";

            Books365.BLL.User user = new Books365.BLL.User();
            using (Books365.AppContext db = new Books365.AppContext())
            {
                user.AddNewUser(testFirstNameBox, testLastNameBox, testPasswordBox, testEmailBox, testSecretPinBox);
                Assert.Equal(db.Users.Where(u => u.Email == testEmailBox.Text).FirstOrDefault().Email, testEmailBox.Text);
                db.Users.RemoveRange(db.Users.Where(u => u.Email == testEmailBox.Text));
                db.EmailCurrentUser.RemoveRange(db.EmailCurrentUser.Where(u => u.Email == testEmailBox.Text));
                db.SaveChanges();
            }
        }

        [StaFact]
        public void TestLoginInvalid()
        {
            TextBox emailBox = new TextBox();
            PasswordBox pwdBox = new PasswordBox();
            emailBox.Text = "testemail@gmail1.com";
            pwdBox.Password = "testpassword";
            Books365.BLL.User user = new Books365.BLL.User();
            using (Books365.AppContext db = new Books365.AppContext())
            {
                Assert.False(user.Login(emailBox, pwdBox));
            }
        }

        [StaFact]
       public void TestLoginValid()
        {
            TextBox testFirstNameBox = new TextBox();
            TextBox testLastNameBox = new TextBox();
            PasswordBox testPasswordBox = new PasswordBox();
            TextBox testEmailBox = new TextBox();
            TextBox testSecretPinBox = new TextBox();
            testFirstNameBox.Text = "name";
            testLastNameBox.Text = "surname";
            testPasswordBox.Password = "Testpwd1";
            testEmailBox.Text = "testemail@gmail.com";
            testSecretPinBox.Text = "1234";
           
            Books365.BLL.User user = new Books365.BLL.User();
            using (Books365.AppContext db = new Books365.AppContext())
            {
                user.AddNewUser(testFirstNameBox, testLastNameBox, testPasswordBox, testEmailBox, testSecretPinBox);
                db.EmailCurrentUser.RemoveRange(db.EmailCurrentUser.Where(u => u.Email == testEmailBox.Text));
                db.SaveChanges();
                Assert.True(user.Login(testEmailBox, testPasswordBox));
                db.Users.RemoveRange(db.Users.Where(u => u.Email == testEmailBox.Text));
                db.EmailCurrentUser.RemoveRange(db.EmailCurrentUser.Where(u => u.Email == testEmailBox.Text));
                db.SaveChanges();
            }
        }

        [StaFact]
       public void TestAddBook() 
        {
            TextBox testTitleBox = new TextBox();
            TextBox testYearBox = new TextBox();
            TextBox testAuthorBox = new TextBox();
            testTitleBox.Text = "testBook";
            testYearBox.Text = "2020";
            testAuthorBox.Text = "testAuthor";
            Books365.BLL.User user = new Books365.BLL.User();
            using (Books365.AppContext db = new Books365.AppContext())
            {
                user.AddBook(testTitleBox, testYearBox, testAuthorBox);
                Assert.Equal(db.Books.Where(b => b.Title == testTitleBox.Text).FirstOrDefault().Title, testTitleBox.Text);
                db.Books.RemoveRange(db.Books.Where(b => b.Title == testTitleBox.Text));
                db.SaveChanges();
            }
        }

        [StaFact]
        public void TestEditProfile()
        {
            TextBox testFirstNameBox = new TextBox();
            TextBox testLastNameBox = new TextBox();
            PasswordBox testPasswordBox = new PasswordBox();
            TextBox testEmailBox = new TextBox();
            TextBox testSecretPinBox = new TextBox();
            testFirstNameBox.Text = "name";
            testLastNameBox.Text = "surname";
            testPasswordBox.Password = "Testpwd1";
            testEmailBox.Text = "atestemail@gmail.com";
            testSecretPinBox.Text = "1234";

            Books365.BLL.User user = new Books365.BLL.User();
            using (Books365.AppContext db = new Books365.AppContext())
            {
                user.AddNewUser(testFirstNameBox, testLastNameBox, testPasswordBox, testEmailBox, testSecretPinBox);
                TextBox testNewFirstNameBox = new TextBox();
                TextBox testNewLastNameBox = new TextBox();
                user.EditProfile(testNewFirstNameBox, testNewLastNameBox, testPasswordBox, testPasswordBox, testSecretPinBox);
                Assert.Equal(testFirstNameBox.Text, testNewFirstNameBox.Text);
                Assert.Equal(testLastNameBox.Text, testNewLastNameBox.Text);
                db.Users.RemoveRange(db.Users.Where(u => u.Email == testEmailBox.Text));
                db.EmailCurrentUser.RemoveRange(db.EmailCurrentUser.Where(u => u.Email == testEmailBox.Text));
                db.SaveChanges();
            }
        }

        [StaFact]
        public void TestChangePassword()
        {
            TextBox testFirstNameBox = new TextBox();
            TextBox testLastNameBox = new TextBox();
            PasswordBox testPasswordBox = new PasswordBox();
            TextBox testEmailBox = new TextBox();
            TextBox testSecretPinBox = new TextBox();
            testFirstNameBox.Text = "name";
            testLastNameBox.Text = "surname";
            testPasswordBox.Password = "Testpwd1";
            testEmailBox.Text = "atestemail@gmail.com";
            testSecretPinBox.Text = "1234";

            Books365.BLL.User user = new Books365.BLL.User();
            using (Books365.AppContext db = new Books365.AppContext())
            {
                TextBox testNewPasswordBox = new TextBox();
                testNewPasswordBox.Text = "NewPassword";
                user.AddNewUser(testFirstNameBox, testLastNameBox, testPasswordBox, testEmailBox, testSecretPinBox);
                user.ChangePassword(testEmailBox.Text, testSecretPinBox, testNewPasswordBox);
                Assert.Equal(testNewPasswordBox.Text, db.Users.Where(u => u.Email == testEmailBox.Text).FirstOrDefault().Password);
                db.Users.RemoveRange(db.Users.Where(u => u.Email == testEmailBox.Text));
                db.EmailCurrentUser.RemoveRange(db.EmailCurrentUser.Where(u => u.Email == testEmailBox.Text));
                db.SaveChanges();
            }
        }
    }
}
