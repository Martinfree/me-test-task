#pragma checksum "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644c5779d7cb3ce728f0dba2db246c56b9e90a87"
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
#line 2 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using System.Net.Http.Json;

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
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                   NewTask.Images

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewTask.Images = __value, NewTask.Images));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Person</th>\r\n            <th scope=\"col\">Speed (img/min)</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
          (MarkupString)Rows

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                                        AddWorker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "+ Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                                                            Get

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Answer");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddMarkupContent(36, "\r\n    <br>A job of ");
            __builder.AddContent(37, 
#nullable restore
#line 30 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
                  NewTask.Images

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, @" images is going to be edited by a crew of people:<br>

    Every person have speed property v img/min(Worker list)<br>

    Answer:<br>
    1. How long will this job take in total?<br>
    - Total time

    2. How many images will be edited by every person?<br>
    - Worker (name) edit (number of images)

");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\work\me-test-task\me-task-blazor\me-task-blazor\Client\Shared\TaskCreateForm.razor"
       
    public TaskModel NewTask = new TaskModel();
    public WorkerModel[] workers;

    public double counter = 2;
    public bool Answer = false;

    private void Get()
    {
        Answer = !Answer;
        
}

    private string Rows = "<tr>" +
        "<th scope= \"row\"> 1 </th>" +
        "<td><input @bind=\"NewTask\" type = \"text\" class=\"form-control\" id=\"name\"></td>" +
        "<td><input type = \"number\" class=\"form-control\" id=\"speed\"></td></tr>";

    private void AddWorker()
    {
        Rows += "<tr>" +
            "<th scope= \"row\">" + counter++.ToString() + "</th>" +
            "<td><input @bind=\"NewTask.Name\" type = \"text\" class=\"form-control\" id=\"name\"></td>" +
            "<td><input type = \"number\" class=\"form-control\" id=\"speed\"></td></tr>";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
