using Dapper;
using System.Data;

namespace Week3.API_Odev.Seed
{
    public class SeedData
    {
        public static async Task Create(IDbConnection connection)
        {
            using (var transaction = connection.BeginTransaction())
            {
                var command = "insert into cars(modelyear,price,description,color,serialnumber)values(@modelyear,@price,@description,@color,@serialnumber) returning id";

                await connection.ExecuteScalarAsync<int>(command, new { modelyear = "2012", price = 100000, description = "2012-Kırmızı", color = "Kırmızı", serialnumber="11111" });
                await connection.ExecuteScalarAsync<int>(command, new { modelyear = "2013", price = 200000, description = "2013-Mavi", color = "Mavi", serialnumber="22222" });
                await connection.ExecuteScalarAsync<int>(command, new { modelyear = "2014", price = 300000, description = "2014-Yeşil", color = "Yeşil", serialnumber="33333" });

                transaction.Commit();
            }

        }
    }
}
