using Microsoft.AspNetCore.Mvc;
using MovieEticket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Controllers
{
    public class ActorController : Controller
    {
        private readonly EticketDbContext _context;
        public ActorController(EticketDbContext context){
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }

    }
}
