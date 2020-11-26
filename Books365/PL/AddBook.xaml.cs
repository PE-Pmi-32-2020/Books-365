using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void ButtonAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (TitleText.Text.Length == 0)
            {
                MessageBox.Show("Enter Book Title", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                TitleText.Focus();
            }
            else if (YearText.Text.Length == 0)
            {
                MessageBox.Show("Enter Book Year", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                YearText.Focus();
            }
            else if (!int.TryParse(YearText.Text, out int res))
            {
                MessageBox.Show("Enter Valid Year", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                YearText.Focus();
            }
            else if(Convert.ToInt32(YearText.Text)>2050 || Convert.ToInt32(YearText.Text) < 1)
            {
                MessageBox.Show("Enter Valid Year", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                YearText.Focus();
            }
            else if (AuthorText.Text.Length == 0)
            {
                MessageBox.Show("Enter Author", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                AuthorText.Focus();
            }
            else
            {
                using (AppContext db = new AppContext())
                {

                    db.Books.Add(new Book
                    {
                        Title = TitleText.Text,
                        Year = Convert.ToInt32(YearText.Text),
                        Author = AuthorText.Text

                    });

                    db.SaveChanges();
                    Application.Current.Windows.OfType<Window>().
                    Where(w => !w.IsVisible).FirstOrDefault().Visibility = Visibility.Visible;
                    this.Close();

                }
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<Window>().
            Where(w => !w.IsVisible).FirstOrDefault().Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
