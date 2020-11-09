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
using System.Collections.Generic;
using OxyPlot;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
           
            InitializeComponent();
            Func();
        }
        void Func()
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault();
                var Registered_user = db.Users
                                      .Where(u => u.Email == currentUserEmail.Email).FirstOrDefault();
                Username.Text = Registered_user.FirstName+" "+ Registered_user.LastName;
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
                int i= 0;
                foreach (var item in booksRead)
                {
                    readISBNs[i] = item.BookISBN;
                    i++;
                }
                i = 0;
                
                for ( i = 0; i < readISBNs.Length-1; i++)
                {
                    foreach (var item in books)
                    {
                        if (item.ISBN == readISBNs[i])
                            readAuthors[i] = item.Author;
                    }
                }

                Total.Text += totalpages.ToString();
                Booksfinished.Text += booksRead.Count().ToString();

                var nameGroup = readAuthors.GroupBy(x => x);
                var maxCount = nameGroup.Max(g => g.Count());
                var mostCommons = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();
                if (mostCommons.Length < 3)
                {
                    foreach (var item in mostCommons)
                    {
                        favouriteautor.Text += item.ToString() + " ";
                    }
                }
                else
                    favouriteautor.Text += "Wow. A lot of Authors to Like";
                List< DataPoint > Points = new List<DataPoint> { };
                Points.Add(new DataPoint(0, 4));
                Points.Add(new DataPoint(2, 8));
                Points.Add(new DataPoint(4, 3));
                Points.Add(new DataPoint(5, 6));
                Points.Add(new DataPoint(7, 5));
                Points.Add(new DataPoint(8, 9));
                Points.Add(new DataPoint(9, 10));
                Points.Add(new DataPoint(10, 1));
                Points.Add(new DataPoint(11, 2));
            }
           
        }
        
    }
}
