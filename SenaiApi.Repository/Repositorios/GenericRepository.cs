using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity 
    {
        private ApiContext _context;

        public GenericRepository(ApiContext context)
        {
            _context = context;
        }

        //Monta a querry e depois pesquisa no banco(meu serviço retorna as querys prontas)
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(long id)
        {
            var entity = _context.Set<T>().First(c => c.Id == id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public T Salvar(T entity)
        {
            if ((entity as BaseEntity).Id == 0)
                Add(entity);
            else
                Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
