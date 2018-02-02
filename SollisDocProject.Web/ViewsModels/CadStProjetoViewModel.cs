
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SollisDocProject.Domain.Entities
{
    public class CadStProjeto
    {
        [Key]
        public int IdStProjeto { get; set; }
        public string NomeStProjeto { get; set; }
        public string ObsStProjeto { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadStProjeto> CadStProjetos { get; set; }
    }
}
