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

				db.Department.Add(
					new Department()
					{
						Name="Test0515",
						Budget = 123.45M,
						StartDate = DateTime.Now.AddDays(-29),
						InstructorID = 4
					});
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
