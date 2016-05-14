using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
	public partial class Course
	{
		partial void Initialize()
		{
			this.Credits = 3;
			//MARK this code,get the error The conversion of a datetime2 data 
			//type to a datetime data type resulted in an out-of-range value.\r\nThe statement has been terminated
			// Need to change edmx Field Stored Generated Patten value to Computed
			//this.CreateOn = DateTime.Now.AddDays(-30);

		}
	}
}
