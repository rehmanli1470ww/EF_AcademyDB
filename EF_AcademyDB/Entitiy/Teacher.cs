using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AcademyDB.Entitiy
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="Bit")]
        [DefaultValue(0)]
        public bool IsProfessor { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(Max)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public short Salary { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(Max)")]
        public string Surname { get; set; }
    }
}
