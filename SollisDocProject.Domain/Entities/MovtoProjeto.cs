
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class MovtoProjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProjeto { get; set; }

        [DisplayName("cód Empresa")]
        public int IdEmpresa { get; set; }

        [DisplayName("Número Proposta")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string NumProposta { get; set; }

        [DisplayName("Data Inicial")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataInicial { get; set; }

        [DisplayName("Data Reagendamento")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataReagendamento { get; set; }

        [DisplayName("Data Conclusão")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataConclusao { get; set; }

        [DisplayName("Analista Responsável")]
        public string AnalistaResp { get; set; }

        [DisplayName("Nome Projeto")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeProjeto { get; set; }

        [DisplayName("Descrição Projeto")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string DescProjeto { get; set; }

        [DisplayName("Cód Status")]
        public int IdStatus { get; set; }

        [DisplayName("Cód Sistema")]
        public int IdSistema { get; set; }

        [DisplayName("Pendências")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(250, ErrorMessage = "O máximo permitido é de 250 caracteres!")]
        public string Pendencias { get; set; }

        [DisplayName("Versão")]
        public string Versao { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual CadEmpresa CadEmpresa { get; set; }

        [ForeignKey("IdStatus")]
        public virtual CadStatus CadStatus { get; set; }

        [ForeignKey("IdSistema")]
        public virtual CadSistema CadSistema { get; set; }

        public virtual ICollection<MovtoSolicProjeto> MovtoSolicProjeto { get; set; }
        public virtual ICollection<MovtoProjeto> MovtoProjetos { get; set; }
    }
}
