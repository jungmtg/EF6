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
				//foreach (var item in db.Course)
				//{
					//Console.WriteLine(item.Department.Name);//String Types

				//}
				var data = from p in db.Course
						   where p.Title.Contains("Git")
					select p;
				foreach (var item in data)
				{
					Console.WriteLine(item.Title);
				}

				//var c =db.Course.Add(new Course()
				//{
				//	Title ="Git Test2",
				//	Credits = 5,
				//	//DepartmentID = 1
				//});

				var c = new Course()
				{
					Title = "Git Test 2",
					Credits = 4
				};

				c.Department = db.Department.Find(2);

				db.SaveChanges();


				foreach (var item in db.Course.ToList())
				{
					Console.WriteLine(item.Title);
				}

			}



		}
	}
}
