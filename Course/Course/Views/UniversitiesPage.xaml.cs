using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Course.Models;

namespace Course.Views
{
	public partial class UniversitiesPage : ContentPage
	{
		public UniversitiesPage()
		{
			InitializeComponent();
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = await App.Database.GetUniversitiesAsync();
		}
		async void OnUnivAddedClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new UniversityEntryPage
			{
				BindingContext = new University()
			});
		}
		async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				await Navigation.PushAsync(new UniversityEntryPage
				{
					BindingContext = e.SelectedItem as University
				});
			}
		}
	}
}