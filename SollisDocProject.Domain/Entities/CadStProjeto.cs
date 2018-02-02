
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadStProjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdStProjeto { get; set; }

        [DisplayName("Nome Status Projeto")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(50, ErrorMessage = "O máximo permitido é de 50 caracteres!")]
        public string NomeStProjeto { get; set; }

        [DisplayName("Obs do Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(250, ErrorMessage = "O máximo permitido é de 250 caracteres!")]
        public string ObsStProjeto { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        public virtual ICollection<CadStProjeto> CadStProjetos { get; set; }
    }
}
