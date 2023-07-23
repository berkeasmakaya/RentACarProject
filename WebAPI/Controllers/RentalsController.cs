using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RentalsController : ControllerBase
	{
		IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
			_rentalService = rentalService;
        }

		[HttpGet("getall")]
		public IActionResult GetAll() 
		{ 
			var result = _rentalService.GetAll();
            if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbycustomerid")]
		public IActionResult GetByCustomerId(int customerId) 
		{ 
			var result = _rentalService.GetByCustomerId(customerId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result.Message);
		}

		[HttpGet("getbycarid")]
		public IActionResult GetByCarId(int carId) 
		{
			var result = _rentalService.GetByCarId(carId); 
			if (result.Success)
			{
				return Ok(result);
			}	
			return BadRequest(result.Message);
		}

		[HttpGet("getbyrentalid")]
		public IActionResult GetByRentalId(int rentalId) 
		{
			var result = _rentalService.GetByRentalId(rentalId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result.Message);
		}
    }
}
