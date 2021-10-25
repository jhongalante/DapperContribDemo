using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DapperContribDemo.Entity
{
    [Table("Menu")]
    public class Menu
    {
        private readonly string conn = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=teste;Integrated Security=True;Pooling=False";

        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedIn { get; set; }


        //Read
        public Menu Read(int id)
        {
            using(SqlConnection connection = new SqlConnection(conn))
            {
                return connection.Get<Menu>(id);
            }
        }

        //Insert
        public long Insert(Menu menu)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                return connection.Insert(menu);
            }
        }

        //Update
        public void Update(Menu menu)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Update(menu);
            }
        }

        //Delete
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Delete(new Menu() { Id = id });
            }
        }
    }
}
