using Core.Utilities.Results;
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
		IDataResult<Car> GetById(int carId);
		IDataResult<List<Car>> GetAll();
		IDataResult<List<Car>> GetCarsByBrandId(int brandId);
		IDataResult<List<Car>> GetCarsByColorId(int colorId);
		IDataResult<List<CarDetailsDto>> GetCarDetails();
		IResult Add(Car car);
		IResult Delete(Car car);
		IResult Update(Car car);
	}
}
