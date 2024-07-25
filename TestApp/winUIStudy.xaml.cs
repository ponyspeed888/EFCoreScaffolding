using System;
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
using System.Windows.Shapes;
using TestApp.ModelsNorthWind;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for winUIStudy.xaml
    /// </summary>
    public partial class winUIStudy : Window
    {

        ModelsNorthWind.NorthwindContext context = new ModelsNorthWind.NorthwindContext();

        public Order firstOrder { get; set; }
        public string firstOrder1 { get; set; } = "abc";


        public winUIStudy()
        {
            InitializeComponent();
            this.DataContext = this;
            
        }

        public void Refresh()
        {
            context = new ModelsNorthWind.NorthwindContext();

            var ds = context.Orders.Take(10).ToList();
            //ds.ToOb
            grd1.ItemsSource = context.Orders.Local.ToObservableCollection();
            firstOrder = ds[0];
            firstOrder1 = DateTime.Now.ToString();

            //grd2.ItemsSource = context.Orders.Local.ToObservableCollection();

            //essageBox.Show($"First few customers {y.Count}");


            //var output =  context.Database.GetDbConnection()   await cnn.QueryAsync<ItemModel>($"select * from {tableName}", new DynamicParameters());
            //return ds.ToObservableCollection();



        }


        public void Refresh1()
        {
            // Delete not synced

            context = new ModelsNorthWind.NorthwindContext();
            var ds = context.Orders.Take(10).ToList();
            grd1.ItemsSource = context.Orders.Local.ToList();
            //grd2.ItemsSource = context.Orders.Local.ToList();
            firstOrder = ds[0];



        }

        public void Refresh2()
        {
            // Delete synced
            context = new ModelsNorthWind.NorthwindContext();
            var ds = context.Orders.Take(10).ToList();
            grd1.ItemsSource = ds;
            //grd2.ItemsSource = ds;
            firstOrder = ds[0];



        }


        public void Refresh3()
        {
            // Delete not synced
            context = new ModelsNorthWind.NorthwindContext();
            var ds1 = context.Orders.Take(10).ToList();
            var ds2 = context.Orders.Take(10).ToList();
            grd1.ItemsSource = ds1;
            //grd2.ItemsSource = ds2;
            firstOrder = ds1[0];



        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
                MessageBox.Show("Change will be saved");

        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            //txtEdit.Text = txtEdit.Text + "1";

            //context.Orders.First().Freight  = 333 ; ;

            //context.Orders.Local.First().Freight = 333; ;


            //rder o = ((ObservableCollection<Order>)grd1.ItemsSource).First(); 
            //Order o = context.Orders.Local.First();
            firstOrder.Freight = 77;


        }

        private void cboItemsSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch ( cboItemsSource.SelectedIndex)
            {

                case 0: Refresh(); break;
                case 1: Refresh1(); break;
                case 2: Refresh2(); break;
                case 3: Refresh3(); break;


            }
        }
    }
}
