using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

using do_an_framework.Models;

namespace do_an_framework.Controllers
{
    public class ProductController : Controller
    {
        private MySqlDatabase MySqlDatabase { get; set; }
        public ProductController(MySqlDatabase mySqlDb)
        {
            this.MySqlDatabase = mySqlDb;
        }
        

        // Index
        public async Task<IActionResult> Index()
        {
            var productlist = new List<ProductModel>();
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"Select ten_danh_muc from danh_muc";

            using (var reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    var tam = new ProductModel()
                    {
                        product_name = reader.GetString(0)
                    };
                    productlist.Add(tam);
                }
            return View(productlist);
        }


        // Creat View
        public IActionResult CreateView()
        {
            return View();
        }
    }
}

