using System;
using System.Collections.Generic;
using System.Text;

namespace me_task_blazor.Shared
{
    public class TaskModel
    {

        public int Id { get; set; }
        public int Images { get; set; }
        //OneToMany relation. Represent all workers that attented in task
        private ICollection<WorkerModel> Workers { get; set; }
        //???
        public DateTime ReleaseDate { get; set; }
        public string Res { get; set; }
   
    }
}
