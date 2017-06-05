﻿using AbstractProperty;
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

namespace PropertiesManager.Screens
{
    /// <summary>
    /// Lógica de interacción para MainPageProperties.xaml
    /// </summary>
    public partial class MainPageProperties : Page
    {
        public MainPageProperties()
        {
            InitializeComponent();
            List<Property> properties = Artificial_database.DummyClass.Properties;
            lvProperties.ItemsSource = properties;
        }

        private void btnViewUsers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPageUsers());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

       }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProperty());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Window1 deleteWindow = new Window1();
            deleteWindow.Show();
        }
    }
}
