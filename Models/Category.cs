using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoApp.Models
{
    public class Category : Base
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public string Nome { get; set; }

        public List<Product> Products { get; set; }
    }
}
