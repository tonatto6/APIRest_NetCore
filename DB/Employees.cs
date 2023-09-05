using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmploye { get; set; }

        public string Name{ get; set; }

        public string Email{ get; set; }

        public int IdJobPosition{ get; set; }
        [ForeignKey("IdJobPosition")]
        public virtual JobsPositions JobPosition { get; set; }
    }
}
