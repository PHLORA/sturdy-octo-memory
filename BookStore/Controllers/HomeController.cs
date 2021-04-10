using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
	public class HomeController : Controller
	{
		private BookContext db;
		public HomeController(BookContext context)
		{
			db = context;
		}
		public async Task<IActionResult> Index()
		{
			return View(await db.Books.ToListAsync());
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(Book book)
		{
			db.Books.Add(book);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}
