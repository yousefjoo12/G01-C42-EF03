using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entities
{
	internal class Instructor
	{
	
		public int Id { get; set; }

		public string Name { get; set; }

		public string? Address { get; set; }

		public int Bonus { get; set; }

		public double Salary { get; set; }

		public double HourlyRate { get; set; }
		 
	}
}
