using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Models
{
    public class AppUser : BaseEntity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get { return Name + " " + LastName; } }
        public bool Gender { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }
    }
}
