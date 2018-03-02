using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Repository.Context;

namespace Senai.Ifood.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IFoodContext _dbContext;

        public BaseRepository(IFoodContext ifoodcontext)
        {
            _dbContext = ifoodcontext;
        }
        public int Atualizar(T dados)
        {
            try
            {
                _dbContext.Set<T>().Update(dados);
                return _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T BuscarPorId(int id, string[] includes=null)
        {
            try
            {
                var keyProperty = _dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties[0];
	            return _dbContext.Set<T>().FirstOrDefault(e => EF.Property<int>(e, keyProperty.Name) == id);
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int Deletar(T dados)
        {
            try
            {
                _dbContext.Set<T>().Remove(dados);
                return _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Inserir(T dados)
        {
            try
            {
                _dbContext.Set<T>().Add(dados);
                return _dbContext.SaveChanges();
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<T> Listar(string[] includes=null)
        {
            try
            {
                var query = _dbContext.Set<T>().AsQueryable();

                if(includes == null) return query;
                
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
                return query.ToList();
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}