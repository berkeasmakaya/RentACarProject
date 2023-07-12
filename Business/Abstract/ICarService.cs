using Entites.Concrete;
using Entites.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICarService
	{
		Car GetById(int carId);
		List<Car> GetAll();
		List<Car> GetCarsByBrandId(int brandId);
		List<Car> GetCarsByColorId(int colorId);
		List<CarDetailsDto> GetCarDetails();
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
	}
}
