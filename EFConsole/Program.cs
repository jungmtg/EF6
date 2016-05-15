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

				var update = db.Department.Find(14);
				update.Name = "GiGilove";
				update.Budget = 111.11M;

				db.Department.Attach(update);
				db.Entry(update).State = EntityState.Modified;
				db.SaveChanges();

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
