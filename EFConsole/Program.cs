using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
		

		static void Main(string[] args)
		{
			
			using (var db = new ContosoUniversityEntities())
			{
				//AutoMapper
				var c = db.Course.Create();
				c.DepartmentID = 1;
				c.Title = "123123";

				db.Course.Add(c);
				db.SaveChanges();

				var co = db.Course.ToList();

				foreach (var item in co)
				{
					Console.WriteLine(c.Department+"\t"+c.Title+"\t"+c.Credits);
				}

			}
			
			


		}
	}
}
