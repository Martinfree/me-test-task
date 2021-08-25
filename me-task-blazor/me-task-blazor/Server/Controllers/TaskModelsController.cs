using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using me_task_blazor.Server.Models;
using me_task_blazor.Shared;
using System.Net.Http;

namespace me_task_blazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskModelsController : ControllerBase
    {
        DataContext db;

        public TaskModelsController(DataContext context)
        {
            db = context;
            if (!db.TaskModels.Any())
            {
                db.TaskModels.Add(new TaskModel { });
                db.TaskModels.Add(new TaskModel { });
                db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<TaskModel>> Get()
        {
            var response = await db.TaskModels
                .Include(one => one.Workers)
                .ToListAsync();

            
            return response;
        }
        //return await db.TaskModels.ToListAsync();
    

        // GET api/TaskModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskModel>> Get(int id)
        {
            TaskModel TaskModel = await db.TaskModels.FirstOrDefaultAsync(x => x.Id == id);
            if (TaskModel == null)
                return NotFound();
            return new ObjectResult(TaskModel);
        }

        // POST api/TaskModels/
        [HttpPost]
        public async Task<ActionResult<TaskModel>> Post(TaskModel TaskModel)
        {
            if (TaskModel == null)
            {
                return BadRequest();
            }

            // Get relations and save to database with creating
            foreach (var worker in TaskModel.Workers) db.WorkerModels.Add(worker);
            db.TaskModels.Add(TaskModel);
            
            
            await db.SaveChangesAsync();
            return Ok(TaskModel);
        }
    }
}
