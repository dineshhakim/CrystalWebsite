using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uranus.Domain.Entities
{
    [Table("Clients")]
   public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName ="VARCHAR")]
        [StringLength(100)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Contact { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
