
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
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Dynamic;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using JsonMvvmTest.ModelsNorthWind;
//using CSharpMarkup.Wpf;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for EntityGrid.xaml
    /// </summary>
    /// 
    [INotifyPropertyChanged]

    public partial class EntityGridCustomer : Window
    {
        NorthwindContext ctx = new NorthwindContext();

        public EntityGridCustomer()
        {
            
             InitializeComponent();

       
            Refresh();


        }

  

        protected void Refresh ()
        //protected async Task Refresh ()
        {
            ctx = new NorthwindContext();

            var x = ctx.Customers.Take(10).ToList();
            grdGrid.ItemsSource = ctx.Customers.Local.ToObservableCollection ()  ;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            //ctx.ChangeTracker.DetectChanges();
            //if (ctx.ChangeTracker.HasChanges())
            //{


            //    foreach (var ent in ctx.ChangeTracker.Entries())
            //    {

            //        if ( ent.Entity is Customer cust && ent.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            //        {
            //            var sisi = cust.ExtProp;
            //            sisi.AddedInt = 3;

            //        }

            //        if (ent.State != Microsoft.EntityFrameworkCore.EntityState.Unchanged)
            //            MessageBox.Show("delted");

            //    }


            //}
            //else
            //    MessageBox.Show("No chnage");






            if (ctx.ChangeTracker.HasChanges())
                ctx.SaveChanges();
            else
                MessageBox.Show("No changes");
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {



            var c = grdGrid.SelectedItem as Customer;

            c.CompanyName = DateTime.Now.ToString();
            c.ExtProp.NickName = DateTime.Now.ToString();

   

        }
        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {

        }

        private void grdGrid_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void grdGrid_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }

       }
}
