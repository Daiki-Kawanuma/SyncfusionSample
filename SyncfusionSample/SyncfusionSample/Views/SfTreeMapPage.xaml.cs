using SyncfusionSample.ViewModels;
using Xamarin.Forms;

namespace SyncfusionSample.Views
{
    public partial class SfTreeMapPage : ContentPage
    {
        public SfTreeMapPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var viewModel = BindingContext as SfTreeMapPageViewModel;
            if (viewModel != null)
            {
                viewModel.BindCollection += (sender, args) =>
                {
                    this.TreeMap.DataSource = viewModel.TreeMapItems;
                };
            }
        }
    }
}
