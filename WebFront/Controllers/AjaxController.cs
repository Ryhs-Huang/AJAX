using Microsoft.AspNetCore.Mvc;
using WebFront.Models;

namespace WebFront.Controllers
{
	public class AjaxController : Controller
	{
		NorthwindContext _context;
		public AjaxController(NorthwindContext context)
		{
			_context = context;
		}

		//Get: Ajax/Greet
		[HttpGet]
		public string Greet(string Name)
		{
			Thread.Sleep(1000);
			return $"Hello: {Name}";
		}

		//Post: Ajax/PostGreeet
		[HttpPost]
		public string PostGreet(string Name) 
		{
			return $"Hello: {Name}";
		}

		//Post: Ajax/FetchPostGreet
		[HttpPost]
		public string FetchPostGreet(Parameter p) 
		{
			Thread.Sleep(1000);
			return $"Hello: {p.Name}";
		}

		//Post: Ajax/CheckName
		[HttpPost]
		public string CheckName(string Name)
		{
			bool Exist=_context.Employees.Any (x=>x.FirstName==Name);
			return Exist ?"true" : "false" ;
		}

		//Post: Ajax/FetchCheckName
		[HttpPost]
		public string FetchCheckName(Parameter p)
		{
			bool Exist = _context.Employees.Any(x => x.FirstName == p.Name);
			return Exist ? "true" : "false";
		}

	}
}
