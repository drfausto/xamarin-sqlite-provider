using System;
using System.IO;
using Xamarin.Forms;
using Course.Models;

namespace Course.Views
{
	public partial class UniversityEntryPage : ContentPage
	{
		public UniversityEntryPage()
		{
			InitializeComponent();
		}
		async void OnSaveButtonClicked(object sender, EventArgs e)
		{
			var university = (University)BindingContext;
			university.Date = DateTime.UtcNow;
			await App.Database.SaveUniversityAsync(university);
			await Navigation.PopAsync();
		}
		async void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			var university = (University)BindingContext;
			await App.Database.DeleteUniversityAsync(university);
			await Navigation.PopAsync();
		}
	}
}