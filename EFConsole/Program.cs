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
				var one = db.Course.Find(1);
				Console.WriteLine(one.Title+"\t"+one.Department.Name);


			}
			


		}
	}
}
