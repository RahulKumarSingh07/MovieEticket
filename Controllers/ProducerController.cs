using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieEticket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Controllers
{
    public class ProducerController : Controller
    {
        private readonly EticketDbContext _context;
        public ProducerController(EticketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allproducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
