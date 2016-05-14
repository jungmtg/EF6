using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new ContosoUniversityEntities())
			{
				
				var data = from p in db.Course
						   where p.Title.Contains("Git")
					select p;
				//foreach (var item in data)
				//{
				//	Console.WriteLine(item.Title);
				//}

				//var c = new Course()
				//{
				//	Title = "Git Test 2",
				//	Credits = 4
				//};

				//c.Department = db.Department.Find(2);
				//db.Course.Add(c);

				//Console.WriteLine(c.CourseID);
				//db.SaveChanges();
				//Console.WriteLine(c.CourseID);
				//Console.ReadKey();

				var c8 = db.Course.Find(8);
				#region False Example
				//This Data is not exist in current db
				//new Course() { CourseID = 12}
				#endregion
				db.Course.Remove(
					c8
					);
				db.SaveChanges();

			}



		}
	}
}
