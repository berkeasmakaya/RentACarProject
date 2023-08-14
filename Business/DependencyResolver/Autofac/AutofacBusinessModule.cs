using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolver.Autofac
{
	public class AutofacBusinessModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CarManager>().As<ICarService>();
			builder.RegisterType<EfCarDal>().As<ICarDal>();

			builder.RegisterType<ColorManager>().As<IColorService>();
			builder.RegisterType<EfColorDal>().As<IColorDal>();

			builder.RegisterType<BrandManager>().As<IBrandService>();
			builder.RegisterType<EfBrandDal>().As<IBrandDal>();

			builder.RegisterType<CustomerManager>().As<ICustomerService>();
			builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

			builder.RegisterType<UserManager>().As<IUserService>();
			builder.RegisterType<EfUserDal>().As<IUserDal>();

			builder.RegisterType<RentalManager>().As<IRentalService>();
			builder.RegisterType<EfRentalDal>().As<IRentalDal>();

			builder.RegisterType<CarImageManager>().As<ICarImageService>();
			builder.RegisterType<EfCarImageDal>().As<ICarImageDal>();

			builder.RegisterType<FileHelperManager>().As<IFileHelper>();

			builder.RegisterType<AuthManager>().As<IAuthService>();
			builder.RegisterType<JwtHelper>().As<ITokenHelper>();
		}
	}
}
