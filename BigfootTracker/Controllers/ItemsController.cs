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
        Item.BackpackWeight();
            if (Item._backpackWeight > 80)
            {
            return RedirectToAction("Remove");
            }
            else
            {
            return RedirectToAction("Index");
            }
        }

        [HttpPost("/items/remove")]
        public ActionResult Remove(int id)
        {
            Item._instances.Remove(Item._instances[id - 1]);
            Item.BackpackWeight();
            return View();
        }

        [HttpGet("/items/{id}")]
        public ActionResult Show(int id)
        {
        Item foundItem = Item.Find(id);
        return View(foundItem);
        }
    }
}