using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
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

        ModelsNorthWind.NorthwindContext context = new ModelsNorthWind.NorthwindContext();

        public MainWindow()
        {
            InitializeComponent();
            Refresh3();

        }

        public void Refresh ()
        {
            var ds  = context.Orders.Take(10).ToList();
            //ds.ToOb
            grd1.ItemsSource = context.Orders.Local.ToObservableCollection();
            grd2.ItemsSource = context.Orders.Local.ToObservableCollection();

            //essageBox.Show($"First few customers {y.Count}");


            //var output =  context.Database.GetDbConnection()   await cnn.QueryAsync<ItemModel>($"select * from {tableName}", new DynamicParameters());
            //return ds.ToObservableCollection();



        }


        public void Refresh1()
        {
            // Delete not synced

            var ds = context.Orders.Take(10).ToList();
            grd1.ItemsSource = context.Orders.Local.ToList () ;
            grd2.ItemsSource = context.Orders.Local.ToList () ;



        }

        public void Refresh2()
        {
            // Delete synced
            var ds = context.Orders.Take(10).ToList();
            grd1.ItemsSource = ds;
            grd2.ItemsSource = ds;



        }


        public void Refresh3()
        {
            // Delete not synced
            var ds1 = context.Orders.Take(10).ToList();
            var ds2 = context.Orders.Take(10).ToList();
            grd1.ItemsSource = ds1;
            grd2.ItemsSource = ds2;



        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
                MessageBox.Show("Change will be saved");

        }
    }
}