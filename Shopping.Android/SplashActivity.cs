﻿using Android.App;
using Android.OS;

namespace Shopping.Droid
{
   [Activity(Theme = "@style/splashscreen",
        MainLauncher = true,
        NoHistory = true)]
   public class SplashActivity : Activity
   {
      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);
         System.Threading.Thread.Sleep(3000);
         StartActivity(typeof(MainActivity));
         // Create your application here
      }
   }
}