using System.Windows;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Input;
using NLog;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        public Window1()
        {
            this.InitializeComponent();
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }

        private void Notifications_button_Click(object sender, RoutedEventArgs e)
        {
            Notifications n = new Notifications();
            n.Show();
            this.Close();
        }

        private void Simple_search_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AppContext db = new AppContext())
                {
                    db.Books.Load();
                    this.BooksGrid.ItemsSource = (from book in db.Books where book.Title == this.search_textbox.Text join readingstatus in db.ReadingStatuses on book.ISBN equals readingstatus.BookISBN where readingstatus.UserEmail==db.EmailCurrentUser.FirstOrDefault().Email select new { Id = book.ISBN, Title = book.Title, Author = book.Author, Year = book.Year, Rating = readingstatus.Rating, Pages = readingstatus.PagesWritten, ReadingStatus = readingstatus.BookStatus }).ToList();

                    //this.BooksGrid.ItemsSource = db.Books.Local.ToBindingList()
                                                    //.Where(b => b.Title == this.search_textbox.Text);
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Database connection is not avaliable {ex.Message}");
            }
        }

        private void Reset_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AppContext db = new AppContext())
                {
                    db.Books.Load();
                    this.BooksGrid.ItemsSource = (from book in db.Books join readingstatus in db.ReadingStatuses on book.ISBN equals readingstatus.BookISBN select new { Id = book.ISBN, Title = book.Title, Author = book.Author, Year = book.Year, Rating = readingstatus.Rating, Pages = readingstatus.PagesWritten, ReadingStatus = readingstatus.BookStatus }).ToList();

                    //this.BooksGrid.ItemsSource = db.Books.Local.ToBindingList()
                    //.Where(b => b.Title == this.search_textbox.Text);
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Database connection is not avaliable {ex.Message}");
            }
        }

        private void change_status_button_Click(object sender, RoutedEventArgs e)
        {
            EditStatus editStatus = new EditStatus();
            editStatus.Show();
            this.Close();
        }

        private void Log_out_button_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                Logger.Info($"User {db.EmailCurrentUser.First().Email.ToString()}  -  was logged out");

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
            this.Close();
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

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private static ObservableCollection<T> ToObservableCollection<T>(IEnumerable<T> en)
        {
            return new ObservableCollection<T>(en);
        }

        private void BooksGrid_Loaded(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                this.BooksGrid.ItemsSource = ToObservableCollection(from book in db.Books join readingstatus in db.ReadingStatuses on book.ISBN equals readingstatus.BookISBN where readingstatus.UserEmail == db.EmailCurrentUser.First().Email select new { Id = book.ISBN, Title = book.Title, Author = book.Author, Year = book.Year, Rating = readingstatus.Rating, Pages = readingstatus.PagesWritten, ReadingStatus = readingstatus.BookStatus });
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                this.user_name_text_block.Text = registered_user.FirstName;
            }
        }
    }
}
