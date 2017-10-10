using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/car/list")]
    public ActionResult CarList()
    {
      List<string> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/car/create")]
    public ActionResult CreateList()
    {
      Car newCar = new Car (Request.Form["make"],int.Parse(Request.Form["price"]),int.Parse(Request.Form["miles"]));
      newCar.Save();
      return View(newCar);
    }

    [HttpPost("/car/list/clear")]
     public ActionResult CarListClear()
     {
         Car.ClearAll();
         return View();
     }

  }
}
