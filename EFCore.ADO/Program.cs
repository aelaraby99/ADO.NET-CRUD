using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EFCore.ADO
{
    public class Wallet
    {
        public int Id { get; set; }
        public string? Holder { get; set; }
        public decimal Balance { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Holder} ({Balance:C})";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var ConnectionString = configuration.GetConnectionString("defaultConnection");
            #region Create Data
            //using (var connection = new SqlConnection(ConnectionString))
            //{
            //    var InsertQuery = "INSERT INTO Wallets (Holder, Balance) VALUES (@Holder, @Balance)";
            //    var SqlHolder = new SqlParameter()
            //    {
            //        ParameterName = "@Holder",
            //        SqlDbType = SqlDbType.VarChar,
            //        Direction = ParameterDirection.Input,
            //        Value = "John Doe",
            //    };
            //    var SqlBalance = new SqlParameter()
            //    {
            //        ParameterName = "@Balance",
            //        SqlDbType = SqlDbType.Decimal,
            //        Direction = ParameterDirection.Input,
            //        Value = 33000,
            //    };
            //    var command = new SqlCommand(InsertQuery, connection);
            //    command.CommandType = CommandType.Text;
            //    command.Parameters.Add(SqlHolder);
            //    command.Parameters.Add(SqlBalance);
            //    connection.Open();
            //    Console.WriteLine(command.ExecuteNonQuery() > 0 ? "Transaction Succeeded" : "Transaction Failed");
            //};
            #endregion
            #region Get Data 
            //var wallets = new List<Wallet>();
            //var sql = "SELECT * FROM Wallets";
            //using (var conn = new SqlConnection(ConnectionString))
            //{
            //    var cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;
            //    conn.Open();
            //    var Reader = cmd.ExecuteReader();
            //    while (Reader.Read())
            //    {
            //        var wallet = new Wallet
            //        {
            //            Id = Reader.GetInt32("Id"),
            //            Holder = Reader.GetString("Holder"),
            //            Balance = Reader.GetDecimal("Balance")
            //        };
            //        wallets.Add(wallet);
            //    }
            //};
            //foreach (var wallet in wallets)
            //{
            //    Console.WriteLine(wallet);
            //}
            #endregion
            #region Update Data
            //using (var connection = new SqlConnection(ConnectionString))
            //{
            //    var  SQLQuery = "Update Wallets Set Balance += @Balance  where Id = @Id";
            //    var IdParameter = new SqlParameter()
            //    {
            //        ParameterName = "@Id",
            //        SqlDbType = SqlDbType.Int,
            //        Direction = ParameterDirection.Input,
            //        Value = 4,
            //    };
            //    var BalanceParameter = new SqlParameter()
            //    {
            //        ParameterName = "@Balance",
            //        SqlDbType = SqlDbType.Decimal,
            //        Direction = ParameterDirection.Input,
            //        Value = 5000,
            //    };

            //    var command = new SqlCommand(SQLQuery, connection);
            //    command.CommandType = CommandType.Text;
            //    command.Parameters.Add(IdParameter);
            //    command.Parameters.Add(BalanceParameter);
            //    connection.Open();
            //    Console.WriteLine(command.ExecuteNonQuery()>0 ? "Updated Successfully" :"Failed To Update");
            //};
            #endregion
            #region Delete Data
            //using (var connection = new SqlConnection(ConnectionString))
            //{
            //    var DeleteQuery = "Delete from Wallets where Id = @Id";
            //    var IdParameter = new SqlParameter()
            //    {
            //        ParameterName = "@Id",
            //        SqlDbType = SqlDbType.Int,
            //        Direction = ParameterDirection.Input,
            //        Value = 7,
            //    };
            //    var command = new SqlCommand(DeleteQuery, connection);
            //    command.CommandType = CommandType.Text;
            //    command.Parameters.Add(IdParameter);
            //    connection.Open();
            //    Console.WriteLine(command.ExecuteNonQuery() > 0 ? "Deleted Successfully" : "Failed To Delete");
            //};
            #endregion
        }
    }
}
