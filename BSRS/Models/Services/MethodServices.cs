using BSRS.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSRS.Models.Services
{
	public class MethodServices
	{
		public IEnumerable<MethodIndexVM> GetAll(ComboBox categoryIdComboBox,int loginId)
		{
			string sql = "Select T.id,C.categoryName,T.notes,U.name From Tests T join categories C on C.id = T.categoryID join Users U on U.id = T.Userid";
			
			SqlParameter[] parameters = new SqlParameter[] { };

			int categoryId = ((MethodIndexVM)categoryIdComboBox.SelectedItem).id;

			if(categoryId == 0)
			{
				sql += " Where T.userId = @userId";
				parameters = new SqlParameterBuilder()
					.AddInt("@userId", loginId)
					.Build();
			}
			else if (categoryId > 0)
			{
				sql += " Where T.userId = @userId and C.Id = @Id";
				parameters = new SqlParameterBuilder()
					.AddInt("@Id", categoryId)
					.AddInt("@userId", loginId)
					.Build();
			}

			//sql += " Order by C.Id";

			SqlDbHelper dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, parameters) //parameters 
				.AsEnumerable()
				.Select(row => ParseMethodIndexVM(row));
		}
		private MethodIndexVM ParseMethodIndexVM(DataRow row) //For datagrid
		{
			return new MethodIndexVM
			{
				id = row.Field<int>("Id"),
				categoryName = row.Field<string>("categoryName"),
				notes = row.Field<string>("notes"),
				name = row.Field<string>("Name"),
			};
		}
		private MethodIndexVM ToMethodIndexVM(DataRow row) //For combobox
		{
			return new MethodIndexVM
			{
				id = row.Field<int>("Id"),
				categoryName = row.Field<string>("categoryName"),
			};
		}
		public IEnumerable<MethodIndexVM> GetComboBox(int loginId)
		{
			string sql = "Select * From Categories";
			var dbhelper = new SqlDbHelper("default");

			return dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToMethodIndexVM(row))
				.Prepend(new MethodIndexVM { id = 0, categoryName = "全選" });
		}
		public IEnumerable<MethodIndexVM> GetComboBoxNoAll(int loginId)
		{
			string sql = "Select * From Categories";
			var dbhelper = new SqlDbHelper("default");

			return dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToMethodIndexVM(row));
		}
	}
}
