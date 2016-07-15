using Foundation;
using UIKit;

namespace CustomRenderer.iOS
{
	/// <summary>
	/// Sample of a custom cell layout, taken from the iOS docs at:
	/// http://developer.xamarin.com/guides/ios/user_interface/tables/part_3_-_customizing_a_table's_appearance/
	/// </summary>
	public class NativeiOSCell : UITableViewCell
	{
		UILabel hostName,osVersion, ipAdddress, onlineSince;
		UIImageView imageView;

		public NativeiOSCell (NSString cellId) : base (UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;

			ContentView.BackgroundColor = UIColor.FromRGB (255, 255, 224);

			imageView = new UIImageView ();


            hostName = new UILabel () {
				Font = UIFont.FromName ("Cochin-BoldItalic", 15f),
				TextColor = UIColor.FromRGB (127, 51, 0),
				BackgroundColor = UIColor.Clear
			};

            osVersion = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 15f),
                TextColor = UIColor.FromRGB(127, 51, 0),
                BackgroundColor = UIColor.Clear
            };

            ipAdddress = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 15f),
                TextColor = UIColor.FromRGB(127, 51, 0),
                BackgroundColor = UIColor.Clear
            };

            onlineSince = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 15f),
                TextColor = UIColor.FromRGB(127, 51, 0),
                BackgroundColor = UIColor.Clear
            };

            ContentView.Add(hostName);
			ContentView.Add(osVersion);
            ContentView.Add(ipAdddress);
            ContentView.Add(onlineSince);

            ContentView.Add (imageView);
		}

		public void UpdateCell (string name, string os, string ip, string online, UIImage image)
		{
            hostName.Text = name;
            osVersion.Text = os;
            ipAdddress.Text = ip;
            onlineSince.Text = online;
            imageView.Image = image;
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
            

            //osVersion.Frame = new CoreGraphics.CGRect (5, 55, ContentView.Bounds.Width - 63, 25);
            hostName.Frame = new CoreGraphics.CGRect (100, 5,  250, 25);
            osVersion.Frame = new CoreGraphics.CGRect (100, 100, 250, 25);
            ipAdddress.Frame = new CoreGraphics.CGRect(100, 200, 250, 25);
            onlineSince.Frame = new CoreGraphics.CGRect(100, 300, 250, 25);

            imageView.Frame = new CoreGraphics.CGRect (5, 5, 50, 50);
		}
	}
}
