using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using do_an_framework.Models;


namespace do_an_framework.Controllers
{
    public class UserController : Controller
    {
        private MySqlDatabase MySqlDatabase { get; set; }
        public UserController(MySqlDatabase mySqlDb)
        {
            this.MySqlDatabase = mySqlDb;
        }
        public async Task<List<UserModel>> UserList()
        {
            var userList = new List<UserModel>();
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT ma_nguoi_dung, ten_nguoi_dung FROM nguoI_dung";

            using (var reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    var t = new UserModel()
                    {
                        user_id= reader.GetFieldValue<int>(0),
                        user_name = reader.GetFieldValue<string>(1)
                    };

                    userList.Add(t);
                }
            
            return userList;
        }

        public async Task<IActionResult> index()
        {

            return View(await this.UserList());
        }
    }
}
