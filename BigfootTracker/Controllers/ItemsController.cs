using Microsoft.AspNetCore.Mvc;
using BigfootTracker.Models;
using System.Collections.Generic;

namespace BigfootTracker.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/items")]
        public ActionResult Index()
        {
        List<Item> allItems = Item.GetAll();
        return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult New()
        {
        return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string name, string description, string purchased, int weight)
        {
        Item myItem = new Item(name, description, purchased, weight);
        return RedirectToAction("Index");
        }

        [HttpGet("/items/{id}")]
        public ActionResult Show(int id)
        {
        Item foundItem = Item.Find(id);
        return View(foundItem);
        }
    }
}