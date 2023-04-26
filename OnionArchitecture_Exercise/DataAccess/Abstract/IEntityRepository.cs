using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);

        T Get(Func<T,bool> filter);
        List<T> GetAll(Func<T,bool> filter = null);

    }
}
