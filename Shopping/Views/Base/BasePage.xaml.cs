﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping.Views.Base
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class BasePage : ContentPage
   {
      public BasePage()
      {
         InitializeComponent();
         NavigationPage.SetHasNavigationBar(this, false);

      }
   }
}