using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Books365.BLL;
using OxyPlot;
using OxyPlot.Axes;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            this.InitializeComponent();
            this.ProfileHelper();
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }

        private void ProfileHelper()
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                this.Username.Text = registered_user.FirstName + " " + registered_user.LastName;
                var booksRead = db.ReadingStatuses.Where(u => u.BookStatus == "read");
                var pagesRead = db.ReadingStatuses.Where(u => u.PagesWritten != 0);
                var books = db.Books;
                int totalpages = 0;
                foreach (var readingStatus in pagesRead)
                {
                    totalpages += readingStatus.PagesWritten;
                }

                int[] readISBNs = new int[booksRead.Count()];
                string[] readAuthors = new string[booksRead.Count()];
                int i = 0;
                foreach (var item in booksRead)
                {
                    readISBNs[i] = item.BookISBN;
                    i++;
                }

                i = 0;
                for (i = 0; i < readISBNs.Length - 1; i++)
                {
                    foreach (var item in books)
                    {
                        if (item.ISBN == readISBNs[i])
                        {
                            readAuthors[i] = item.Author;
                        }
                    }
                }

                this.Total.Text += totalpages.ToString();
                this.Booksfinished.Text += booksRead.Count().ToString();

                if (readAuthors.Length != 0)
                {
                    var nameGroup = readAuthors.GroupBy(x => x);
                    var maxCount = nameGroup.Max(g => g.Count());
                    var mostCommons = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();
                    if (mostCommons.Length < 3)
                    {
                        foreach (var item in mostCommons)
                        {
                            this.favouriteautor.Text += item.ToString() + " ";
                        }
                    }
                    else
                    {
                        this.favouriteautor.Text += "Wow. A lot of Authors to Like";
                    }
                }
            }
        }

        private void Edit_Profile_Click(object sender, RoutedEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Main_Menu_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }
}
