using AutoMapper;
using SenaiApi.Domain.DTos;
using SenaiApi.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Mappers
{
    public class PessoaMapper : Profile
    {
        public PessoaMapper() {
            CreateMap<PessoaDTo, Pessoa>();
        }
    }
}
