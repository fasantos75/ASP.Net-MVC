
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SollisDocProject.Domain.Entities
{
    public class CadMotivo
    {
        [Key]
        public int IdMotivo { get; set; }
        public string NomeMotivo { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadMotivo> CadMotivos { get; set; }
    }
}
