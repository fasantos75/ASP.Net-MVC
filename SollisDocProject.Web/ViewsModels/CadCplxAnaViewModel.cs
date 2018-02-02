
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadCplxAnaViewModel
    {
        [Key]
        public int IdCplxAna { get; set; }
        public string NomeCplxAna { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadCplxAnaViewModel> CadCplxAnas { get; set; }
    }
}
