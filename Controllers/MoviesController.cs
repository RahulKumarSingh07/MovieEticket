using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieEticket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly EticketDbContext _context;
        public MoviesController(EticketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allproducers = await _context.Moviess.ToListAsync();
            return View();
        }
    }
}
