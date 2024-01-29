using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AcademyDB.Entitiy
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [MinLength(1), MaxLength(5)]
        [Required]
        public int Building { get; set; }

        [DefaultValue(0)]
        [Required]
        public short Financing { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Name { get; set; }

        [ForeignKey("Facultie")]
        public int FacultyId { get; set; }

        public Facultie Facultie { get; set; }
    }
}
