using Shopping.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class DashboardPage : TabbedPage
   {
      public DashboardPage()
      {
         InitializeComponent();
      }
   }
}