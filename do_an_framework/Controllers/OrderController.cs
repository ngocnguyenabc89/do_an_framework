﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using do_an_framework.Models;

namespace do_an_framework.Controllers
{
    public class OrderController : Controller
    {
        private MySqlDatabase MySqlDatabase { get; set; }
        public OrderController(MySqlDatabase mySqlDb)
        {
            this.MySqlDatabase = mySqlDb;
        }
        public async Task<List<OrderModel>> OrderList()
        {
            var orderList = new List<OrderModel>();
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT ma_don_hang, ten_khach_hang, dia_chi_giao_hang, thoi_gian_giao_hang, tong_tien, tinh_trang, thoi_gian_tao from don_hang";

            using (var reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    var t = new OrderModel()
                    {
                        order_id = reader.GetFieldValue<int>(0),
                        customer_name = reader.GetFieldValue<string>(1),
                        address = reader.GetFieldValue<string>(2),
                        delivery_time = reader.GetFieldValue<DateTime>(3),
                        total = reader.GetFieldValue<int>(4),
                        status = reader.GetFieldValue<int>(5),
                        order_time = reader.GetFieldValue<DateTime>(6)
                    };

                    orderList.Add(t);
                }

            return orderList;
        }

        public async Task<IActionResult> index()
        {
            return View(await this.OrderList());
        }

        public async Task<IActionResult> info(int id)
        {
            // Lấy đơn hàng
            var order = new OrderModel();
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * from don_hang where ma_don_hang = @order_id";
            cmd.Parameters.AddWithValue("@order_id", id);

            using (var reader = await cmd.ExecuteReaderAsync())
                if (await reader.ReadAsync())
                {
                    var x = new OrderModel()
                    {
                        order_id = reader.GetFieldValue<int>(0),
                        customer_name = reader.GetFieldValue<string>(1),
                        customer_phone = reader.GetFieldValue<int>(2),
                        address = reader.GetFieldValue<string>(3),
                        delivery_time = reader.GetFieldValue<DateTime>(4),
                        customer_note = reader.GetFieldValue<string>(5),
                        total = reader.GetFieldValue<int>(6),
                        count = reader.GetFieldValue<int>(7),
                        status = reader.GetFieldValue<int>(8),
                        user_note = reader.GetFieldValue<string>(9),
                        order_time = reader.GetFieldValue<DateTime>(10),
                        history = reader.GetFieldValue<string>(11),
                        user_id = reader.GetFieldValue<int>(12)
                    };
                    order = x;
                }

            // Nếu không tồn tại đơn hàng quay lại trang danh sách đơn hàng
            if (order==null)
            {
                return View(await this.OrderList());
            }

            // Lấy chi tiết đơn hàng
            var detailList = new List<OrderDetailModel>();
            cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * from chi_tiet_don_hang where ma_don_hang = @order_id";
            cmd.Parameters.AddWithValue("@order_id", id);

            using (var reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    var y = new OrderDetailModel()
                    {
                        order_id = reader.GetFieldValue<int>(0),
                        product_id = reader.GetFieldValue<int>(1),
                        count = reader.GetFieldValue<int>(2),
                        price = reader.GetFieldValue<int>(3),
                        total = reader.GetFieldValue<int>(4)
                    };
                    detailList.Add(y);
                }

            // Lấy danh sách sản phẩm kèm danh mục
            var productList = new List<>
            return View(await this.OrderList());
        }

        public async Task<OrderModel> OrderUpdate(int id)
        {
            var order = new OrderModel();
            var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;

            return order;
        }

        public async Task<IActionResult> update(int order_id)
        {
            return View(await this.OrderUpdate(order_id));
        }

    }
}
