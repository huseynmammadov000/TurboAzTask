using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurboAzTask.Data;
using TurboAzTask.Models;

namespace TurboAzTask.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CarController(AppDbContext appDbContext) { 
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cars()
        {
            var cars = _appDbContext.Cars.Include(c=> c.Category).ToList();
            return View(cars);
        }


        //[HttpPost]
        //public  IActionResult GetCar(int id)
        //{
        //    var car =  _appDbContext.Cars.FirstOrDefaultAsync(p => p.Id == id);

        //    return View(car);
        //}

        //public IActionResult Add()
        //{
        //    var categories = _appDbContext.Categories.ToList();

        //    ViewData["Categories"] = categories;

        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(AddCarViewModel car)
        //{
        //    if (ModelState.IsValid)
        //    { 
        //        var newCar = new Car
        //        {
        //           CategoryID = car.CategoryId,
        //            Price = car.Price,
        //            Vendor = car.Vendor,
        //            ImageUrl = car.ImageUrl,
        //            Name = car.Name,

        //        };
        //        _appDbContext.Cars.Add(newCar);
        //        await _appDbContext.SaveChangesAsync();
        //        return RedirectToAction("Cars");
        //    }
        //    return View(car);
        //}


        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var car = _appDbContext.Cars.FirstOrDefault(p => p.Id == id);
        //    _appDbContext.Cars.Remove(car);
        //    _appDbContext.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        public IActionResult EditCar(int id)
        {
            var car = _appDbContext.Cars.FirstOrDefault(c => c.Id == id);


            return View(car);
        }


        //[HttpPost]
        //public IActionResult Edit(Car uCar)
        //{
        //    var car = _appDbContext.Cars.FirstOrDefault(c => c.Id == uCar.Id);

        //    car.Name = uCar.Name;
        //    car.Price = uCar.Price;
        //    car.Vendor = uCar.Vendor;
        //    car.ImageUrl = uCar.ImageUrl;
        //    car.CategoryID = uCar.CategoryID;
        //    _appDbContext.SaveChanges();

        //    return RedirectToAction("Index");


        //    return View(uCar);
        //}
    }
}
