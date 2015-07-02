using System.Collections.Generic;

namespace Demonware.Models
{
    public class InitialState
    {
        public List<Product> mostPopularProducts { get; set; }
        public List<BrandProducts> brands { get; set; }
    }
}