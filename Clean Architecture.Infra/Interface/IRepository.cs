using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Infra.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity?> GetById(Int64 id);
        Task Insert(TEntity? entity);
        Task Update(TEntity? entity);
        Task<IQueryable<TEntity?>> GetAll();
    }
}
