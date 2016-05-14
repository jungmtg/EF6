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
				foreach (var dept in db.Department)
				{
					Console.WriteLine(dept.Name);
					foreach (var course in dept.Course)
					{
						Console.WriteLine("\t"+course.Title);
					}

					Console.ReadKey();

				}


			}
			


		}
	}
}
