
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadCplxProg
    {
        [Key]
        public int IdCplxProg { get; set; }
        public string NomeCplxProg { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadCplxProg> CadCplxProgs { get; set; }
    }
}
