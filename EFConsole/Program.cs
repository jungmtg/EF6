using System.Collections.Generic;
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
				db.Database.Log = WriteLine;
				
				var c = db.Course.Find(11);
				//複製一筆資料並新增
				db.Entry(c).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
			}
			
			


		}
	}
}
