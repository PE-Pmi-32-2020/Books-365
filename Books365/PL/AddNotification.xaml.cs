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

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for AddNotification.xaml
    /// </summary>  
    
    public partial class AddNotification : Window
    {
        private Notifications not;
        public AddNotification()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
           
            using (AppContext db = new AppContext())
            {
                var date = Convert.ToDateTime(time.Text);
                var message = Message.Text.ToString();
                var currentUserEmail = db.EmailCurrentUser.FirstOrDefault().ToString();
                db.Notifications.Add(new Notification
                {
                    Message = message,
                    Date = date,
                    Email = currentUserEmail
                });
                //not.Table.Items.Add(new Notification
                //{
                //    Message = message,
                //    Date = date,
                //    Email = currentUserEmail
                //});
                db.SaveChanges();
                this.Close();
                
                //Notifications window = new Notifications();
                //window.Show();
                
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
