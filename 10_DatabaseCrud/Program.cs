﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud->Create, Read, Update, Delete


            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D9J07KP\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz çalıştırır
            //connection.Close();

            //Console.WriteLine("Kategori ekleme işlemi başarılı");

            #endregion

            #region Ürün Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz Ürün Adı: ");
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D9J07KP\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori ekleme işlemi başarılı");

            #endregion

            #region Ürün Listeleme İşi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D9J07KP\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D9J07KP\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi başarılı");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D9J07KP\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct set ProductName = @productName,ProductPrice=@productPrice where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();


            connection.Close();

            Console.WriteLine("Güncelleme İşlemi Başarılı");

            #endregion


            Console.Read();
        }
    }
}