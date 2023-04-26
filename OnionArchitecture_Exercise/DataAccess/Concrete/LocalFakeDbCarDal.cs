using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class LocalFakeDbCarDal : ICarDal
    {
        List<Car> _cars;
        public LocalFakeDbCarDal()
        {
            _cars = new List<Car>{
                new Car {CarId = 1, BrandId = 1, ColorId = 3, DailyPrice = 75, Description = "Sports Car", ModelYear = "2019"},
                new Car {CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "Luxury Car", ModelYear = "2021"},
                new Car {CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 50, Description = "Sedan Car", ModelYear = "2012"},
                new Car {CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = 60, Description = "Hatchbag Car", ModelYear = "2015"},
                new Car {CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 70, Description = "Classic Car", ModelYear = "1977"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        
        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            updatedCar.CarId = car.CarId;
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;

        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(deletedCar);
        }

        public Car Get(Func<Car, bool> filter)
        {
            return _cars.SingleOrDefault(filter);
        }

        public List<Car> GetAll(Func<Car, bool> filter = null)
        {
            return filter == null ? _cars : _cars.Where(filter).ToList() ;
        }
    }
}
