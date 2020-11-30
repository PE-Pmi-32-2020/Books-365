using System.Windows;
using System.Data;
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
            this.InitializeComponent();

            using (AppContext db = new AppContext())
            {
                this.BooksGrid.ItemsSource = (from book in db.Books join readingstatus in db.ReadingStatuses on book.ISBN equals readingstatus.BookISBN select new { Title = book.Title, Author = book.Author, Year = book.Year, Rating = readingstatus.Rating, Pages = readingstatus.PagesWritten }).ToList();

                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                this.user_name_text_block.Text = registered_user.FirstName + " " + registered_user.LastName;
            }
        }

        private void Notifications_button_Click(object sender, RoutedEventArgs e)
        {
            Notifications n = new Notifications();
            n.Show();
            this.Close();
        }

        private void Simple_search_button_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Load();
                this.BooksGrid.ItemsSource = db.Books.Local.ToBindingList()
                                                .Where(b => b.Title == this.search_textbox.Text);
            }
        }

        private void Advanced_search_button_Click(object sender, RoutedEventArgs e)
        {
            AdvancedSearch search = new AdvancedSearch();
            search.Show();
            this.Close();
        }

        private void Log_out_button_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                db.EmailCurrentUser.Remove(db.EmailCurrentUser.FirstOrDefault());
                db.SaveChanges();
            }

            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Add_book_button_Click(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void User_name_text_block_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Close();
        }

        private void User_name_text_block_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.user_name_text_block.Opacity = 0.5;
        }

        private void User_name_text_block_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.user_name_text_block.Opacity = 1;
        }
    }
}
