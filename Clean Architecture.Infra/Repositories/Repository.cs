using Clean_Architecture.Infra.Context;
using Clean_Architecture.Infra.Interface;
using Microsoft.EntityFrameworkCore;


namespace Clean_Architecture.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(AppDbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task<TEntity?> GetById(Int64 ID)
        {
            return await DbSet.FindAsync(ID);
        }

        public virtual async Task Insert(TEntity? entity)
        {
            DbSet.Add(entity);
        }

        public virtual async Task Update(TEntity? entity)
        {
            DbSet.Update(entity);
        }

        public virtual async Task<IQueryable<TEntity?>> GetAll()
        {
            return DbSet;
        }


        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
