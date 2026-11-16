using Assignment01_EF_Core.Data;

namespace Assignment01_EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())
            {
                bool created = context.Database.EnsureCreated();

                Console.WriteLine(created
                    ? "Database Created Successfully!"
                    : "Database already exists.");

                Console.WriteLine($"Can connect: {context.Database.CanConnect()}");
            }
        }
    }

}