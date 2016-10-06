using System;
using System.Diagnostics;
using Syncfusion.SfDataGrid.XForms;
using SyncfusionSample.ViewModels;
using Xamarin.Forms;

namespace SyncfusionSample.Views
{
    public partial class SfDataGridPage : ContentPage
    {
        public SfDataGridPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            SfDataGridPageViewModel viewModel = BindingContext as SfDataGridPageViewModel;
            if (viewModel != null)
            {
                viewModel.BindCollection += (sender, args) =>
                {
                    this.DataGrid.ItemsSource = viewModel.Collection;
                };
            }
        }
    }
}
