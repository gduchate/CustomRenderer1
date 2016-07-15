using System;
using Xamarin.Forms;

namespace CustomRenderer
{
	public class NativeCell : ViewCell
	{
		public static readonly BindableProperty HostNameProperty = 
			BindableProperty.Create ("HostName", typeof(string), typeof(NativeCell), "");

		public string HostName {
			get { return "HostName: " + (string)GetValue (HostNameProperty); }
			set { SetValue (HostNameProperty, value); }
		}

		public static readonly BindableProperty OSNameProperty = 
			BindableProperty.Create ("OSName", typeof(string), typeof(NativeCell), "");

		public string OSName
        {
			get { return "OS Name: " + (string)GetValue (OSNameProperty); }
			set { SetValue (OSNameProperty, value); }
		}


        public static readonly BindableProperty IPAddressProperty =
            BindableProperty.Create("IPAddress", typeof(string), typeof(NativeCell), "");

        public string IPAddress
        {
            get { return "IP Address: " + (string)GetValue(IPAddressProperty); }
            set { SetValue(IPAddressProperty, value); }
        }


        public static readonly BindableProperty OnlineSinceProperty =
            BindableProperty.Create("OnlineSince", typeof(string), typeof(NativeCell), "");

        public string OnlineSince
        {
            get { return "Online Since: " + (string)GetValue(OnlineSinceProperty); }
            set { SetValue(OnlineSinceProperty, value); }
        }
        

        public static readonly BindableProperty ImageFilenameProperty = 
			BindableProperty.Create ("ImageFilename", typeof(string), typeof(NativeCell), "");

		public string ImageFilename {
			get { return (string)GetValue (ImageFilenameProperty); }
			set { SetValue (ImageFilenameProperty, value); }
		}
	}
}
