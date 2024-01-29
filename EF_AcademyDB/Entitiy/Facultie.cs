using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AcademyDB.Entitiy
{
    public class Facultie
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Name { get; set; }
    }
}
