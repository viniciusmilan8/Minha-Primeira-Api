using Microsoft.EntityFrameworkCore;
using SenaiApi.Domain.Entidades;
using SenaiApi.Repository.Contexts;
using SenaiApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Repositorios
{
    public class PessoaRepositorio : GenericRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepositorio(ApiContext context) : base(context) { }

        public List<Pessoa> PegarTodasAsPessoas()
        {
            return GetAll().Include(c => c.Endereco).ToList();        
        }
        public bool SalvarPessoa(Pessoa pessoa)
        {
            try
            {
                Salvar(pessoa);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletarPessoa(long id)
        {
            try
            {
                Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
