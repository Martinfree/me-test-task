// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace me_task_blazor.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using me_task_blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using me_task_blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
using me_task_blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class TaskCreateForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
       
    int totalTime = 0;
    public List<WorkerModel> workers = new List<WorkerModel>(){
        new WorkerModel{
            Name = "",
            ImgPerMinute = 0
    }};
    public TaskModel NewTask = new TaskModel()
    {
        Images = 0,
        Workers = new List<WorkerModel>().ToArray()
    };

    public bool Answer = false; //If button clicked
    private int count = 1; // workers counter
    private System.Net.HttpStatusCode Response;
    string TaskResult;
    /// <summary>
    /// Initialize Answer section
    /// </summary>
    private void GetAnswer()
    {
        // add workers to task
        var s = Enumerable.Range(0, workers.Count);
        //NewTask.Workers.Clear();

        NewTask.Workers = workers;

        var response = CreateTask();
        Answer = true;

    }

    /// <summary>
    /// Call PostCreateTaskModels and return saved data to NewTask
    /// </summary>
    private async Task<System.Net.HttpStatusCode> CreateTask()
    {

        var response = await (Http.PostAsJsonAsync<TaskModel>("api/TaskModels", NewTask));
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            NewTask = await response.Content.ReadFromJsonAsync<TaskModel>();
            return System.Net.HttpStatusCode.OK;
        }
        else
        {
            return System.Net.HttpStatusCode.NoContent;
        }
    }

    // What do when number of workers changed
    private void onchange_n(ChangeEventArgs e)
    {
        count = 0;
        // Parse value
        if (Int32.TryParse(e.Value.ToString(), out int n))
        {
            count = n;
            // Delete Workers
            workers.Clear();
        }
        else
        {
            count = 0;
        }

        // ReInitialize workers
        for (int i = 0; i < count; i++) workers.Add(new WorkerModel()
        {

            Name = "",
            ImgPerMinute = 0
        });
        StateHasChanged();
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
