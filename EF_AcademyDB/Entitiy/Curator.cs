using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EF_AcademyDB.Entitiy
{
    public class Curator
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(Max)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(Max)")]
        [Required]
        public string Surname { get; set; }

    }
}
