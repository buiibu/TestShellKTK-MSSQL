﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AdminTestShell.Pages
{
    /// <summary>
    /// Interaction logic for Admins.xaml
    /// </summary>
    public partial class Admins : Page
    {
        private readonly Database.user9Entities database;
        private ObservableCollection<Database.user> admins;

        public Admins(Database.user9Entities entities)
        {
            InitializeComponent();
            database = entities;

            admins = new ObservableCollection<Database.user>(database.users.Where(u => u.role == 4).ToList());
            var badmins = new Binding();
            badmins.Source = admins;
            lbUsers.SetBinding(ItemsControl.ItemsSourceProperty, badmins);
        }

        private void OnRemoveUserClick (object sender, RoutedEventArgs e)
        {
            var user = lbUsers.SelectedItem as Database.user;
            database.users.Remove(user);
            admins.Remove(user);
            database.SaveChanges();

        }

        private void OnChangeUser(object sender, SelectionChangedEventArgs e)
        {
            bRemoveUser.IsEnabled = lbUsers.SelectedItem != null;
        }
    }
}
