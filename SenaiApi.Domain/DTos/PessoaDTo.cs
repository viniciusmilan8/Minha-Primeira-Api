using SenaiApi.Domain.Entidades;
using SenaiApi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domain.DTos
{
    public class PessoaDTo
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public EnderecoDTo Endereco { get; set; }
    }
}
