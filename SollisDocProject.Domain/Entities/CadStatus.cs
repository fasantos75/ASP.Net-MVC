
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdStatus { get; set; }

        [DisplayName("Nome Status Projeto")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeStatus { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        public virtual ICollection<CadStatus> CadStatuS { get; set; }
    }
}
