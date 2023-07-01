using SenaiApi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domain.Entidades
{
    public class Endereco : BaseEntity
    {
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String UF { get; set; }
        public long PessoaId { get; set; }
        public Pessoa Pessoa { get; set; } //Para poder acessar a pessoa pelo endereco
    }
}