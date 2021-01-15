using Shopping.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class CheckoutPage : BasePage
   {
      public CheckoutPage()
      {
         InitializeComponent();
      }

      private void ShipmentClicked(object sender, System.EventArgs e)
      {
         ShipmentFrame.BackgroundColor = (Color)Application.Current.Resources["PrimaryOrange"];
         PaymentFrame.BackgroundColor = SummaryFrame.BackgroundColor = Color.Transparent;
         ShipmentLabel.TextColor = (Color)Application.Current.Resources["White"];
         PaymentLabel.TextColor = SummaryLabel.TextColor = (Color)Application.Current.Resources["DarkGray"];
         ShipmentGrid.IsVisible = true;
         OtherGrid.IsVisible = false;
      }

      private void PaymentClicked(object sender, System.EventArgs e)
      {
         PaymentFrame.BackgroundColor = (Color)Application.Current.Resources["PrimaryOrange"];
         ShipmentFrame.BackgroundColor = SummaryFrame.BackgroundColor = Color.Transparent;
         PaymentLabel.TextColor = (Color)Application.Current.Resources["White"];
         ShipmentLabel.TextColor = SummaryLabel.TextColor = (Color)Application.Current.Resources["DarkGray"];
         ShipmentGrid.IsVisible = false;
         OtherGrid.IsVisible = true;
      }
      private void SummaryClicked(object sender, System.EventArgs e)
      {
         SummaryFrame.BackgroundColor = (Color)Application.Current.Resources["PrimaryOrange"];
         ShipmentFrame.BackgroundColor = PaymentFrame.BackgroundColor = Color.Transparent;
         SummaryLabel.TextColor = (Color)Application.Current.Resources["White"];
         PaymentLabel.TextColor = ShipmentLabel.TextColor = (Color)Application.Current.Resources["DarkGray"];
         ShipmentGrid.IsVisible = false;
         OtherGrid.IsVisible = true;
      }

      private async void ClosedTapped(object sender, System.EventArgs e)
      {
         if (Application.Current.MainPage is NavigationView navigationPage)
         {
            await navigationPage.Navigation.PopAsync();
         }
      }
   }
}