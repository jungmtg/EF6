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
			var c = new Course()
			{
				CourseID = 20,
				Title = "123",
			    DepartmentID =1,
				Credits = 1
			};

			using (var db = new ContosoUniversityEntities())
			{
				Console.WriteLine(db.Entry(c).State);
				db.Course.Attach(c);
				Console.WriteLine(db.Entry(c).State);
				c.Title = "321";
				Console.WriteLine(db.Entry(c).State);
				Console.Read();

			}




		}
	}
}
