using Books365.PL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Books365
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
            using (AppContext db = new AppContext())
            {
                
                var l = db.EmailCurrentUser.ToList();
                if (l.Count == 0)
                {
                    Login w1 = new Login();
                    w1.Show();
                    this.Close();
                }
                else
                {
                    Notifications w1 = new Notifications();
                    w1.Show();
                    this.Close();
                  
                }
            }
        }
    }
}
