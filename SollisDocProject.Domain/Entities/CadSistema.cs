
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadSistema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSistema { get; set; }

        [DisplayName("Nome Sistema")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeSistema { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        public virtual ICollection<CadModulos> CadModulo { get; set; }
        public virtual ICollection<CadSistema> CadSistemas { get; set; }
    }
}
