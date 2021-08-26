#pragma checksum "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f129aaf89fc354327701a772d15a85714a67c0a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Try to find answer</h3>\r\n");
            __builder.OpenElement(1, "td");
            __builder.AddMarkupContent(2, "\r\n    Number of Images to edit:\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "min", "1");
            __builder.AddAttribute(6, "max", "100");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                   NewTask.Images

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewTask.Images = __value, NewTask.Images, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\nNumber of workers:\r\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 12 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
               count

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "min", "1");
            __builder.AddAttribute(17, "max", "100");
            __builder.AddAttribute(18, "step", "1");
            __builder.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                                                                              onchange_n

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<br>\r\n\r\n\r\n");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.AddMarkupContent(24, "<thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Person</th>\r\n            <th scope=\"col\">Speed (img/min)</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 25 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
         foreach (var i in Enumerable.Range(0, workers.Count))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "            ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "th");
            __builder.AddAttribute(31, "scope", "row");
            __builder.AddContent(32, " ");
            __builder.AddContent(33, 
#nullable restore
#line 28 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                  i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "value", 
#nullable restore
#line 30 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                   workers[@i].Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "placeholder", "Person Name");
            __builder.AddAttribute(41, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                                                                           (ChangeEventArgs e) => @workers[@i].Name = e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "value", 
#nullable restore
#line 33 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                   workers[@i].ImgPerMinute

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "min", "1");
            __builder.AddAttribute(51, "max", "100");
            __builder.AddAttribute(52, "step", "1");
            __builder.AddAttribute(53, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                                                                                    (ChangeEventArgs e) => @workers[@i].ImgPerMinute = Convert.ToInt32(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "type", "number");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 37 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenElement(62, "div");
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-primary");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                                            GetAnswer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(68, "Answer");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n");
#nullable restore
#line 48 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
 if (Answer)
{
        var sum = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
         foreach (var model in NewTask.Res) sum = sum + Convert.ToInt32(model.Value.ElementAt(1));

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "    ");
            __builder.OpenElement(72, "div");
            __builder.AddMarkupContent(73, "\r\n        <br>A job of ");
            __builder.AddContent(74, 
#nullable restore
#line 54 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                      NewTask.Images

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(75, " images is going to be edited by a crew of people:<br>\r\n        Every person have speed property:\r\n");
#nullable restore
#line 56 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
         foreach (var w in NewTask.Workers)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "            ");
            __builder.OpenElement(77, "p");
            __builder.AddContent(78, 
#nullable restore
#line 58 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                w.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, " - ");
            __builder.AddContent(80, 
#nullable restore
#line 58 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                          w.ImgPerMinute

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(81, " img/min ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "<br>\r\n");
#nullable restore
#line 59 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(83, "        Answer:<br>\r\n        1.How long will this job take in total ?<br>\r\n        -Total time: ");
            __builder.AddContent(84, 
#nullable restore
#line 62 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                      sum

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, " <br>\r\n\r\n        2.How many images will be edited by every person?<br>\r\n");
#nullable restore
#line 65 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
         foreach (var w in NewTask.Res)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "            ");
            __builder.OpenElement(87, "p");
            __builder.AddContent(88, "-Worker ");
            __builder.AddContent(89, 
#nullable restore
#line 67 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                        w.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " edit ");
            __builder.AddContent(91, 
#nullable restore
#line 67 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                    w.Value.ElementAt(0)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "<br>\r\n");
#nullable restore
#line 68 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(93, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 72 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
}
else if (Answer && Response != System.Net.HttpStatusCode.OK)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "    ");
            __builder.OpenElement(96, "div");
            __builder.AddMarkupContent(97, "\r\n        <br>Error:<br>\r\n\r\n        StatusCode: ");
            __builder.AddContent(98, 
#nullable restore
#line 78 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                     Response

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(99, "<br>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 81 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
       
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
        TaskModel model = new TaskModel()
        {
            Images = NewTask.Images
        };
        // add workers to task
        var s = Enumerable.Range(0, workers.Count);
        //NewTask.Workers.Clear();
        model.Workers = workers;

        var response = CreateTask(model);
        Answer = true;

    }

    /// <summary>
    /// Call PostCreateTaskModels and return saved data to NewTask
    /// </summary>
    private async Task<System.Net.HttpStatusCode> CreateTask(TaskModel model)
    {

        var response = await (Http.PostAsJsonAsync<TaskModel>("api/TaskModels", model));
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
