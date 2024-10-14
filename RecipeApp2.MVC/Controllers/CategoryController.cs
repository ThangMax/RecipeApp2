using System;
using Microsoft.AspNetCore.Mvc;
using RecipeApp2.MVC.Data;

namespace RecipeApp2.MVC.Controllers;

public class CategoryController : Controller
{
    private readonly RecipeAppDBContext _context;

    public CategoryController(RecipeAppDBContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit(int id)
    {
        return View();
    }
    
    public IActionResult Delete(int id)
    {
        // Check if the category exists.
        var category = _context.Categories.Find(id);

        // If the category exists, remove it from the database.
        _context.Categories.Remove(category);
        _context.SaveChanges();

        // Redirect to the Index action.
        return RedirectToAction("Index");
    }
}
