using System;
namespace MovieDatabase
{
	internal class Movie
	{
		public string title;
		public string category;

		public Movie(string title, string category)
		{
			this.title = title;
			this.category = category;
		}
	}
}

