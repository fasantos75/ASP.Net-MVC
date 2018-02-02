using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SollisDocProject.Domain.Entities
{
    public class CadEmpresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        [DisplayName("Nome Fantasia")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string NomeFantasia { get; set; }

        [DisplayName("Razão Social")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string RazaoSocial { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(14, ErrorMessage = "O máximo permitido é de 14 caracteres!")]
        public string Cpf { get; set; }

        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(18, ErrorMessage = "O máximo permitido é de 18 caracteres!")]
        public string Cnpj { get; set; }

        [DisplayName("RG")]
        public string Rg { get; set; }

        [DisplayName("IE")]
        public string Ie { get; set; }

        [DisplayName("IM")]
        public string Im { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(100, ErrorMessage = "O máximo permitido é de 100 caracteres!")]
        public string Endereco { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(50, ErrorMessage = "O máximo permitido é de 50 caracteres!")]
        public string Bairro { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        [MaxLength(50, ErrorMessage = "O máximo permitido é de 50 caracteres!")]
        public string Cidade { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Uf { get; set; }

        [DisplayName("CEP")]
        public string Cep { get; set; }

        [DisplayName("Fone Comercial")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string FoneCom { get; set; }

        [DisplayName("Fone Residencial")]
        public string FoneRes { get; set; }

        [DisplayName("Fone Celular")]
        public string FoneCel { get; set; }

        [DisplayName("Email")]
        [EmailAddressAttribute]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Email { get; set; }

        [DisplayName("Resp. Técnico")]
        public string RespTecnico { get; set; }

        [DisplayName("Data Cadastro")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "O Campo é requerido!")]
        public string Status { get; set; }

        public virtual ICollection<CadEmpresa> CadEmpresas { get; set; }
    }
}
