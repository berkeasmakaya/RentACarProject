﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTO_s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
	{
		public List<CarDetailsDto> GetCarDetails()
		{
			using (RentACarContext context = new RentACarContext())
			{
				var result = from c in context.Cars
							 join b in context.Brands
							 on c.BrandId equals b.BrandId
							 join co in context.Colors
							 on c.ColorId equals co.ColorId
							 select new CarDetailsDto
							 {
								 CarName = c.CarName,
								 BrandName = b.BrandName,
								 ColorName = co.ColorName,
								 DailyPrice = c.DailyPrice
							 };
				return result.ToList();
			}
		}
	}
}
