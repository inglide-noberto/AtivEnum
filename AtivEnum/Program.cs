using AtivEnum.Entities;

namespace AtivEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departments name: ");
            string departName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");  
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior)");
            // provavelmente aqui vem um enum

            Console.Write("Base salary");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker");
            int qtdWork = int.Parse(Console.ReadLine());

            Department department = new Department(departName);

            for (int i = 1; i <= qtdWork; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                Console.Write("Valeu per hour: ");
            }
            

        }
    }
}