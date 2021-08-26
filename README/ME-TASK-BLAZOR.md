# Blazor App
[#Code](me-task-blazor/)

Blazor app created for test task. For resolve all score in project used BlazorWebAssembly project with N-Tier architecture implementation.<br>

![alt text](https://christofsenn.gallerycdn.vsassets.io/extensions/christofsenn/n-tierentityframeworkvs2015/1.9/1482142300425/96004/1/context.png)

# me-task-blazor.Client
Blazor.Client prodeces presentation layer of app architecture. Еhe main task of the Сlient is to render the data that he receives from the server.


# me-task-blazor.Server
With the Blazor Server hosting model, the app is executed on the server from within an ASP.NET Core app.
In this project server use EntityFramework to produce dbContext. EntityFramework create connection with setup database and works like database middleware.

All requests to models are implemented through api requests. Api have [swagger documentation](docs/api-doc.json).

# me-task-blazor.Shared

Shared solution contains ~~models~~ classes that in blazor app represents description of table values ​​in the database.
This project have 2 models:

- [TaskModel]()
```cs
  public class TaskModel
      {
        public int Id { get; set; }
        public int Images { get; set; }
        public ICollection<WorkerModel> Workers { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public List<KeyValuePair<string, List<string>>> Res { get => Calculate(); }
      }
```

- [WorkerModel]()
```cs
public class WorkerModel
{
        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ImgPerMinute { get; set; }

        [Required]
        public TaskModel TaskModel;
}
```



# Testing project

For Testing uses separate from 2 others solution code [Tests](). For now tests contains
dbContext logic and API validation. The api is represented as TaskModelController.
