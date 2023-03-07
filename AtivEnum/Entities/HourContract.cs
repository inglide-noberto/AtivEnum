namespace AtivEnum.Entities
{
    class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public double totalValue()
        {
            return valuePerHour;
        }
    }
}
