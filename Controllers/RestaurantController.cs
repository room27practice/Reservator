using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservator.Data;
using Reservator.Models;

namespace Reservator.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly ApplicationDbContext db;

        public RestaurantController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<Restaurant> allRestaurants = db.Restaurants
                .Include(r => r.Places)
                .Where(x => x.IsDeleted == false)
                //.ThenInclude(p=>p.Reservations)
                .ToList();

            return View(allRestaurants);
        }

        public IActionResult Details(int id)
        {
            Restaurant restaurantFd = db.Restaurants.Where(x=>x.IsDeleted==false)
                .Include(r => r.Places).FirstOrDefault(r => r.Id == id);

            return View(restaurantFd);
        }

    }
}
