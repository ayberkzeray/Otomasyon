using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Models
{
    public class BaseEntity
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        [Required]
        [Column(Order = 2)]
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        [Column(TypeName = "datetime2")]
        public DateTime? AddedDate { get; set; }
    }
}
