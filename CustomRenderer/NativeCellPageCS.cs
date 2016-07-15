using Xamarin.Forms;

namespace CustomRenderer
{
	public class NativeCellPageCS : ContentPage
	{
		ListView listView;

		public NativeCellPageCS ()
		{
			listView = new ListView {
                RowHeight = 300,
                HasUnevenRows = true,
                ItemsSource = DataSource.GetList (),

				ItemTemplate = new DataTemplate (() => {
					var nativeCell = new NativeCell ();
					nativeCell.SetBinding (NativeCell.HostNameProperty, "HostName");
					nativeCell.SetBinding (NativeCell.IPAddressProperty, "IPaddress");
                    nativeCell.SetBinding(NativeCell.OnlineSinceProperty, "OnlineSince");
                    nativeCell.SetBinding(NativeCell.OSNameProperty, "OSName");
                    nativeCell.SetBinding (NativeCell.ImageFilenameProperty, "ImageFilename");
                                        
                    nativeCell.Height = 300;
                    nativeCell.ForceUpdateSize();

                    return nativeCell;
				})
			};







            Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Xamarin.Forms native cell", HorizontalTextAlignment = TextAlignment.Center },
					listView
				}
			};
					
			listView.ItemSelected += OnItemSelected;
		}

		async void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null) {
				return;
			}

			// Deselect row
			listView.SelectedItem = null;

			//await Navigation.PushModalAsync (new DetailPage (e.SelectedItem));
		}
	}
}
