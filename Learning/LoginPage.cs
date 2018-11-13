﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Learning
{
    [Activity(Label = "LoginPage")]
    public class LoginPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Login);

            string fname = Intent.Extras.GetString("f");
            string lname = Intent.Extras.GetString("l");

            TextView tv= FindViewById<TextView>(Resource.Id.wel);

            tv.Text = "Welcome " + fname + " " + lname + " !";


        }
    }
}