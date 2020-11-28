using Books365.BLL;
using System.Linq;
using System.Windows;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public AddBook()
        {
            this.InitializeComponent();
        }

        private void ButtonAddBook_Click(object sender, RoutedEventArgs e)
        {
            Validator validator = new Validator();
            if (validator.IsEmpty(this.TitleText) || validator.IsEmpty(this.YearText)
                || !validator.YearIsValid(this.YearText) || validator.IsEmpty(this.AuthorText))
            {
            }
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
