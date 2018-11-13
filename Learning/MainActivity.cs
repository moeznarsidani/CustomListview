using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using Android.Views;
using Android.Content;

namespace Learning
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private List<Person> mItems;
        private ListView mListView;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            mListView = FindViewById<ListView>(Resource.Id.myListView);

           
            mItems = new List<Person>();
            Person a = new Person();
            a.user = "";
            a.topics = "installation";
          
            a.forward = "";
            mItems.Add(a);

            mItems.Add(new Person() { user="", topics = "First Xamarin Application", forward="" });
            mItems.Add(new Person() { user = "", topics = "App Manifest", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Android Resources", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Android Activity Lifecycle", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Permissions", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Building The App UI", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Menus", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Layouts", forward = "" });
            mItems.Add(new Person() { user = "", topics = "android widgets", forward = "" });
            mItems.Add(new Person() { user = "", topics = "Andeoid Dialogs", forward = "" });
            mItems.Add(new Person() { user = "", topics = "End projects", forward = "" });



            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);
            

            mListView.Adapter = adapter;


        //    mListView.ItemClick += itemClick;

          //  mListView.ItemLongClick += MListView_ItemLongClick;
 


        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {

            MenuInflater.Inflate(Resource.Menu.menu1, menu);
            return true;
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.add:
                    Toast.MakeText(this, "Refresh is clicked", ToastLength.Long).Show();

                    return true;

                case Resource.Id.refresh:
                    Toast.MakeText(this, "Refresh is clicked", ToastLength.Long).Show();

                    return true;

                case Resource.Id.email:
                    Toast.MakeText(this, "email is clicked", ToastLength.Long).Show();

                    return true;

                case Resource.Id.action1:
                    Toast.MakeText(this, "Refresh is clicked", ToastLength.Long).Show();

                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }


        /* private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
         {
             if (mItems[e.Position].firstName=="Allen")
             {
                 var intent = new Intent(this, typeof(LoginPage));
                 intent.PutExtra("f", mItems[e.Position].firstName);
                 intent.PutExtra("l", mItems[e.Position].lastName);
                 StartActivity(intent);
             }
         }

       /  private void itemClick(object sender, AdapterView.ItemClickEventArgs e)
         {
             Console.WriteLine(mItems[e.Position].firstName);
         }*/
    }
}