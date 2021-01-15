using Shopping.Views.Base;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class CartPage : BasePage
   {
      readonly IList<CartModel> source;
      public CartPage()
      {
         InitializeComponent();
         source = new List<CartModel>();
         CreateItemCollection();
         collectionView.ItemsSource = source;
      }

      void CreateItemCollection()
      {
         source.Add(new CartModel
         {
            Image = "Item1.png",
            Name = "Jacket in blue denim",
            Price = "€ 230",
            Brand = "Wrangler",
            Size = "S",
            Color = "#ecb900",
            Quantity = "1"
         });
         source.Add(new CartModel
         {
            Image = "Item2.png",
            Name = "T-Shirt Mark Lebon Julie",
            Price = "€ 50",
            Brand = "Prada",
            Size = "S",
            Color = "#ee711d",
            Quantity = "1"
         });
         source.Add(new CartModel
         {
            Image = "Item3.png",
            Name = "Bananas pattern",
            Price = "€ 150",
            Brand = "Dior",
            Size = "S",
            Color = "#2faef8",
            Quantity = "1"
         });


      }

      private async void CheckOutTapped(object sender, System.EventArgs e)
      {
         if (Application.Current.MainPage is NavigationView navigationPage)
         {
            await navigationPage.Navigation.PushAsync(new NavigationView(new CheckoutPage()));
         }
      }
   }
   public class CartModel : INotifyPropertyChanged
   {
      public string Image { get; set; }
      public string Name { get; set; }
      public string Price { get; set; }
      public string Brand { get; set; }
      public string Size { get; set; }
      public string Color { get; set; }
      public string Quantity { get; set; }

      public event PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      {
         var changed = PropertyChanged;
         if (changed != null)
         {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
         }
      }
   }
}