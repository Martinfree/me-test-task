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
    public class TaskModelControllerTests
    {
        // Data Set
        int images = 1000;
        DateTime time = DateTime.Now;
        List<string> workersName = new List<string> { "P1","P2","P3"};
        List<int> workersSpeed = new List<int> { 2,3,4};
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

        static string dbName = Guid.NewGuid().ToString();
        DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: dbName).Options;
        //TaskModelsController _controller;
        DataContext _context;
        
        public TaskModelControllerTests()
        {
            using (_context = new DataContext(options))
            {
                if (!_context.TaskModels.Any())
                {
                    _context.TaskModels.Add(new TaskModel {
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
        [Fact]
        public async Task TaskModelGetAll()
        {
            using (_context = new DataContext(options))
            {
                var controller = new TaskModelsController(_context);
                var result = await controller.Get();                
                var model = Assert.IsAssignableFrom<IEnumerable<TaskModel>>(result);
                
                Assert.Equal(1, model.Count());
            }
        }
        
        //[Fact]
        /*public async Task TaskModelGetById()
        {
            
            using (_context = new DataContext(options))
            {
                var controller = new TaskModelsController(_context);
                var result = await controller.Get(1);
                var r = result.Result as OkObjectResult;
                Assert.Equal(200,r.StatusCode);
                Assert.Equal(1, result.Value.Id);
            }
        }*/

        [Fact]
        public async Task TaskModelNullPost()
        {

            using (_context = new DataContext(options))
            {
                var controller = new TaskModelsController(_context);
                var result = await controller.Post(null);
                var r = result.Result as BadRequestObjectResult;
            }
        }
        
        [Fact]
        public async Task TaskModelPost()
        {

            using (_context = new DataContext(options))
            {
                var controller = new TaskModelsController(_context);
                var result = await controller.Post(null);
                var r = result.Result as BadRequestObjectResult;
                Assert.Equal(200, r.StatusCode);
                Assert.Equal(1000, result.Value.Images);
            }
        }
    }
        
    }


