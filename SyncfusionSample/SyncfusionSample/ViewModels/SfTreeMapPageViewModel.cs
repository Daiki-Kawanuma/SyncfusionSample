using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Syncfusion.SfTreeMap.XForms;
using Xamarin.Forms;

namespace SyncfusionSample.ViewModels
{
    public class SfTreeMapPageViewModel : BindableBase
    {
        public ObservableCollection<CustomTreeMapItem> TreeMapItems { get; set; }

        public SfTreeMapPageViewModel()
        {
            Debug.WriteLine("Called: SfTreeMapPageViewModel");
            var collection = new ObservableCollection<CustomTreeMapItem>
            {
                new CustomTreeMapItem()
                {
                    WeightValue = 10,
                    ImageSource = "https://pbs.twimg.com/profile_images/751091357825929216/RiXRpWA3.jpg",
                    Text = "サンテア＠三葉"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 15,
                    ImageSource = "https://pbs.twimg.com/profile_images/763183255528976385/k1LorAyM.jpg",
                    Text = "くぅ@にゃー"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 30,
                    ImageSource = "https://pbs.twimg.com/profile_images/710273385708716032/Ikm3ox3k.jpg",
                    Text = "masatoru@やせて調子いいです（再"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 25,
                    ImageSource = "https://pbs.twimg.com/profile_images/457720982090682368/hA3rh3Rf.png",
                    Text = "クワーティ＠求職中"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 40,
                    ImageSource = "https://pbs.twimg.com/profile_images/560648385292562432/ZILxrWU-.jpeg",
                    Text = "三者三羊@オータガー"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 35,
                    ImageSource = "https://pbs.twimg.com/profile_images/728040828665405445/dRbYWha_.jpg",
                    Text = "ゆうか@撤退準備中"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 40,
                    ImageSource = "https://pbs.twimg.com/profile_images/717249520220770305/t1GsZoIc.jpg",
                    Text = "nuits.jp"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 60,
                    ImageSource = "https://pbs.twimg.com/profile_images/616293895261937664/heCywSfh.png",
                    Text = "これがあめいの選択だよ"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 80,
                    ImageSource = "https://pbs.twimg.com/profile_images/633074634435379200/qJu6ECTX.jpg",
                    Text = "Atsushi Eno"
                },
                new CustomTreeMapItem()
                {
                    WeightValue = 80,
                    ImageSource = "https://pbs.twimg.com/profile_images/747601253266395136/2HeCGdiG.jpg",
                    Text = "田淵 義人＠エクセルソフト"
                }
            };

            TreeMapItems = collection;
        }
    }

    public class CustomTreeMapItem
    {
        public int WeightValue { get; set; }

        public ImageSource ImageSource { get; set; }

        public string Text { get; set; }
    }
}
