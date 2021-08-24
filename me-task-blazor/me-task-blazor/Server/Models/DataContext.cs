using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using me_task_blazor.Shared;

namespace me_task_blazor.Server.Models
{
    public class DataContext : DbContext
    {
        public DbSet<TaskModel> TaskModels { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) //
        {
            Database.EnsureCreated();   // create by first call
        }
        public DbSet<WorkerModel> WorkerModel { get; set; }
    }
}
