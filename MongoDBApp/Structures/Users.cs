using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Npgsql;
using Dapper;
using System.Data;

namespace MongoDBApp.Structures
{
    public class UserList
    {
        public List<User> UserData = new List<User>();
        public UserList GetUser(BsonDocument filter)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("users");
            var users = collection.Find(filter).ToListAsync();

            UserList Ser = new UserList();
            foreach (var doc in users.Result)
            {
                User add = new User();

                {
                    foreach (var i in add.Keys)
                    {
                        add.document[i] = doc.GetValue(i).ToString();
                    }
                    Ser.UserData.Add(add);
                }
            }
            return Ser;
        }
    }

    public class User
    {
        public List<string> Keys = new List<string>() { "_id", "login", "pass", "fname", "lname", "role" };
        public Dictionary<string, string> document = new Dictionary<string, string>();

        public RolesList Roles = new RolesList();
        public User()
        {
            PostgresConnection conn = new PostgresConnection();

            using (IDbConnection db = new NpgsqlConnection(conn.connString))
            {
                using (var multi = db.QueryMultiple("taxonomy.Roles",
                    commandType: CommandType.TableDirect))
                {
                    Roles.RoleData = multi.Read<Role>();
                }
            }

            foreach (var i in Keys)
            {
                document.Add(i, null);
            }
        }
    }

    public class RolesList
    {
        public IEnumerable<Role> RoleData { get; set; }
    }

    public class Role
    {
        public int id { get; set; }

        public string name { get; set; }

        public int accessLevel { get; set; }
    }
}
