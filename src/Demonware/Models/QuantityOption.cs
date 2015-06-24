namespace Demonware.Models
{
    public class QuantityOption
    {
        public string Name { get; set; }
        public string Months { get; set; }
        public int Quantity { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public Rebate Rebate { get; set; }
    }
}