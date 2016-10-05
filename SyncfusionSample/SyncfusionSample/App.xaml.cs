using Prism.Unity;
using SyncfusionSample.Views;

namespace SyncfusionSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("SfTreeMapPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SfDataGridPage>();
            Container.RegisterTypeForNavigation<SfBusyIndicatorPage>();
            Container.RegisterTypeForNavigation<SfTreeMapPage>();
        }
    }
}
