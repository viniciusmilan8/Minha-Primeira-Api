using AutoMapper;
using SenaiApi.Domain.DTos;
using SenaiApi.Domain.Entidades;
using SenaiApi.Repository.Interfaces;
using SenaiApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Service.Service
{
    public class PessoaService : IPessoaService
    {
        private IMapper _mapper;
        private IPessoaRepository _pessoaRepositorio;
        public PessoaService(IMapper mapper, IPessoaRepository pessoaRepository) {
            _mapper = mapper;
            _pessoaRepositorio = pessoaRepository;
        }
        public List<Pessoa> BuscarTodos()
        {
            return _pessoaRepositorio.PegarTodasAsPessoas();
        }
        public bool Salvar(PessoaDTo pessoaDTo)
        {
            var pessoa = _mapper.Map<Pessoa>(pessoaDTo);
            return _pessoaRepositorio.SalvarPessoa(pessoa);
        }

        public bool Delet(long id)
        {
            return _pessoaRepositorio.DeletarPessoa(id);
        }
    }
}
