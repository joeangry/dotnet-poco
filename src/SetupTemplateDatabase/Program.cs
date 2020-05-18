using System;
using System.Linq;
using System.Reflection;
using DbUp;

namespace SetupTemplateDatabase
{
    class Program
    {
        static int Main(string[] args)
        {
            var connectionString =
                args.FirstOrDefault()
                ?? "Server=.; Database=poco-template; Integrated Security=False; User Id=sa;Password=SpikePrototype2016!;";

            // Clean database
            DropDatabase.For.SqlDatabase(connectionString);
            EnsureDatabase.For.SqlDatabase(connectionString);
            
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();
            
            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif                
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            return 0;
        }
    }
}