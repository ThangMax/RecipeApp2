using System;
using Microsoft.EntityFrameworkCore;
using RecipeApp.MVC.Models;

namespace RecipeApp2.MVC.Data;

public class RecipeAppDBContext : DbContext
{
    public RecipeAppDBContext (DbContextOptions<RecipeAppDBContext> options) : base (options)
    {

    }
    
    public DbSet<Category> Categories {get; set;}
}
