using System.Windows;
using System.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for AdvancedSearch.xaml
    /// </summary>
    public partial class AdvancedSearch : Window
    {
        public AdvancedSearch()
        {
            this.InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                Window1 w = new Window1();
                w.Show();
                db.Books.Load();
                w.BooksGrid.ItemsSource = db.Books.Local.ToBindingList().Where(b => (this.TitleText.Text == string.Empty || b.Title == this.TitleText.Text) && (this.YearText.Text == string.Empty || Convert.ToString(b.Year) == this.YearText.Text) && (this.AuthorText.Text == string.Empty || b.Author == this.AuthorText.Text));
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            this.Close();
        }
    }
}
