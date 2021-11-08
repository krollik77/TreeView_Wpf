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

namespace TreeView_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (First.Visibility == Visibility.Hidden)
        //        First.Visibility = Visibility.Visible;
        //    else
        //        First.Visibility = Visibility.Hidden;
        //}

        //private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        //{
        //    if (Second.Visibility == Visibility.Hidden)
        //        Second.Visibility = Visibility.Visible;
        //    else
        //        Second.Visibility = Visibility.Hidden;
        //}

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (First.Visibility == Visibility.Hidden)
                First.Visibility = Visibility.Visible;
            else
                First.Visibility = Visibility.Hidden;
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (Second.Visibility == Visibility.Hidden)
                Second.Visibility = Visibility.Visible;
            else
                Second.Visibility = Visibility.Hidden;
        }
    }
}
