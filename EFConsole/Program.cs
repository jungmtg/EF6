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
				
				var sql = @"SELECT Department.DepartmentID,
						          Department.Name, 
	                              COUNT(*) AS CourseCount
							      FROM Course LEFT OUTER JOIN
								  Department ON Course.DepartmentID = Department.DepartmentID
							      GROUP BY Department.DepartmentID, Department.Name";

				var data = db.Database.SqlQuery<DeptCourseCount>(sql);

					foreach (var item in data)
					{
						Console.WriteLine(item.Name+"\t"+item.CourseCount);
					}

				Console.ReadKey();


			}
			


		}
	}
}
