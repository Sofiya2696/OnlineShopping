using Shopping.Views;
using Shopping.Views.Base;
using Xamarin.Forms;

namespace Shopping
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new NavigationView(new DashboardPage());
         var masterPage = Current.MainPage as NavigationView;
         var tabbedPage = masterPage.CurrentPage as TabbedPage;
         tabbedPage.CurrentPage = tabbedPage.Children[2];
      }

      protected override void OnStart()
      {
      }

      protected override void OnSleep()
      {
      }

      protected override void OnResume()
      {
      }
   }
}
