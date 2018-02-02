
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SollisDocProject.Domain.Entities
{
    public class CadSistema
    {
        [Key]
        public int IdSistema { get; set; }
        public string NomeSistema { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadModulos> CadModulo { get; set; }
        public virtual ICollection<CadSistema> CadSistemas { get; set; }
    }
}
