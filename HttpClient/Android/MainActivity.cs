﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


//using Xamarin.Forms.Platform.Android;
using Android.Content.PM;


namespace HttpClientDemo.Android
{
	[Activity (Label = "HttpClient.Android.Android",
		MainLauncher = true, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);
			Xamarin.FormsMaps.Init(this, bundle);

			LoadApplication (new App());
		}
	}
}

