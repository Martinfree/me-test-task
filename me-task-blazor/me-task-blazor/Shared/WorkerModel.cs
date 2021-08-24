using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace me_task_blazor.Shared
{
    public class WorkerModel
    {
        [Required]
        [Key]
        public int Id { get; set; } //???
        public string Name { get; set; }
        public int ImgPerMinute { get; set; }

        [Required]
        public TaskModel TaskModel;
    }
}
