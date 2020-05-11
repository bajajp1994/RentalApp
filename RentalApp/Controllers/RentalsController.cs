using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentalApp.Data;
using RentalApp.Dtos;
using RentalApp.Models;

namespace RentalApp.Controllers
{
    public class RentalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: Rentals/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Name");
            return View();
        }

        // POST: Rentals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RentalDto rentalDto) 
        {
             var customer = await _context.Customers.SingleOrDefaultAsync(c => c.Id == rentalDto.Customer);
             var movies = await _context.Movies.Where( m => rentalDto.Movie.Contains(m.Id)).ToListAsync();
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return NotFound();
                }
                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Add(rental);
            }
                await _context.SaveChangesAsync();
                return View("Index");
        }
    }
}

       
