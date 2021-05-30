using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;
using System.Data;

namespace MongoDBApp.Structures
{
    public class CategoriesList
    {
        public IEnumerable<Category> CategoryData { get; set; }

        public CategoriesList()
        {
            PostgresConnection conn = new PostgresConnection();

            using (IDbConnection db = new NpgsqlConnection(conn.connString))
            {
                using (var multi = db.QueryMultiple("taxonomy.Categories",
                    commandType: CommandType.TableDirect))
                {
                    CategoryData = multi.Read<Category>();
                }
            }
        }
    }

    public class Category
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
