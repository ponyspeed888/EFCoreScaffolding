﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //ModelsNorthWind.NorthwindContext context = new ModelsNorthWind.NorthwindContext();
            //var y = context.Customers.Take(3).ToList();
            //MessageBox.Show ($"First few customers {y.Count}");

        }
    }
}