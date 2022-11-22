using BSRS.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSRS.Models.Services
{
	public class TestServices
	{
		public IEnumerable<TestsIndexVM> GetAll(int loginId)
		{
			string sql = "Select T.id,testDate,grade,categoryName,notes,name From Tests T join categories C on T.categoryId = C.id join Users U on U.id = T.Userid where userId=@userId";

			SqlDbHelper dbHelper = new SqlDbHelper("default");

			var parameters = new SqlParameterBuilder()
				.AddInt("@userId", loginId)
				.Build();

			return dbHelper.Select(sql, parameters) 
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}
		public IEnumerable<TestsIndexVM> GetGradeDetails(int loginId)
		{
			string sql = "Select T.id,testDate,Grade1,Grade2,Grade3,Grade4,Grade5,totalGrade,forTestDetails From Tests T join Users U on U.id = T.Userid where userId=@userId";

			SqlDbHelper dbHelper = new SqlDbHelper("default");

			var parameters = new SqlParameterBuilder()
				.AddInt("@userId", loginId)
				.Build();

			return dbHelper.Select(sql, parameters) //par
				.AsEnumerable()
				.Select(row => ToIndexVM(row));
		}

		private TestsIndexVM ParseToIndexVM(DataRow row)
		{
			return new TestsIndexVM
			{
				id = row.Field<int>("Id"),
				testDate= row.Field<DateTime>("testDate"),
				grade = row.Field<int>("grade"),
				categoryName = row.Field<string>("categoryName"),
				name = row.Field<string>("name"),
				notes = row.Field<string>("notes"),
			};
		}
		private TestsIndexVM ToIndexVM(DataRow row) //for Details
		{
			return new TestsIndexVM
			{
				id = row.Field<int>("Id"),
				testDate = row.Field<DateTime>("testDate"),
				ucTestGrade1 = row.Field<int>("grade1"),
				ucTestGrade2 = row.Field<int>("grade2"),
				ucTestGrade3 = row.Field<int>("grade3"),
				ucTestGrade4 = row.Field<int>("grade4"),
				ucTestGrade5 = row.Field<int>("grade5"),
				totalGrade = row.Field<int>("totalgrade"),
				forTestDetails = row.Field<string>("forTestDetails"),
			};
		}
		public void Create(TestVM model)
		{
			string sql = "Insert into Tests(grade,notes,categoryId,userId,Grade1,Grade2,Grade3,Grade4,Grade5,totalGrade,forTestDetails) Values(@grade,@notes,@categoryId,@userId,@Grade1,@Grade2,@Grade3,@Grade4,@Grade5,@totalGrade,@forTestDetails)";
			var parameters = new SqlParameterBuilder()
				.AddInt("grade", model.grade)
				.AddNvarchar("notes", 100, model.notes)
				.AddInt("categoryId", model.categoryId)
				.AddInt("userId", model.userId)
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

		public void Delete(TestVM model)
		{
			if (MessageBox.Show("您確定要刪除此筆紀錄嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}
			string sql = "Delete from Tests where id=@id";
			var parameters = new SqlParameterBuilder()
				.AddInt("id", model.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(TestVM model)
		{
			string sql = "Update Tests Set categoryID=@categoryID, notes=@notes where id=@id";
			var parameters = new SqlParameterBuilder()
				.AddInt("categoryID", model.categoryId)
				.AddNvarchar("notes", 100, model.notes)
				.AddInt("id", model.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
