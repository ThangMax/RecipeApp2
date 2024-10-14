using System;
using Microsoft.AspNetCore.Mvc;

namespace RecipeApp2.MVC.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit(int id)
    {
        return View();
    }
}
