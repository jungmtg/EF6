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
				
				var c = db.Course.Find(19);

				//狀態找到物件
				//Entity 型別為course
				//ce.State=Unchanged
				WriteLine("ce.State"+"\t"+db.Entry(c).State);
				c.Credits += 1;
				WriteLine("ce.State" + "\t" + db.Entry(c).State);
				db.Course.Remove(c);
				WriteLine("ce.State" + "\t" + db.Entry(c).State);
				db.SaveChanges();
				WriteLine("ce.State" + "\t" + db.Entry(c).State);
			}
			
			


		}
	}
}
