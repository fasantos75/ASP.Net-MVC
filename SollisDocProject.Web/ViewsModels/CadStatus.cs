
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SollisDocProject.Domain.Entities
{
    public class CadStatus
    {
        [Key]
        public int IdStatus { get; set; }
        public string NomeStatus { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadStatus> CadStatuS { get; set; }
    }
}
