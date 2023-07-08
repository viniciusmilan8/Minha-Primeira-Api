using SenaiApi.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Domain.DTos
{
    public class EnderecoDTo
    {
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String UF { get; set; }

    }
}
