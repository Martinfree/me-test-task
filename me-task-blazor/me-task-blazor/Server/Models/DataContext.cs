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
        public DbSet<WorkerModel> WorkerModels { get; set; }
        public DbSet<TaskModel> TaskModels { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>()
            .HasMany<WorkerModel>(s => s.Workers);


            // Alternate possible way  
            //modelBuilder.Entity<Student>()  
            // .HasMany<StudentAddress>(s =>s.StudentAddress)  
            // .WithRequired(s =>s.Student)  
            // .HasForeignKey(s =>s.StudentId);  

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) //
        {
            Database.EnsureCreated();   // create by first call
        }
    }
}
