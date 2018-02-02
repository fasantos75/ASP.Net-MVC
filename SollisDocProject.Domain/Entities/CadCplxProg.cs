
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadCplxProg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCplxProg { get; set; }

        [DisplayName("Nome Complexidade Programação")]
        [Required(ErrorMessage = "O campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeCplxProg { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O campo é requerido!")]
        public string Status { get; set; }

        public virtual ICollection<CadCplxProg> CadCplxProgs { get; set; }
    }
}
