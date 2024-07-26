#if SQLITE
using Database8.ModelsNorthWind;
#else
using Database8.ModelsNorthwindSQL;
#endif

using Database8;

using Database8.ModelsVhdDb;
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
using HandlebarsDotNet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
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

        public ObservableDictionary<string, object> dicttest { get; set; } = new ObservableDictionary<string, object>();

        [ObservableProperty]
        private string _data2 = "aisi";
        //public string _data2 { get; set; } = "aisi";
        public EntityGridCustomer()
        {
            
            dicttest["a"] = "a";
            dicttest["b"] = "b";
            InitializeComponent();

            //dicttest.PropertyChanged += Dicttest_PropertyChanged;




            //dicttest.PropertyChanged += this.PropertyChanged;
            this.DataContext = this;
            //JsonColumnHelper.AddStaticJsonColumns<CustomerExtProp>(grdGrid, nameof(Customer.ExtProp));


            string table = nameof(Customer);
            table = "Customer";
            var sq1l = $"select KeyName from ExtPropDef where TableName = '{table}' ";
            //var yy1 = ctx.Database.SqlQuery<int>($"select ExtPropDictID from ExtPropDef ").ToList();

            var keys = ctx.Database.SqlQuery<string>($"select KeyName from ExtPropDef where TableName = 'Customer' ").ToList();
            cboKeys.ItemsSource = keys;




            //Refresh();


        }

        private void Dicttest_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var yy = 3;
            //this.OnPropertyChanged("dicttest");
            this.OnPropertyChanged(e.PropertyName);

            //throw new NotImplementedException();
        }

        protected void Refresh ()
        //protected async Task Refresh ()
        {

            //var vhds = ctx.Vhds.ToList();
            //grdGrid.ItemsSource = vhds;

#if false
            var Steps = ctx.SetupSteps.ToList();
            grdGrid.ItemsSource = Steps;

#else
            ctx = new NorthwindContext();

            var SelectedKeys = cboKeys.SelectedItems?.Cast<string>().ToList();
            if (SelectedKeys != null )
                JsonColumnHelper.AddDynamicJsonColumns(grdGrid, SelectedKeys);


   
            var yyy = ctx.Customers.Count();

            //var Steps = ctx.Customers.Take(2).ToList();
            var Steps = ctx.Customers.Where (x => x.CustomerId.ToLower ().StartsWith ("a")).Take(3).ToList();


            //grdGrid.ItemsSource = ctx.SetupSteps.Local.ToList() ;
            grdGrid.ItemsSource = ctx.Customers.Local.ToObservableCollection ()  ;
            //grdGridSf.ItemsSource = ctx.Customers.Local.ToObservableCollection ()  ;




#endif


            //grdGrid.ItemsSource = ctx.Vhds.Local.ToObservableCollection();

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


            //c.ExtPropDynamic.PropertyChanged += c.ExtPropDynamic_PropertyChanged;
            //c.PropertyChanged += c.ExtPropDynamic_PropertyChanged;



            //var yy = c.ExtPropDynamic;
            //yy["ContentText"] = DateTime.Now.ToString();

            //c.Fax = DateTime.Now.ToString();
            //var zz = yy.ToString();

            //c.CompanyName = c.CompanyName + "111";


            //if (yy != null)
            //{
            //    yy.NickName = "sisi";
            //}
            //CustomerExtProp ep = new CustomerExtProp();
            //ep.NickName = "Jy1";
            //ep.NumberOfVisit = 3;
            //c.ExtProp = ep;


            //if (c.DictOnly == null) { c.DictOnly = new ObservableDictionary.ObservableStringDictionary< string>(); }
            ////if (c.DictOnly == null) { c.DictOnly = new ObservableDictionary<string, string>(); }
            //    c.DictOnly.Add("x", "y");

            //c.DictOnly.Add("ss", "yy");
            //var dd = c.DictOnly;
            //c.DictOnly = null;
            ////c.DictOnly = dd;


        }

        private void btnEditSetupDetail_Click(object sender, RoutedEventArgs e)
        {
            //var c = grdGrid.SelectedItem as Customer; 
            //if ( c.CustomerDict == null ) { c.CustomerDict = new CustomerDictType(); c.CustomerDict.ContentText = "abc"; }
            ////if (c.DictOnly == null ) { c.DictOnly = new Dictionary<string, string>(); c.DictOnly.Add("a", "b"); }
            //if (c.DictOnly == null ) { c.DictOnly = new ObservableDictionary.ObservableStringDictionary<string>(); }
            ////if (c.DictOnly == null ) { c.DictOnly = new ObservableDictionary<string, string>(); }
            //winCustomerDetail.ObjectToEdit = c;
            //var win = new winCustomerDetail();
            //win.ShowDialog ();



        }

        private void btnEditDictOnly_Click(object sender, RoutedEventArgs e)
        {

        }

        //public  ObservableDictionary<string, string>? d1 { get; set;  } = new ObservableDictionary<string, string> () ;

        public  string d2 { get; set; } = "a";
        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {

            //var c = grdGrid.SelectedItem as Customer;


            //MessageBox.Show(c.ExtPropDynamic.dyna1);
            //return;



        dynamic obj = new ExpandoObject();

            // Usage
        //    MyObject obj = new MyObject { Name = "John" };
        obj.AdditionalData = new Dictionary<string, object>();
        obj.AdditionalData["Age"] = 30;
        obj.AdditionalData["City"] = "New York";

        // Accessing additional data
        if (obj.AdditionalData.ContainsKey("Age"))
        {
            int age = (int)obj.AdditionalData["Age"];
        }










    dynamic myDictionary = new Dictionary<string, object>();

            myDictionary.someKey = "Some Value";
            myDictionary[10] = 3.14; // Numeric key

            // You can even use dynamic objects as keys or values
            dynamic keyObject = new { Name = "John", Age = 30 };
            myDictionary[keyObject] = "Custom Object Data";





            //dynamic c = grdGrid.SelectedItem ;
            //var c = grdGrid.SelectedItem as Customer;

            //c["aaa"] = "bbb";

            //MessageBox.Show(c["aaa"].ToString () );

            //MessageBox.Show(c.ExtPropDynamic.dyna1);


            ////1.Add("x", "y");
            ////var y = d1.Count();
            //d2 = d2 + d2 ;

            //BindingExpression binding = txtTest1.GetBindingExpression(TextBox.TextProperty);
            ////binding.UpdateSource();
            //binding.UpdateTarget ();

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

        private void grdGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                Customer editedValue = (Customer) e.Row.Item;


               // e.Cancel = true;


        
            }
        }

        private void grdGrid_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            Customer c = (Customer)e.Row.Item;
            if (c.ExtProp == null)
                c.ExtProp = new CustomerExtProp();



        }

        private void cboKeys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
        }

        private void btnEditExtPropDynamic_Click(object sender, RoutedEventArgs e)
        {


            var c = grdGrid.SelectedItem as Customer;

            winEditDict.ObjectToEdit = c.ExtPropDynamic;
            winEditDict win = new winEditDict();
            win.ShowDialog();


            //var yy = c.ExtPropDynamic;
            //yy["ContentText"] = DateTime.Now.ToString();
            //var newDict = new ObservableDictionary<string, object>();
            //foreach ( var k in yy.Keys )
            //    newDict[k] = yy[k];
            //c.ExtPropDynamic = newDict;



            //c.ExtPropDynamic = c.ExtPropDynamic.Clone ( c.ExtPropDynamic) ;


            //c.ExtPropDynamic = (ObservableDictionary<string, object>)yy.ToDictionary();

            //c.ExtPropDynamic = new ObservableDictionary<string, object>(yy);


            //c.Fax = DateTime.Now.ToString();


        }
    }
}
