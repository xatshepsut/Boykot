using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using PhoneApp1.ViewModels;

namespace PhoneApp1
{
    public partial class ProductsPage : PhoneApplicationPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }
        public static ProductModel viewModel { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (viewModel == null)
                viewModel = new ProductModel();
            if (!viewModel.IsDataLoaded)
            {
                viewModel.LoadData();
            }
            DataContext = viewModel;
        }
    }
   
}