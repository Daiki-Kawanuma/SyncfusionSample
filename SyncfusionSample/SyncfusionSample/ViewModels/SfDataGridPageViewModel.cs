using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace SyncfusionSample.ViewModels
{
    public class SfDataGridPageViewModel : BindableBase, INavigationAware
    {
        public event EventHandler<EventArgs> BindCollection;

        public ObservableCollection<dynamic> Collection { get; set; }

        public SfDataGridPageViewModel()
        {
            
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            switch (new Random().Next() % 3)
            {
                case 0:
                    Collection = OrderInfo.GenerateOrders();

                    break;
                case 1:
                    Collection = TwitterUser.GenerateUsers();

                    break;
                case 2:
                    Collection = Idol.GenerateIdols();
                    break;
            }

            BindCollection?.Invoke(this, EventArgs.Empty);
        }

        public class OrderInfo
        {
            public int OrderId { get; set; }
            public string CustomerId { get; set; }
            public string Customer { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }

            public OrderInfo(int orderId, string customerId, string country, string customer, string shipCity)
            {
                this.OrderId = orderId;
                this.CustomerId = customerId;
                this.Customer = customer;
                this.ShipCountry = country;
                this.ShipCity = shipCity;
            }

            public static ObservableCollection<dynamic> GenerateOrders()
            {
                var collection = new ObservableCollection<dynamic>
                {
                    new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"),
                    new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F."),
                    new OrderInfo(1003, "Ant Fuller", "Mexico", "ANTON", "México D.F."),
                    new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"),
                    new OrderInfo(1005, "Tim Adams", "Sweden", "BERGS", "Luleå"),
                    new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"),
                    new OrderInfo(1007, "Andrew Fuller", "France", "BLONP", "Strasbourg"),
                    new OrderInfo(1008, "Martin King", "Spain", "BOLID", "Madrid"),
                    new OrderInfo(1009, "Lenny Lin", "France", "BONAP", "Marseille"),
                    new OrderInfo(1010, "John Carter", "Canada", "BOTTM", "Tsawassen"),
                    new OrderInfo(1011, "Lauro King", "UK", "AROUT", "London"),
                    new OrderInfo(1012, "Anne Wilson", "Germany", "BLAUS", "Mannheim"),
                    new OrderInfo(1013, "Alfki Kyle", "France", "BLONP", "Strasbourg"),
                    new OrderInfo(1014, "Gina Irene", "UK", "AROUT", "London")
                };

                return collection;
            }
        }

        public class TwitterUser
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
            public int TweetCount { get; set; }

            public TwitterUser(string userId, string userName, int tweetCount)
            {
                this.UserId = userId;
                this.UserName = userName;
                this.TweetCount = tweetCount;
            }

            public static ObservableCollection<dynamic> GenerateUsers()
            {
                var collection = new ObservableCollection<dynamic>
                {
                    new TwitterUser(System.Guid.NewGuid().ToString(), "Mark", 1000),
                    new TwitterUser(System.Guid.NewGuid().ToString(), "John", 53),
                    new TwitterUser(System.Guid.NewGuid().ToString(), "Gemmy", 572),
                    new TwitterUser(System.Guid.NewGuid().ToString(), "Worlen", 528952),
                    new TwitterUser(System.Guid.NewGuid().ToString(), "Star", 821),
                    new TwitterUser(System.Guid.NewGuid().ToString(), "Tim", 1000),
                };

                return collection;
            }
        }

        public enum Sex { Male, Female }
        public enum BloodType { A, B, O, AB }
        public enum Cup { AA, A, B, C, D, E, F }

        public class Idol
        {
            public String Name { get; set; }
            public Sex Sex { get; set; }
            public int? Age { get; set; }
            public BloodType BloodType { get; set; }
            public float Height { get; set; }
            public float Weight { get; set; }
            public float BMI { get; set; }
            public float? Bust { get; set; }
            public float? Waist { get; set; }
            public float? Hip { get; set; }
            public Cup Cup { get; set; }
            public DateTime BirthDay { get; set; }
            public String Hometown { get; set; }
            public String CharacterVoice { get; set; }
            public int? VoiceActorAge { get; set; }
            public String Agency { get; set; }

            public static ObservableCollection<object> GenerateIdols()
            {
                var collection = new ObservableCollection<object>();

                for (int i = 0; i < 20; i++)
                {
                    collection.Add(new Idol()
                    {
                        Name = "天海春香",
                        Age = 17,
                        Sex = Sex.Female,
                        BloodType = BloodType.O,
                        Height = 158,
                        Weight = 46,
                        BMI = 18.43f,
                        Bust = 83,
                        Waist = 56,
                        Hip = 82,
                        Cup = Cup.D,
                        BirthDay = new DateTime(2016, 4, 3),
                        Hometown = "神奈川県",
                        CharacterVoice = "中村繪里子",
                        VoiceActorAge = 34,
                        Agency = "765"
                    });
                }

                return collection;
            }
        }
    }
}
