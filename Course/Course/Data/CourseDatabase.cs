using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Course.Models;

namespace Course.Data
{
	public class CourseDatabase
	{
		readonly SQLiteAsyncConnection _database;
		public CourseDatabase(string dbPath)
		{
			_database = new SQLiteAsyncConnection(dbPath);
			_database.CreateTableAsync<University>().Wait();
		}
		public Task<List<University>> GetUniversitiesAsync()
		{
			return _database.Table<University>().ToListAsync();
		}
		public Task<University> GetUniversityAsync(int id)
		{
			return _database.Table<University>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}
		public Task<int> SaveUniversityAsync(University university)
		{
			if (university.ID != 0) { return _database.UpdateAsync(university); }
			else { return _database.InsertAsync(university); }
		}
		public Task<int> DeleteUniversityAsync(University university)
		{
			return _database.DeleteAsync(university);
		}
	}
}
