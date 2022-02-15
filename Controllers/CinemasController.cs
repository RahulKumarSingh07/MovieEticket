using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieEticket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly EticketDbContext _context;
        public CinemasController(EticketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
