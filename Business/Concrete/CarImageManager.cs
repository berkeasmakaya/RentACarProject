using Business.Abstract;
using Business.Constants;
using Business.Contants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CarImageManager : ICarImageService
	{
		ICarImageDal _carImageDal;
		IFileHelper _fileHelper;
		public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
		{
			_carImageDal = carImageDal;
			_fileHelper = fileHelper;
		}
		public IResult Add(IFormFile file, CarImage carImage)
		{
			IResult result = BusinessRules.Run(CheckNumberOfImages());
            if (result.Success)
            {
				carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagePath);
				carImage.Date = DateTime.Now;
				_carImageDal.Add(carImage);
				return new SuccessResult();
			}
			return new ErrorResult(Messages.NumberOfImagesError);
            

		}

		public IResult Delete(CarImage carImage)
		{
			_fileHelper.Delete(PathConstants.ImagePath + carImage.ImagePath);
			_carImageDal.Delete(carImage);
			return new SuccessResult();
		}

		public IDataResult<List<CarImage>> GetAll()
		{
			return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
		}

		public IDataResult<List<CarImage>> GetByCarId(int carId)
		{
			IResult result = BusinessRules.Run(CheckCarImage(carId));
			if (!result.Success)
			{
				return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
			}
			return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId));
		}

		public IDataResult<CarImage> GetByImageId(int imageId)
		{
			return new SuccessDataResult<CarImage>(_carImageDal.Get(ci => ci.Id == imageId));
		}

		public IResult Update(IFormFile file, CarImage carImage)
		{
			carImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagePath + carImage.ImagePath, PathConstants.ImagePath);
			_carImageDal.Update(carImage);
			return new SuccessResult();
		}

		private IResult CheckNumberOfImages()
		{
			var result = _carImageDal.GetAll().Count();
			if (result < 5)
			{
				return new SuccessResult();
			}
			return new ErrorResult(Messages.NumberOfImagesError);
		}

		private IDataResult<List<CarImage>> GetDefaultImage(int carId)
		{
			List<CarImage> carImage = new List<CarImage>();
			carImage.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
			return new SuccessDataResult<List<CarImage>>(carImage);
		}

		private IResult CheckCarImage(int carId)
		{
			var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
			if (result > 0)
			{
				return new SuccessResult();
			}
			return new ErrorResult();
		}
	}
}
