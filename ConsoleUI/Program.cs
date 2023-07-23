using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using System.Runtime.CompilerServices;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//CarTestInMemory();
			//ColorUpdateTest();
			//ColorDeleteTest();

			CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Car Name: " + car.BrandName + " " + car.CarName + " / Color Name: " + car.ColorName + " / Daily Price: " + car.DailyPrice+"$");
            }


        }

		private static void ColorDeleteTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			colorManager.Delete(new Color
			{
				ColorId = 1,
				ColorName = "Red",
			});
		}

		private static void ColorUpdateTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			foreach (var color in colorManager.GetAll().Data)
			{
				if (color.ColorId == 3)
				{
					Color newColor = color;
					newColor.ColorName = "Black";
					colorManager.Update(newColor);
				}
			}
		}

		private static void CarTestInMemory()
		{
			CarManager carManager = new CarManager(new InMemoryCarDal());
			foreach (var car in carManager.GetAll().Data)
			{
				Console.Write(car.CarName);
				Console.Write("-");
				Console.Write(car.ModelYear);
				Console.Write("-");
				Console.Write(car.DailyPrice + "$");
				Console.WriteLine();
			}
		}
	}
}