using SenaiApi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domain.Entidades
{
    public class Pessoa : BaseEntity
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime DataInsercao { get; set; }
        public SexoEnum Sexo { get; set; }
        public Endereco Endereco { get; set; }
    }
}