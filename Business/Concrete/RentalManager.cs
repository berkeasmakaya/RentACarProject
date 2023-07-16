﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class RentalManager : IRentalService
	{
		IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {

			_rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
		{
            if (rental.ReturnDate==null||rental.RentDate<rental.ReturnDate)
            {
				_rentalDal.Add(rental);
				return new SuccessResult();
			}
			return new ErrorResult();
		}

		public IResult Delete(Rental rental)
		{
			_rentalDal.Delete(rental);
			return new SuccessResult();
		}

		public IDataResult<List<Rental>> GetAll()
		{
			return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
		}

		public IDataResult<List<Rental>> GetByCarId(int carId)
		{
			return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
		}

		public IDataResult<List<Rental>> GetByCustomerId(int customerId)
		{
			return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.CustomerId == customerId));
		}

		public IDataResult<Rental> GetByRentalId(int rentalId)
		{
			return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.RentalId == rentalId));
		}

		public IResult Update(Rental rental)
		{
			_rentalDal.Update(rental);
			return new SuccessResult();
		}
	}
}
