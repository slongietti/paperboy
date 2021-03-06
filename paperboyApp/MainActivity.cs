﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace paperboyApp
{
    [Activity(Label = "paperboyApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.btn2DaysAgo).Click += btn2DaysAgo_Click;
        }

        private void btn2DaysAgo_Click(object sender, System.EventArgs e)
        {
            Volare.PaperBoy.ExternalModels.PaperFinder.GetPaper(System.DateTime.Now.AddDays(-2));
        }
    }
}

