using System.Windows;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            using (AppContext db = new AppContext())
            {
                db.Books.Load();
                db.ReadingStatuses.Load();

                
                //BooksGrid.ItemsSource = db.Books.Local.ToBindingList();
                var join = from book in db.Books join readingstatus in db.ReadingStatuses on book.ISBN equals readingstatus.BookISBN select new { Title = book.Title, Author = book.Author, Year = book.Year, Rating = readingstatus.Rating, Pages = readingstatus.PagesWritten };
                BooksGrid.ItemsSource = join;
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var Registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                user_name_text_block.Text = Registered_user.FirstName + " " + Registered_user.LastName;
            }
        }

        private void notifications_button_Click(object sender, RoutedEventArgs e)
        {
            Notifications n = new Notifications();
            n.Show();
            this.Close();
        }

        private void simple_search_button_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Load();
                BooksGrid.ItemsSource = db.Books.Local.ToBindingList()
                                                .Where(b=>b.Title==search_textbox.Text);
            }
        }

        private void advanced_search_button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void log_out_button_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                db.EmailCurrentUser.Remove(db.EmailCurrentUser.FirstOrDefault());
            }

            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void add_book_button_Click(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
