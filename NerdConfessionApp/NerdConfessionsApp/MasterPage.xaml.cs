using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NerdConfessionsApp
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView
		{
			get
			{
				return listView;
			}
		}

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem> ();

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Confessions Feed",
				IconSource = "ActivityFeed.png",
				TargetType = typeof(IndexPage)
			});

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Podcast Episodes",
				IconSource = "Headphones.png",
				TargetType = typeof(PodcastPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
