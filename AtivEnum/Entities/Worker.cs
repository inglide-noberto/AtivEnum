using AtivEnum.Entities.Enums;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AtivEnum.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkLevel Level { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Department Department { get; set; }

        public Worker() { }

        public Worker(string name, double baseSalary, WorkLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}
