using eCommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    abstract class RepositoryBase<TEntity> where TEntity
    {
        internal DataContext context;
        internal DbSet<TEntity> dbSet;
    }
}
