using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie_Purchase_MVC.Data;
using Movie_Purchase_MVC.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Purchase_MVC.Controllers
{
    public class MovieRentsController : Controller
    {
        private readonly Movie_Purchase_MVC_DB_Context _context;

        public MovieRentsController(Movie_Purchase_MVC_DB_Context context)
        {
            _context = context;
        }

        // GET: MovieRents
        public async Task<IActionResult> Index()
        {
            var movie_Purchase_MVC_DB_Context = _context.MovieRent.Include(m => m.Customer_Obj).Include(m => m.Movie_Obj);
            return View(await movie_Purchase_MVC_DB_Context.ToListAsync());
        }

        // GET: MovieRents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieRent = await _context.MovieRent
                .Include(m => m.Customer_Obj)
                .Include(m => m.Movie_Obj)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieRent == null)
            {
                return NotFound();
            }

            return View(movieRent);
        }

        [Authorize]
        // GET: MovieRents/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "Id", "Email");
            ViewData["MovieID"] = new SelectList(_context.Movie, "Id", "MovieTitle");
            return View();
        }

        // POST: MovieRents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerID,MovieID,IssueDate,ReturnDate")] MovieRent movieRent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieRent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "Id", "Email", movieRent.CustomerID);
            ViewData["MovieID"] = new SelectList(_context.Movie, "Id", "MovieTitle", movieRent.MovieID);
            return View(movieRent);
        }

        private bool MovieRentExists(int id)
        {
            return _context.MovieRent.Any(e => e.Id == id);
        }
    }
}
