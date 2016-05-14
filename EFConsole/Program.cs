using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new ContosoUniversityEntities())
			{
				
				var data = from p in db.Course
						   where p.Title.Contains("Git")
					select p;

				var updateDatas = from c in db.Course.Where(c => c.CourseID >= 9)
								 select c;

				foreach (var updateData in updateDatas)
				{
					updateData.Credits += 1;
				}

				var deleteData = from c in db.Course.Where(c => c.CourseID >= 9)
					select c;
				db.Course.RemoveRange(deleteData);
				db.SaveChanges();
			}



		}
	}
}
