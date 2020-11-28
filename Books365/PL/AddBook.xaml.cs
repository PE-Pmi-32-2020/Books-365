using Books365.BLL;
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
            Validator validator = new Validator();
            if (validator.IsEmpty(TitleText) || validator.IsEmpty(YearText) 
                || !validator.YearIsValid(YearText) || validator.IsEmpty(AuthorText)) { }
            else
            {
                Books365.BLL.User u = new Books365.BLL.User();
                u.AddBook(this.TitleText, this.YearText, this.AuthorText);
                Application.Current.Windows.OfType<Window>().
                Where(w => !w.IsVisible).FirstOrDefault().Visibility = Visibility.Visible;
                this.Close();
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
