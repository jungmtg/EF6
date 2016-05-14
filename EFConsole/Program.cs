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
				
			}



		}
	}
}
