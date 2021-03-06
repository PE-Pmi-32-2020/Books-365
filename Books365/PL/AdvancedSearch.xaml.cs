﻿using System.Windows;
using System.Data;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Input;

namespace Books365.PL
{
    /// <summary>
    /// Interaction logic for AdvancedSearch.xaml
    /// </summary>
    public partial class AdvancedSearch : Window
    {
        public AdvancedSearch()
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

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                Window1 w = new Window1();
                w.Show();
                db.Books.Load();
                w.BooksGrid.ItemsSource = (from book in db.Books where book.Title == this.TitleText.Text && Convert.ToString(book.Year) == this.YearText.Text && book.Author == this.AuthorText.Text join readingstatus in db.ReadingStatuses on book.ISBN equals readingstatus.BookISBN select new { Title = book.Title, Author = book.Author, Year = book.Year, Rating = readingstatus.Rating, Pages = readingstatus.PagesWritten, ReadingStatus = readingstatus.BookStatus }).ToList();
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            this.Close();
        }
        //private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var move = sender as System.Windows.Controls.Grid;
        //    var win = Window.GetWindow(move);
        //    win.DragMove();
        //}
    }
}
