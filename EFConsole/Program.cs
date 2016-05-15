using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EFConsole
{

	public  class DeptCourseCount
	{
		public int DepartmentID { get; set; }
		public string Name { get; set; }
		public int CourseCount { get; set; }
	}

	class Program
	{
		

		public static void Main(string[] args)
		{
			using (var db = new ContosoUniversityEntities())
			{
				db.Database.Log = Console.WriteLine;

				db.Configuration.LazyLoadingEnabled = false;

				var data2 = db.Course;//.Include(p => p.Department);
					//.Where(p => p.CourseType == CourseType.全部);
				//p.CourseType.HasFlag(CourseType.前端)
				foreach (var item in data2)
				{
					//Console.WriteLine(item.Title + " " +item.CourseType);
					Console.WriteLine("---------------------");
					Console.WriteLine(item.Title);

					//db.Entry(item).Reference(p=>p.Department).Load();
					var refLink = db.Entry(item).Reference(p => p.Department);
					if (!refLink.IsLoaded)
					{
						refLink.Load();
					}


					Console.WriteLine(item.Department.Name);
					Console.WriteLine("---------------------");
					Console.WriteLine();
				}

				Console.ReadKey();
			}

			#region
			//var c = new Course()
			//{
			//	CourseID = 20,
			//	Title = "123",
			//    DepartmentID =1,
			//	Credits = 1
			//};

			//using (var db = new ContosoUniversityEntities())
			//{
			//	Console.WriteLine(db.Entry(c).State);
			//	db.Course.Attach(c);
			//	Console.WriteLine("Title="+c.Title);
			//	Console.WriteLine(db.Entry(c).State);

			//	db.Course.ToList();

			//	var tt = db.Course.Find(20);
			//	Console.WriteLine("Title=" + c.Title);
			//	Console.WriteLine(db.Entry(c).State);


			//}

			//using (var db = new ContosoUniversityEntities())
			//{
			//	//Modified c successful
			//	c.Title = "4561";
			//	db.Entry(c).State=EntityState.Modified;
			//	db.SaveChanges();
			//}
			#endregion



		}
	}
}
