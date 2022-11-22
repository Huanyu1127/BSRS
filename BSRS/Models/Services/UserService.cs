using BSRS.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRS.Models.Services
{
	public class UserService
	{
		public void Create(UserVM model)
		{
			bool isExist = AccountExists(model.Account, model.Id);
			if (isExist) throw new Exception("帳號已存在");

			string sql = "Insert into Users(account,password,name) Values(@account,@password,@name)";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("account", 50, model.Account)
				.AddNvarchar("password", 50, model.Password)
				.AddNvarchar("name", 50, model.Name)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool AccountExists(string account, int id)
		{
			string sql = "Select count(*) as count From Users Where account=@account and id != @id";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("account", 50, account)
				.AddInt("id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}
		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false;

			return (user.Password == model.Password);
		}
		public int AuthenticatedLoginId(LoginVM model)
		{
			UserVM user = Get(model.Account);
			return (user.Id);
		}
		public string AuthenticatedLoginName(LoginVM model)
		{
			UserVM user = Get(model.Account);
			return (user.Name);
		}
		private UserVM Get(string account)
		{
			string sql = "Select * From Users Where account=@account";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}
			//將找到的一筆紀錄由DataTable轉換到UserVM

			return ToUserVM(data.Rows[0]);
		}
		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
	}
}
