using System;
using Xamarin.Forms;

namespace NerdConfessionsApp
{
	public partial class NerdConfessionsAppPage : MasterDetailPage
	{
		public NerdConfessionsAppPage()
		{
			InitializeComponent();

			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;

			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
