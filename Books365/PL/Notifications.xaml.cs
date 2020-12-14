using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;
using NLog;
using Microsoft.Data.SqlClient;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    public partial class Notifications : Window
    {
        public ObservableCollection<Notification> Messages { get; set; }

        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        public Notifications()
        {
            this.InitializeComponent();
        }

        private readonly Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.TopRight,
                offsetX: 10,
                offsetY: 10);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AppContext db = new AppContext())
                {
                    var currentUserEmail = db.EmailCurrentUser.FirstOrDefault().Email;
                    var notifications = db.Notifications.Where(u => u.Email == currentUserEmail).ToList();

                    foreach (var item in notifications)
                    {
                        if ((Convert.ToDateTime(item.Date) == DateTime.Now.Date) && (item.IsEnabled is true))
                        {
                            this.notifier.ShowInformation($"{item.Message}\n{item.Date}");
                            Logger.Info($"Notifications {item.Message} - was sended to {currentUserEmail}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Database connection is not avaliable {ex.Message}");
            }
        }

        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNotification notification = new AddNotification();
            notification.Show();
            this.Hide();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            this.Close();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Notification notification = this.Table.SelectedItem as Notification;
            this.Messages.Remove(notification);
            Logger.Info($"Notification was deleted - {notification.Message}");
        }

        private void Load_Table(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AppContext db = new AppContext())
                {
                    var currentUserEmail = db.EmailCurrentUser.FirstOrDefault().Email;
                    var notifications = db.Notifications.Where(u => u.Email == currentUserEmail).ToList();
                    this.Messages = new ObservableCollection<Notification>();

                    foreach (var item in notifications)
                    {
                        this.Messages.Add(item);
                    }

                    this.Table.ItemsSource = this.Messages;
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Database connection is not available {ex}");
            }
        }

        private void Table_CellEditEnding(object sender, System.Windows.Controls.DataGridCellEditEndingEventArgs e)
        {
            var el = e.EditingElement.DataContext as Notification;
            try
            {
                using (AppContext db = new AppContext())
                {
                    Notification change = db.Notifications.Where(x => x.Message == el.Message).FirstOrDefault();
                    change.IsEnabled = !el.IsEnabled;
                    db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Database connection is not available {ex}");
            }
        }
    }
}
