using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDAL.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Username { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

    }
}
