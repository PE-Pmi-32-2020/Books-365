﻿using Books365.PL;
using Microsoft.Data.SqlClient;
using NLog;
using System;
using System.Collections.Generic;
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
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            this.InitializeComponent();
            try
            {
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
                        Window1 w1 = new Window1();
                        w1.Show();
                        this.Close();
                        Logger.Info($"User {db.EmailCurrentUser.First().Email} - was logged into system");
                    }
                }
            }
            catch (SqlException ex)
            {
                Logger.Error($"Connection is not available {ex.Message}");
            }
        }
    }
}
