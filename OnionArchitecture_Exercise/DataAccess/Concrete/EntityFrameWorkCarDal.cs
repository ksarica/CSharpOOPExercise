using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EntityFrameWorkCarDal : ICarDal
    {
        // Not in my interest Since Entity Framework and DB Operations are for Web Development :)

        public void Add(Car Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car Entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Func<Car, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Func<Car, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car Entity)
        {
            throw new NotImplementedException();
        }
    }
}
