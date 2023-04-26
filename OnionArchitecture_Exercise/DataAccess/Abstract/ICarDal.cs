using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        // IEntityRepository<T> eklenince bu fonksiyonlara gerek kalmadı refaktör edildi...

        //Car GetById(int carId);
        //List<Car> GetAll();
        //List<Car> GetAllByBrand(int brandId);
        //List<Car> GetAllByColor(int colorId);

    }
}
