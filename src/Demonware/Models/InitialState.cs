using System.Collections.Generic;

namespace Demonware.Models
{
    public class InitialState
    {
        public List<Product> MostPopularProducts { get; set; }
        public List<BrandProducts> Brands { get; set; }
    }
}