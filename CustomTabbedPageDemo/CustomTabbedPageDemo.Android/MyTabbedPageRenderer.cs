using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using CustomTabbedPageDemo;
using CustomTabbedPageDemo.Droid;
using Android.Support.Design.Widget;

[assembly:ExportRenderer(typeof(MyTabbedPage),typeof(MyTabbedPageRenderer))]
namespace CustomTabbedPageDemo.Droid
{
    public class MyTabbedPageRenderer:TabbedPageRenderer
    {
        
        protected override void SetTabIcon(TabLayout.Tab tab, FileImageSource icon)
        {
            base.SetTabIcon(tab, icon);
            tab.SetCustomView(Resource.Layout.tab_view);
        }
    }
}