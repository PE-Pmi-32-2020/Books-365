using Books365.BLL;
using Microsoft.Data.SqlClient;
using NLog;
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

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for EditStatus.xaml
    /// </summary>
    public partial class EditStatus : Window
    {
        public EditStatus()
        {
            this.InitializeComponent();
        }

        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        private void Button_change_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                try
                {
                    Validator v = new Validator();

                    Book book = db.Books.Where(u => u.ISBN == Convert.ToInt32(this.BookISBN.Text)).FirstOrDefault();
                    ReadingStatus rs = db.ReadingStatuses.Where(u => u.BookISBN == Convert.ToInt32(this.BookISBN.Text)).FirstOrDefault();
                    if (this.PagesRead.Text != "Pages Read" && this.PagesRead.Text != string.Empty && v.PagesIsValid(this.PagesRead))
                    {
                        rs.PagesWritten += int.Parse(this.PagesRead.Text);
                    }

                    if (this.FinishedBook.IsChecked ?? false)
                    {
                        rs.BookStatus = "read";
                    }

                    if (this.RatingText.Text != "Rating" && this.RatingText.Text != string.Empty && v.RatingIsValid(this.RatingText))
                    {
                        rs.Rating = Convert.ToDouble(this.RatingText.Text);
                    }

                    db.SaveChanges();
                }
                catch (SqlException ex)
                {
                    Logger.Error($"Database connection is not avaliable {ex.Message}");
                }
            }

            Window1 window = new Window1();
            window.Show();
            this.Close();

        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
    }
}
