using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping.Views.Base
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class NavigationView : NavigationPage
   {
      public NavigationView()
      {
         InitializeComponent();
      }
      public NavigationView(Page root) : base(root)
      {
         InitializeComponent();
      }
   }
}