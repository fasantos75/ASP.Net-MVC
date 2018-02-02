
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SollisDocProject.Domain.Entities
{
    public class CadModulos
    {
        [Key]
        public int IdModulo { get; set; }
        public int IdSistema { get; set; }
        public string NomeModulo { get; set; }
        public string Status { get; set; }
        public virtual CadSistema CadSistema { get; set; }
        public virtual ICollection<CadModulos> CadModulo { get; set; }
    }
}
