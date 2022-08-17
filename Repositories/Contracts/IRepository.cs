using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    interface IRepository<K_DbContext, T_Entity, U_PrimaryKey>
                                                                where T_Entity : class
                                                                where K_DbContext : DbContext
    {
        K_DbContext Context { get; set; }
        DbSet<T_Entity> DbSet { get; set; }
        List<T_Entity> Select();
        bool Insert(T_Entity entity);
        bool Update(T_Entity entity);
        bool Delete(U_PrimaryKey id);
        bool Delete(T_Entity entity);
    }
}
