using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IRentalService
	{
		IResult Add(Rental rental);
		IResult Delete(Rental rental);
		IResult Update(Rental rental);
		IDataResult<List<Rental>> GetAll();
		IDataResult<List<Rental>> GetByCustomerId(int customerId);
		IDataResult<List<Rental>> GetByCarId(int carId);
		IDataResult<Rental> GetByRentalId(int rentalId);
	}
}
