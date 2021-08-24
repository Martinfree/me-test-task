using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using me_task_blazor.Shared;

namespace me_task_blazor.Shared
{
    public class TaskModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int Images { get; set; }
        //OneToMany relation. Represent all workers that attented in task
        public ICollection<WorkerModel> Workers { get; set; }
        //???
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public string Res { get; set; }

    }
}