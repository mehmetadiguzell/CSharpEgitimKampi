
using System.Data;
using System.Data.SqlClient;

//Adonet
Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
Console.WriteLine();
Console.WriteLine();

string tableNumber;

Console.WriteLine("--------------------------------------");
Console.WriteLine("1-Kategoriler");
Console.WriteLine("2-Ürünler");
Console.WriteLine("3-Siparişler");
Console.WriteLine("4-Çıkış Yap");
Console.WriteLine("Lüften Getirmek İsteğiniz Tablo Numarasını Giriniz");
Console.WriteLine("--------------------------------------");

tableNumber = Console.ReadLine();
Console.WriteLine("--------------------------------------");

SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-D9J07KP\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
sqlConnection.Open();

SqlCommand sqlCommand = new SqlCommand("Select * From TblCategory", sqlConnection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
DataTable dataTable = new DataTable();
sqlDataAdapter.Fill(dataTable);

sqlConnection.Close();

foreach (DataRow item in dataTable.Rows)
{
    foreach (var row in item.ItemArray)
    {
        Console.WriteLine(row);
    }
    Console.WriteLine();
}
Console.Read();
