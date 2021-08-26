using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
        //OneToMany relation. Represent all workers that attented in task I DON'T KNOW WHY IT'S NOT WORKING
        public ICollection<WorkerModel> Workers { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public List<KeyValuePair<string, List<string>>> Res { get => Calculate(); }
        
        /// <summary>
        /// Calculate
        /// </summary>
        /// <returns></returns>
        private List<KeyValuePair<string, List<string>>> Calculate()
        {
            List<KeyValuePair<string, List<string>>> result = new List<KeyValuePair<string, List<string>>>();
            if (Workers == null) return result;
            if (Images == 0) return result;
            if (Workers.Count < 2) return result;
            
            //list of data
            List<float> images = new List<float>();
            List<float> time = new List<float>();
            // Ratio of Images to sum of images by every worker
            float sigma = 0;
            
            foreach (var w in Workers) images.Add(w.ImgPerMinute);
            //Find how much images workers do by fixed time that we have in task
            for (int i = 0; i < images.Count; i++) images[i]= Images/images[i];

            for (int i = 0; i < images.Count; i++) sigma = sigma + (float)images[i];
            sigma =  Images/sigma;
            foreach (var w in images) time.Add(sigma * w);

            for (int n=0; n < time.Count; n++) time[n] = CustomRound(time[n]);
            
            for (int i = 0; i < images.Count; i++) images[i] = time[i]*Workers.ElementAt(i).ImgPerMinute;
            
            // Filling result
            for (int i = 0; i < time.Count; i++) result.Add(new KeyValuePair<string, List<string>>(
                Workers.ElementAt(i).Name, 
                new List<string>(){
                    time[i].ToString(), (time[i]*Workers.ElementAt(i).ImgPerMinute).ToString() 
                }
                ));
                return result;
        }

        /// <summary>
        /// Custom rounding for saving logic (See README) 
        /// </summary>
        private float CustomRound(float number)
        {
            float rounded = number+1;
            if (number%Math.Floor(number) > 0.6) return (float)Math.Ceiling(number);
            else return (float)Math.Truncate(number);
        }
    }
}