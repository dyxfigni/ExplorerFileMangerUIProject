﻿using System;
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
using ExplorerFileMangerUIProject.ViewModelContainer;

namespace ExplorerFileMangerUIProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel viewModel = new MainViewModel();
            DirFlViewLstb.ItemsSource = viewModel.DirAndFls;
        }

        private void DirFlViewLstb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCountry = DirFlViewLstb.SelectedItem.ToString();
            
        }
    }
}
