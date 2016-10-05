using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reactive.Bindings;
using Syncfusion.SfBusyIndicator.XForms;

namespace SyncfusionSample.ViewModels
{
    public class SfBusyIndicatorPageViewModel : BindableBase
    {
        public ReactiveProperty<bool> IsBusy { get; set; }

        public SfBusyIndicatorPageViewModel()
        {
            IsBusy = new ReactiveProperty<bool> { Value = true };

            ExecuteBusyFunction();
        }

        private async void ExecuteBusyFunction()
        {
            await Task.Delay(5 * 1000);

            IsBusy.Value = false;
        }
    }
}
