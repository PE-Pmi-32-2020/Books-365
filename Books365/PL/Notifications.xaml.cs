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

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    

    public partial class Notifications : Window
    {
        private ObservableCollection<Notification> Messages{ get; set; }
        public Notifications()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNotification notification = new AddNotification();
            notification.Show();
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
