
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class MovtoSolicProjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSolicitacao { get; set; }

        [DisplayName("Cód Projeto")]
        public int IdProjeto { get; set; }

        [DisplayName("Data Inicial")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataInicial { get; set; }

        [DisplayName("Data Reagendamento")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataReagendamento { get; set; }

        [DisplayName("Data Conclusão")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataConclusao { get; set; }

        [DisplayName("Hora Inicial AM")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime HrIni1 { get; set; }

        [DisplayName("Hora Final AM")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime HrFin1 { get; set; }

        [DisplayName("Hora Inicial PM")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime HrIni2 { get; set; }

        [DisplayName("Hora Final PM")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime HrFin2 { get; set; }

        [DisplayName("Cód Empresa")]
        public int IdEmpresa { get; set; }

        [DisplayName("Funcionalidade")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(250, ErrorMessage = "O máximo permitido é de 250 caracteres!")]
        public string Funcionalidade { get; set; }

        [DisplayName("Tp Prazo")]
        public string TpPrazo { get; set; }

        [DisplayName("Nome Motivo")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeMotivo { get; set; }

        [DisplayName("Usabilidade")]
        public string Usabilidade { get; set; }

        [DisplayName("Cód Cplx Análise")]
        public int IdCplxAna { get; set; }

        [DisplayName("Cód Cplx Programação")]
        public int IdCplxProg { get; set; }

        [DisplayName("Cód St Projeto")]
        public int IdStProjeto { get; set; }

        [DisplayName("Cód Sistema")]
        public int IdSistema { get; set; }

        [DisplayName("Cód Motivo")]
        public int IdMotivo { get; set; }

        [DisplayName("Autorizado?")]
        public bool FlAutorizado { get; set; }

        [DisplayName("Cód Módulo")]
        public int IdModulo { get; set; }

        [DisplayName("Versão")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Versao { get; set; }

        [DisplayName("CRUD")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string Crud { get; set; }

        [DisplayName("Nome Script")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeScript { get; set; }

        [DisplayName("Nome Tabela")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeTabela { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual CadEmpresa CadEmpresa { get; set; }

        [ForeignKey("IdProjeto")]
        public virtual MovtoProjeto MovtoProjeto { get; set; }

        [ForeignKey("IdCplxAna")]
        public virtual CadCplxAna CadCplxAna { get; set; }

        [ForeignKey("IdCplxProg")]
        public virtual CadCplxProg CadCplxProg { get; set; }

        [ForeignKey("IdStProjeto")]
        public virtual CadStProjeto CadStProjeto { get; set; }

        [ForeignKey("IdModulo")]
        public virtual CadModulos CadModulos { get; set; }

        public virtual ICollection<MovtoSolicProjeto> MovtoSolicProjetos { get; set; }
    }
}
