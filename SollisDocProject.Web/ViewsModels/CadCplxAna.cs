
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadCplxAna
    {
        [Key]
        public int IdCplxAna { get; set; }
        public string NomeCplxAna { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadCplxAna> CadCplxAnas { get; set; }
    }
}
