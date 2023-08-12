using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Models
{
    public class Category : BaseEntity
    {
        [MaxLength(255)]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
