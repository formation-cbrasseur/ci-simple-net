// See https://aka.ms/new-console-template for more information

using Microsoft.Data.SqlClient;

string name = "Salut";
string password = "Monpassword^passecure";

Console.WriteLine($"Password : {password}");

using (SqlConnection connection = new SqlConnection(""))
{
    SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE name = {name} AND password = {password}", connection);
    var test = command.ExecuteNonQuery();
    Console.WriteLine(test);
}