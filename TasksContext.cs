using Microsoft.EntityFrameworkCore;
using projectEF.Models;

namespace projectEF;

public class TasksContext: DbContext
{
  public DbSet<Category> Categories {get;set;}
  public DbSet<Tasks> Tasks {get;set;}

  public TasksContext(DbContextOptions<TasksContext> options) :base(options) {}
}