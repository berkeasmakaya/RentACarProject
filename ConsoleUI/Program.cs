using Business.Concrete;
using DataAccess.Concrete;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.Write(car.Description);
                Console.Write("-");
                Console.Write(car.ModelYear);
				Console.Write("-");
				Console.Write(car.DailyPrice + "$");
                Console.WriteLine();
            }

        }
	}
}