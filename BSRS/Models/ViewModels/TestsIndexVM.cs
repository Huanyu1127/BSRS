using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRS.Models.ViewModels
{
	public class TestsIndexVM
	{
		public int id { get; set; }
		public DateTime testDate { get; set; }
		public int grade { get; set; }
		public string categoryName { get; set; }
		public int userId { get; set; }
		public string notes { get; set; }
		public string name { get; set; }
		public int ucTestGrade1 { get; set; }
		public int ucTestGrade2 { get; set; }
		public int ucTestGrade3 { get; set; }
		public int ucTestGrade4 { get; set; }
		public int ucTestGrade5 { get; set; }
		public int totalGrade { get; set; }
		public string forTestDetails { get; set; }


	}
	public class TestVM
	{
		public int id { get; set; }
		public DateTime testDate { get; set; }
		public int grade { get; set; }
		public string categoryName { get; set; }
		public string notes { get; set; }
		public int userId { get; set; }
		public string name { get; set; }
		public int categoryId { get; set; }
		public int ucTestGrade1 { get; set; }
		public int ucTestGrade2 { get; set; }
		public int ucTestGrade3 { get; set; }
		public int ucTestGrade4 { get; set; }
		public int ucTestGrade5 { get; set; }
		public int totalGrade { get; set; }
		public string forTestDetails { get; set; }


	}
}
