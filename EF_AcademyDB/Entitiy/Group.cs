using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AcademyDB.Entitiy
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required]
        public string Name { get; set; }


        [MinLength(1), MaxLength(5)]
        [Required]
        public int Year { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
