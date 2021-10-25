using DapperContribDemo.Entity;
using System;

namespace DapperContribDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insert
            var insert = new Menu()
            {
                ProductId = 1,
                Description = "Eggs",
                CreatedIn = DateTime.UtcNow
            };

            insert.Insert(insert);
            Console.WriteLine($"Inserted {insert.Description}");

            //Get
            var data = new Menu()
            {
                ProductId = insert.Id,
            };
            data.Read(insert.Id);

            //Update
            var update = new Menu()
            {
                ProductId = insert.Id,
                Description = "Eggs and Bacon",
                CreatedIn = DateTime.UtcNow
            };
            update.Update(update);
            Console.WriteLine($"Updated {update.Description}");

            //Delete
            var delete = new Menu()
            {
                Id = insert.Id,
            };
            delete.Delete(delete.Id);
            Console.WriteLine($"Deleted {delete.Id}");
        }
    }
}
