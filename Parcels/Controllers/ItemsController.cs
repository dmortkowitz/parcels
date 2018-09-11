using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Parcel> allItems = new List<Parcel> {};
      return View();
    }
    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create()
    {
      Parcel userParcel = new Parcel(Request.Form["new-width"], Request.Form["new-length"], Request.Form["new-heighth"], Request.Form["new-weight"]);
      userParcel.Save();
      userParcel.costToShip();
      List<Parcel> allItems = Parcel.GetAll();
      return View("Index", allItems);
    }
  }
}
