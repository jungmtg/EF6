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
				//AsNoTracking
				var datas = db.Course.AsNoTracking();
				foreach (var data in datas)
				{
					Console.WriteLine(data.Title);
				}


			}
			
			


		}
	}
}
