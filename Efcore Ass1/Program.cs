using Microsoft.EntityFrameworkCore;

namespace Efcore_Ass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookstoreContext();

            context.Database.Migrate();

            Console.WriteLine("Database created successfully!");
        }
    }
}
