using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using Books365.BLL;
using NLog;
using Microsoft.Data.SqlClient;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for AddNotification.xaml
    /// </summary>
    public partial class AddNotification : Window
    {
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        public AddNotification()
        {
            this.InitializeComponent();
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AppContext db = new AppContext())
                {
                    var date = Convert.ToDateTime(this.Picker.Text);
                    var message = this.Message.Text.ToString();
                    var currentUserEmail = db.EmailCurrentUser.FirstOrDefault().Email;
                    db.Notifications.Add(new Notification
                    {
                        Message = message,
                        Date = date,
                        Email = currentUserEmail,
                    });
                    db.SaveChanges();
                    this.Close();
                    Logger.Info($"Notification {message} - was added by {currentUserEmail}");
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Database connection is not avaliable {ex.Message}");
            }

            Notifications window = new Notifications();
            window.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<Window>().
            Where(w => !w.IsVisible).FirstOrDefault().Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
