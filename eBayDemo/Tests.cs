﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace eBayDemo
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
			// TODO: Update this path to point to your Android app and uncomment the
			// code if the app is not included in the solution.
				.ApkFile ("/Users/junecho/Desktop/eBay.apk")
				.StartApp ();
		}


		[Test]
		public void NewTest() {
			app.Tap(x => x.Id("onboarding_get_started"));
			app.Screenshot("Tapped on view with class: AppCompatButton");
			app.Tap(x => x.Id("capsule_deals"));
			app.Screenshot("Tapped on view with class: AppCompatTextView");
			app.Tap(x => x.ClassFull("android.support.design.widget.TabLayout$TabView").Index(1));
			app.Screenshot("Tapped on view with class: TabLayout$TabView");
			app.Tap(x => x.Id("imageview_deals").Index(1));
			app.Screenshot("Tapped on view with class: RemoteImageView");
			app.Tap(x => x.Id("button_bin_inline"));
			app.Screenshot("Tapped on view with class: TextImageButton");
			app.EnterText(x => x.Id("edit_text_username"), "johndoe");
		}




	}
}

