using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using me_task_blazor.Server.Controllers;
using me_task_blazor.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using me_task_blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace Tests
{
    public class DbContextTests
    {
        // Data Set
        int images = 1000;
        DateTime time = DateTime.Now;
        List<string> workersName = new List<string> { "P1", "P2", "P3" };
        List<int> workersSpeed = new List<int> { 2, 3, 4 };
        List<WorkerModel> workers = new List<WorkerModel>(){
                            new WorkerModel
                            {
                                Name = "P1",
                                ImgPerMinute = 2
                            },
                            new WorkerModel
                            {
                                Name = "P2",
                                ImgPerMinute = 3
                            },
                            new WorkerModel
                            {
                                Name = "P3",
                                ImgPerMinute = 4
                            } };

        //db options
        static string dbName = Guid.NewGuid().ToString();
        DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: dbName).Options;
        DataContext _context;
        
        /// <summary>
        /// Constructor for create db data
        /// </summary>
        public DbContextTests()
        {
            using (_context = new DataContext(options))
            {
                if (!_context.TaskModels.Any())
                {
                    _context.TaskModels.Add(new TaskModel
                    {
                        Id = 1,
                        Images = images,
                        ReleaseDate = time,
                        Workers = new List<WorkerModel>(){
                            new WorkerModel
                            {
                                Id = 1,
                                Name = "P1",
                                ImgPerMinute = 2
                            },
                            new WorkerModel
                            {
                                Id = 2,
                                Name = "P2",
                                ImgPerMinute = 3
                            },
                            new WorkerModel
                            {
                                Id = 3,
                                Name = "P3",
                                ImgPerMinute = 4
                            }
                        }.ToArray()
                    });
                    _context.SaveChanges();
                }
            }


        }
        
        /// <summary>
        /// Test TaskMosel in db
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task TaskModelDbTest()
        {
            using (_context = new DataContext(options))
            {
                TaskModel model = await _context.TaskModels.SingleAsync(x => x.Id == 1);

                Assert.Equal(1, model.Id);
                Assert.Equal(model.Images, images);
                Assert.Equal(model.ReleaseDate, time);
            }
        }
        
        /// <summary>
        /// Test WorkerModel in db
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task WorkerModelDbTest()
        {
            using (_context = new DataContext(options))
            {
                WorkerModel model = await _context.WorkerModels.SingleAsync(x => x.Id == 1);

                Assert.Equal(1, model.Id);
                Assert.Equal(model.Name, workersName[0]);
                Assert.Equal(model.ImgPerMinute, workersSpeed[0]);
            }
        }
    }
}

