using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car() { CarId=1, BrandId=1, ColorId=1, DailyPrice=200, ModelYear=2020, CarName="Opel-Black" },
                new Car() { CarId=2, BrandId=1, ColorId=2, DailyPrice=250, ModelYear=2021, CarName="Opel-Red" },
                new Car() { CarId=3, BrandId=2, ColorId=1, DailyPrice=500, ModelYear=2019, CarName="Mercedes-Black" },
                new Car() { CarId=4, BrandId=3, ColorId=3, DailyPrice=700, ModelYear=2021, CarName="BMW-White" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

		public Car Get(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll()
        {
            return _cars;
        }

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Car GetById(int carId)
        {
            Car car = _cars.First(c => c.CarId == carId);
            return car;
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

        }
    }
}
