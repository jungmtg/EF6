using System;
using System.Collections.Generic;
using System.Linq;
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
				

				

				var c8 = db.Course.Find(8);
				
				db.Course.Remove(c8);
				db.SaveChanges();

			}



		}
	}
}
