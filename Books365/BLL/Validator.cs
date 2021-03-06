﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Books365.BLL
{
    internal class Validator
    {
        /// <summary>
        /// Function that check if password is correctly formed via regEx.(Get passwordbox)
        /// </summary>
        public bool PasswordIsCorrect(PasswordBox password)
        {
            if (!Regex.IsMatch(password.Password, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,30}"))
            {
                _ = MessageBox.Show(
                    "Password must contain \n" +
                    "At least one digit [0-9] \n" +
                    "At least one lowercase character[a - z]\n" +
                    "At least one uppercase character[A - Z]\n" +
                    "At least 6 characters in length, but no more than 30.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                password.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if password is correctly formed via regEx.(Get textbox)
        /// </summary>
        public bool PasswordIsCorrect(TextBox password)
        {
            if (!Regex.IsMatch(password.Text, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,30}"))
            {
                _ = MessageBox.Show(
                    "Password must contain \n" +
                    "At least one digit [0-9] \n" +
                    "At least one lowercase character[a - z]\n" +
                    "At least one uppercase character[A - Z]\n" +
                    "At least 6 characters in length, but no more than 30.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                password.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if email that user input already exists in database.
        /// </summary>
        public bool EmailExists(TextBox email)
        {
            using (AppContext db = new AppContext())
            {
                var registered_user_email = db.Users
                       .Where(u => u.Email == email.Text.ToString()).FirstOrDefault();
                if (registered_user_email != null)
                {
                    MessageBox.Show("Email already exists!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Function that check if email is correctly formed via regEx.
        /// </summary>
        public bool EmailIsCorrect(TextBox email)
        {
            if (!Regex.IsMatch(email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                email.Select(0, email.Text.Length);
                email.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if textbox is empty.
        /// </summary>
        public bool IsEmpty(TextBox textblock)
        {
            if (textblock.Text.Length == 0)
            {
                MessageBox.Show("Enter " + textblock.Name.ToString().Replace("TextBox", string.Empty), "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                textblock.Focus();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Function that check if passwordbox is empty.
        /// </summary>
        public bool IsEmpty(PasswordBox passwordblock)
        {
            if (passwordblock.Password.Length == 0)
            {
                MessageBox.Show("Enter " + passwordblock.Name.ToString().Replace("TextBox", string.Empty), "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                passwordblock.Focus();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Function that check if inputed password and confirmed password are the same.(For passwordboxes)
        /// </summary>
        public bool ConfirmIsSame(PasswordBox confrirmBox, PasswordBox passwordBox)
        {
            if (passwordBox.Password != confrirmBox.Password)
            {
                MessageBox.Show("Confirm password must be same as password.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                confrirmBox.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if inputed password and confirmed password are the same.(For textboxes)
        /// </summary>
        public bool ConfirmIsSame(TextBox confrirmBox, TextBox passwordBox)
        {
            if (passwordBox.Text != confrirmBox.Text)
            {
                MessageBox.Show("Confirm password must be same as password.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                confrirmBox.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if secretPin is correctly formed via regEx.
        /// </summary>
        public bool SecretPinIsCorrect(TextBox secretPin)
        {
            if (!Regex.IsMatch(secretPin.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Secret pin must contain 4 numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                secretPin.Select(0, secretPin.Text.Length);
                secretPin.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if Year that user inputs is correct.
        /// </summary>
        public bool YearIsValid(TextBox yearText)
        {
            if (!int.TryParse(yearText.Text, out int res))
            {
                MessageBox.Show("Enter Int Year", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                yearText.Focus();
                return false;
            }
            else if (Convert.ToInt32(yearText.Text) > 2050 || Convert.ToInt32(yearText.Text) < -500)
            {
                MessageBox.Show("Enter Valid Year", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                yearText.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function that check if Year that user inputs is correct.
        /// </summary>
        public bool RatingIsValid(TextBox ratingText)
        {
            if (!double.TryParse(ratingText.Text, out double res))
            {
                MessageBox.Show("Input must be a number", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                ratingText.Focus();
                return false;
            }
            else if (Convert.ToDouble(ratingText.Text) < 0 || Convert.ToDouble(ratingText.Text) > 10)
            {
                MessageBox.Show("Rating must be >= 0 and <= 10", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                ratingText.Focus();
                return false;
            }

            return true;
        }


        /// <summary>
        /// Function that check if Year that user inputs is correct.
        /// </summary>
        public bool PagesIsValid(TextBox pagesText)
        {
            if (!int.TryParse(pagesText.Text, out int res))
            {
                MessageBox.Show("Input must be a number", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                pagesText.Focus();
                return false;
            }
            else if (Convert.ToInt32(pagesText.Text) < 0 )
            {
                MessageBox.Show("Rating must be >= 0", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                pagesText.Focus();
                return false;
            }

            return true;
        }

    }
}
