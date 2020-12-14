using Books365.BLL;
using NLog;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        public AddBook()
        {
            this.InitializeComponent();
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

        private void ButtonAddBook_Click(object sender, RoutedEventArgs e)
        {
            Validator validator = new Validator();
            if (validator.IsEmpty(this.TitleText) || validator.IsEmpty(this.YearText)
                || !validator.YearIsValid(this.YearText) || validator.IsEmpty(this.AuthorText))
            {
                Logger.Info($"Adding books - was failed");
            }
            else
            {
                string title = this.TitleText.Text;
                int year = Convert.ToInt32(this.YearText.Text);
                string author = this.AuthorText.Text;
                Books365.BLL.User u = new Books365.BLL.User();
                u.AddBook(title, year, author);
                Window1 p = new Window1();
                p.Show();
                this.Close();
                Logger.Info($"Book{this.TitleText.Text} was added to library");
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Window1 p = new Window1();
            p.Show();
            this.Close();
        }
    }
}
