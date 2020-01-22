using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Course.Models
{
	public class University
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
	}
}
