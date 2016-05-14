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
			//Start
			using (var db = new ContosoUniversityEntities())
			{
				
				//var data = from p in db.Course
				//		   where p.Title.Contains("Git")
				//	select p;
				db.Configuration.ProxyCreationEnabled = false;
				foreach (var item in db.Course)
				{
					item.Title = "123";
					Console.WriteLine(item.Title);
				}

				Console.ReadKey();

			}
			//End,一個完整的Entity Framework生命週期


		}
	}
}
