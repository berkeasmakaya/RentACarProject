﻿using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface ICarDal
	{
		Car GetById(int carId);
		List<Car> GetAll();
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
	}
}