using Microsoft.AspNetCore.Mvc;
using ControlMigracion.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlMigracion.Controllers
{
    public class ViajerosController : Controller
    {
        private readonly DbContext _context;

        public ViajerosController(DbContext context)
        {
            _context = context;
        }

        // GET: Viajeros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Viajeros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Viajero viajero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viajero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viajero);
        }

        // GET: Viajeros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Viajeros.ToListAsync());
        }

        // GET: Viajeros/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var viajero = await _context.Viajeros
                .FirstOrDefaultAsync(m => m.ViajeroID == id);
            if (viajero == null)
            {
                return NotFound();
            }

            return View(viajero);
        }
    }
}
