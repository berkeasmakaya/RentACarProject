using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
	public static class Messages
	{
		public static string BrandAdded = "Brand Added!";
		public static string BrandDeleted = "Brand Deleted!";
		public static string BrandUpdated = "Brand Updated!";
		public static string BrandsListed = "Brands Listed!";

		public static string CarAdded = "Car Added!";
		public static string CarDeleted = "Car Deleted!";
		public static string CarUpdated = "Car Updated!";
		public static string CarsListed = "Cars Listed!";

		public static string ColorAdded = "Color Added!";
		public static string ColorDeleted = "Color Deleted!";
		public static string ColorUpdated = "Color Updated!";
		public static string ColorsListed = "Color Listed!";
		
		public static string CustomerAdded ="Customer Added!";
		public static string CustomerDeleted="Customer Deleted!";
		public static string CustomersListed="Customers Listed!";
		public static string CustomerUpdated="Customer Updated!";
		
		
		public static string NumberOfImagesError = "One car has maximum 5 images!";
		public static string UserNotFound = "User Not Found!";
		public static string PasswordError = "Password Error!";
		public static string SuccessfullLogin = "Successfull Login! ";
		public static string UserAlreadyExists = "User Already Exists! ";
		public static string UserRegistered = "User Registered!";
		public static string AccessTokenCreated = "Access Token Created!";
		internal static string? AuthorizationDenied;
	}
}
