using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Models
{
    public class Product : BaseEntity
    {
        public decimal? UnitPrice { get; set; }
        public short? Stock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
