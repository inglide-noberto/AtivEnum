using AtivEnum.Entities.Enums;

namespace AtivEnum.Entities
{
    class Worker
    {
        public string name { get; set; }
        public WorkLevel level { get; set; }
        public double baseSalary { get; set; }

        public void addContract(HourContract contract)
        {

        }
        public void removeContract(HourContract contract)
        {

        }
        public double income( int year, int month)
        {
            return baseSalary; // trocar o retorno
        }

    }
}
