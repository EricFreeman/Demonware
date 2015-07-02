namespace Demonware.Models
{
    public class QuantityOption
    {
        public string name { get; set; }
        public string months { get; set; }
        public int quantity { get; set; }
        public int minimum { get; set; }
        public int maximum { get; set; }
        public Rebate rebate { get; set; }
    }
}