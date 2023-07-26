using CrudBucketMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using CrudBucketMVC.Models;

namespace CrudBucketMVC.Controllers.Owners
{
	public class OwnersController : Controller
	{
		private readonly CrudBucketContext _context;

		public OwnersController(CrudBucketContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var owners = _context.Owners;

			return View(owners);
		}

		[Route("/owners/{ownerId:int}")]
		public IActionResult Show(int ownerId)
		{
			var owner = _context.Owners.Find(ownerId);

			return View(owner);
		}

		public IActionResult New()
		{
			return View();
		}

		[HttpPost]
		[Route("/owners")]
		public IActionResult Create(Owner owner)
		{
			_context.Owners.Add(owner);
			_context.SaveChanges();

			var ownerId = owner.Id;
			return Redirect($"/owners/{ownerId}");
		}
	}
}
