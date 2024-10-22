using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Domain.Models
{
    [Table("CreatePersonCNPJ")]
    public class CreatePersonCNPJ
    {
        [Column("id")]
        public Int64 Id { get; set; }

        [Column("User")]
        public Int64? UserID { get; set; }

        [Column("pix_key")]
        public string? PixKey { get; set; }

        [Column("UUID")]
        public string? UUID { get; set; }
    }
}
