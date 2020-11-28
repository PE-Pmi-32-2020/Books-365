using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    

    public partial class Notifications : Window
    {
        public ObservableCollection<Notification> Messages{ get; set; }
        public Notifications()
        {
            InitializeComponent();
        }

        Notifier notifier = new Notifier(cfg =>
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

        void OnLoad(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault().Email;
                var notifications = db.Notifications.Where(u => u.Email == currentUserEmail).ToList();

                foreach (var item in notifications)
                {
                    if (Convert.ToDateTime(item.Date) == DateTime.Now.Date)
                    {
                        notifier.ShowInformation($"{item.Message}\n{item.Date}");
                    }
                }
            }
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
            Notification notification = Table.SelectedItem as Notification;
            Messages.Remove(notification);
        }

        private void Load_Table(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault().Email;
                var notifications = db.Notifications.Where(u => u.Email == currentUserEmail).ToList();
                Messages = new ObservableCollection<Notification>();

                foreach (var item in notifications)
                {
                    Messages.Add(item);
                }

                Table.ItemsSource = Messages;
            }
            
        }
    }
}
