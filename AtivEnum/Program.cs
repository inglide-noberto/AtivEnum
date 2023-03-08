using AtivEnum.Entities;
using AtivEnum.Entities.Enums;
using System.Globalization;

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

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departName);
            Worker worker = new Worker(name,salary, level, department);

            Console.Write("How many contracts to this worker? ");
            int qtdWork = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtdWork; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                //armazenamento com variação por conta da SO
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hour): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value ,hour);
                worker.AddContract(contract);
            }

            Console.Write("\n Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}