using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> ReturnAll();
        Car ReturnAllBySelf(int carId);
        List<Car> ReturnAllByBrand(int brandId);
        List<Car> ReturnAllByColor(int colorId);
    }
}
