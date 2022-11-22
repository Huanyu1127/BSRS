using BSRS.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRS.Models.Services
{
	public class TestDetailServices
	{
		public void Create(TestDetailVM model)
		{
			string sql = "Insert into TestDetail(Grade1,Grade2,Grade3,Grade4,Grade5,totalGrade,forTestDetails) Values(@Grade1,@Grade2,@Grade3,@Grade4,@Grade5,@totalGrade,@forTestDetails)";
			var parameters = new SqlParameterBuilder()
				.AddInt("Grade1", model.ucTestGrade1)
				.AddInt("Grade2", model.ucTestGrade2)
				.AddInt("Grade3", model.ucTestGrade3)
				.AddInt("Grade4", model.ucTestGrade4)
				.AddInt("Grade5", model.ucTestGrade5)
				.AddInt("totalGrade", model.totalGrade)
				.AddNvarchar("forTestDetails", 50, model.forTestDetails)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
