using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
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
        public ActionResult Create(string name, string description, bool purchased, int weight)
        {
        Item myItem = new Item(name, description, purchased, weight);
        return RedirectToAction("Index");
        }
    }
}