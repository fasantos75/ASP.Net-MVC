
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadModulos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdModulo { get; set; }

        [DisplayName("Cód Sistema")]
        public int IdSistema { get; set; }

        [DisplayName("Nome Módulo")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeModulo { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        [ForeignKey("IdSistema")]
        public virtual CadSistema CadSistema { get; set; }

        public virtual ICollection<CadModulos> CadModulo { get; set; }
    }
}
