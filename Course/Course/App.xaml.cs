using Course.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Course.Data;

namespace Course
{
	public partial class App : Application
	{
		static CourseDatabase database;
		public static CourseDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new CourseDatabase(Path
						.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Courses.db3"));
				}
				return database;
			}
		}
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new UniversitiesPage());
		}
		protected override void OnStart() { }
		protected override void OnSleep() { }
		protected override void OnResume() { }
	}
}
