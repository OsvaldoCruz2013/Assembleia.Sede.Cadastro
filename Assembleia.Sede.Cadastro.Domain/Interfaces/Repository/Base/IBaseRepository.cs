using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assembleia.Sede.Cadastro.Domain.Interfaces.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task AddRangeAsync(IList<TEntity> entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task UpdateRangeAsync(IEnumerable<TEntity> entity);

        Task<TEntity> DeleteAsync(int Id);

        Task<TEntity> DeleteAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(int Id);

        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
    }
}