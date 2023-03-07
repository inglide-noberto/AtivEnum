namespace AtivEnum.Entities
{
    class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract(DateTime dateTime, double value, int hours) 
        { 
            this.date = dateTime;
            this.valuePerHour = value;
            this.hours = hours;
        }   

        public double totalValue()
        {
            return valuePerHour;
        }
    }
}
