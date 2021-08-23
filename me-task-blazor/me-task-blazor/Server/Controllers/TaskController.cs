using me_task_blazor.Shared;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace me_task_blazor.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")] // api/TaskModel
    [Produces("application/json")]
    public class TaskModelController : ControllerBase
    {
        private readonly ILogger<TaskModelController> logger;

        public TaskModelController(ILogger<TaskModelController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<TaskModel> GetAll()
        {
            return Enumerable.Range(1, 10).Select(index => new TaskModel
            {
                Id = index,
                Images = 1000,
                ReleaseDate = DateTime.Now,
                Res = "None"
            })
            .ToArray();
        }

        [HttpGet("{id:int}")]
        public IEnumerable<TaskModel> DeleteContact(int id)
        {
            return Enumerable.Range(0,1).Select(f => new TaskModel
            {
                Id = id,
                Images = 1000,
                ReleaseDate = DateTime.Now,
                Res = "NoneGetId"
            })
            .ToArray();

            //[HttpPost]

        }
    }
}
