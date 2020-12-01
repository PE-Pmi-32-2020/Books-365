using Xunit;
using System.Linq;
using System.Windows.Controls;

namespace Books365Tests
{
    public class TestValidator
    {
        [StaFact]
        public void TestPasswordValid1()
        {
            PasswordBox testPasswordBox = new PasswordBox();
            testPasswordBox.Password = "Pa$$word123";
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            Assert.True(v.PasswordIsCorrect(testPasswordBox));
        }

        [StaFact]
        public void TestPasswordValid2()
        {
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "Pa$$word123";
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            Assert.True(v.PasswordIsCorrect(testTextBox));
        }

        [StaFact]
        public void TestPasswordInValid1()
        {
            PasswordBox testPasswordBox = new PasswordBox();
            testPasswordBox.Password = "password";
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            Assert.False(v.PasswordIsCorrect(testPasswordBox));
        }

        [StaFact]
        public void TestPasswordInValid2()
        {
            PasswordBox testPasswordBox = new PasswordBox();
            testPasswordBox.Password = "password1234";
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            Assert.False(v.PasswordIsCorrect(testPasswordBox));
        }

        [StaFact]
        public void TestPasswordInValid3()
        {
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "password";
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            Assert.False(v.PasswordIsCorrect(testTextBox));
        }

        [StaFact]
        public void TestPasswordInValid4()
        {
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "password1234";
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            Assert.False(v.PasswordIsCorrect(testTextBox));
        }

        [StaFact]
        public void TestEmailExistsValid()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
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
                Assert.True(v.EmailExists(testEmailBox));
                db.Users.RemoveRange(db.Users.Where(u => u.Email == testEmailBox.Text));
                db.EmailCurrentUser.RemoveRange(db.EmailCurrentUser.Where(u => u.Email == testEmailBox.Text));
                db.SaveChanges();
            }
        }

        [StaFact]
        public void TestEmailExistsInValid()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testEmailBox = new TextBox();
            testEmailBox.Text = "testemail2@gmail.com";
            Assert.False(v.EmailExists(testEmailBox));
        }

        [StaFact]
        public void TestEmailIsCorrectValid()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testEmailBox = new TextBox();
            testEmailBox.Text = "testemail2@gmail.com";
            Assert.True(v.EmailIsCorrect(testEmailBox));
        }

        [StaFact]
        public void TestEmailIsCorrectInvalid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testEmailBox = new TextBox();
            testEmailBox.Text = "tgmail.com";
            Assert.False(v.EmailIsCorrect(testEmailBox));
        }

        [StaFact]
        public void TestEmailIsCorrectInvalid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testEmailBox = new TextBox();
            testEmailBox.Text = "t@gmailcom";
            Assert.False(v.EmailIsCorrect(testEmailBox));
        }

        [StaFact]
        public void TestIsEmptyValid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox = new TextBox();
            Assert.True(v.IsEmpty(testTextBox));
        }

        [StaFact]
        public void TestIsEmptyValid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            PasswordBox testPasswordBox = new PasswordBox();
            Assert.True(v.IsEmpty(testPasswordBox));
        }

        [StaFact]
        public void TestIsEmptyIvalid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "11";
            Assert.False(v.IsEmpty(testTextBox));
        }

        [StaFact]
        public void TestIsEmptyInvalid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            PasswordBox testPasswordBox = new PasswordBox();
            testPasswordBox.Password = "1";
            Assert.False(v.IsEmpty(testPasswordBox));
        }

        [StaFact]
        public void TestConfirmPwdValid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox1 = new TextBox();
            TextBox testTextBox2 = new TextBox();
            testTextBox1.Text = "password";
            testTextBox2.Text = "password";
            Assert.True(v.ConfirmIsSame(testTextBox1, testTextBox2));
        }

        [StaFact]
        public void TestConfirmPwdValid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            PasswordBox testPasswordBox1 = new PasswordBox();
            PasswordBox testPasswordBox2 = new PasswordBox();
            testPasswordBox1.Password = "password";
            testPasswordBox2.Password = "password";
            Assert.True(v.ConfirmIsSame(testPasswordBox1, testPasswordBox2));
        }

        [StaFact]
        public void TestonfirmPwdIvalid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox1 = new TextBox();
            TextBox testTextBox2 = new TextBox();
            testTextBox1.Text = "password";
            testTextBox1.Text = "pas$$ord";
            Assert.False(v.ConfirmIsSame(testTextBox1, testTextBox2));
        }

        [StaFact]
        public void TestConfirmPwdInvalid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            PasswordBox testPasswordBox1 = new PasswordBox();
            PasswordBox testPasswordBox2 = new PasswordBox();
            testPasswordBox1.Password = "passord";
            testPasswordBox2.Password = "pa$$word";
            Assert.False(v.ConfirmIsSame(testPasswordBox1, testPasswordBox2));
        }

        [StaFact]
        public void TestSecretPinorrectValid()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "3344";
            Assert.True(v.SecretPinIsCorrect(testTextBox));
        }

        [StaFact]
        public void TestSecretPinorrectInvalid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "a334";
            Assert.False(v.SecretPinIsCorrect(testTextBox));
        }

        [StaFact]
        public void TestSecretPinorrectInvalid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testTextBox = new TextBox();
            testTextBox.Text = "32334";
            Assert.False(v.SecretPinIsCorrect(testTextBox));
        }

        [StaFact]
        public void TestYearValid()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testYearBox = new TextBox();
            testYearBox.Text = "1994";
            Assert.True(v.YearIsValid(testYearBox));
        }

        [StaFact]
        public void TestYearInvalid1()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testYearBox = new TextBox();
            testYearBox.Text = "a1235";
            Assert.False(v.YearIsValid(testYearBox));
        }

        [StaFact]
        public void TestYearInvalid2()
        {
            Books365.BLL.Validator v = new Books365.BLL.Validator();
            TextBox testYearBox = new TextBox();
            testYearBox.Text = "2100";
            Assert.False(v.YearIsValid(testYearBox));
        }
    }
}
