using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SollisDocProject.Domain.Entities
{
    public class CadEmpresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cpf { get; set; } 
        public string Cnpj { get; set; }
        public string Rg { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string FoneCom { get; set; }
        public string FoneRes { get; set; }
        public string FoneCel { get; set; }
        public string Email { get; set; }
        public string RespTecnico { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CadEmpresa> CadEmpresas { get; set; }
    }
}
