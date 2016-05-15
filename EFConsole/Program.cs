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
				var c = db.Course.FirstOrDefault();
				c.Title = "GO TO DMC";
				if (db.Entry(c).State == EntityState.Modified)
				{
					var ce = db.Entry(c);
					var v1 = ce.CurrentValues.GetValue<string>("Title");
					var v2=	db.Entry(c).OriginalValues.GetValue<string>("Title");

				    Console.WriteLine("New Value:"+"\t"+v1+","+"\r\nOld Value:"+v2);

					ce.CurrentValues.SetValues(
						new {ModifiedOn=DateTime.Now}
						);
					db.SaveChanges();
					Console.ReadKey();
				}
			}
			
			


		}
	}
}
