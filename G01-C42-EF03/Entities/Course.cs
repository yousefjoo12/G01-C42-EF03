using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entities
{
	internal class Course
	{
	
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Duration { get; set; } 
		public virtual ICollection<Student> Students_Courses { get; set; } = new List<Student>(); 
	}
}
