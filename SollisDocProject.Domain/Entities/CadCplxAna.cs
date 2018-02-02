
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadCplxAna
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCplxAna { get; set; }

        [DisplayName("Nome Complexidade Análise")]
        [Required(ErrorMessage = "O campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeCplxAna { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O campo é requerido!")]
        public string Status { get; set; }

        public virtual ICollection<CadCplxAna> CadCplxAnas { get; set; }
    }
}
