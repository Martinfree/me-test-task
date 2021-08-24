using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using me_task_blazor.Server.Models;
using me_task_blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace me_task_blazor.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class WorkerModelsController : ControllerBase
    {
        DataContext db;

        public WorkerModelsController(DataContext context)
        {
            db = context;
            if (!db.WorkerModels.Any())
            {
                db.WorkerModels.Add(new WorkerModel { });
                db.WorkerModels.Add(new WorkerModel { });
                db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<WorkerModel>> Get()
        {
            return await db.WorkerModels.ToListAsync();
        }

        // GET api/WorkerModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkerModel>> Get(int id)
        {
            WorkerModel WorkerModel = await db.WorkerModels.FirstOrDefaultAsync(x => x.Id == id);
            if (WorkerModel == null)
                return NotFound();
            return new ObjectResult(WorkerModel);
        }

        [HttpPost]
        public async Task<ActionResult<WorkerModel>> Post(TaskModel TaskModel)
        {
            if (TaskModel == null)
            {
                return BadRequest();
            }

            // Get relations and save to database with creating
            db.TaskModels.Add(TaskModel);
            
            
            await db.SaveChangesAsync();
            return Ok(TaskModel);
        }

    }

}

