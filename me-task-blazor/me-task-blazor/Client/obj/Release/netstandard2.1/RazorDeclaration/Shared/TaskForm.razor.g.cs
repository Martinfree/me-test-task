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
#line 1 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using me_task_blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using me_task_blazor.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class TaskForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\lvarc\source\repos\me-task-blazor\me-task-blazor\Client\Shared\TaskForm.razor"
       
    private double counter = 2;

    private string Rows = "<tr>" +
            "<th scope= \"row\"> 1 </th>" +
            "<td><input type = \"text\" class=\"form-control\" id=\"name\"></td>" +
            "<td><input type = \"number\" class=\"form-control\" id=\"speed\"></td></tr>";

    private void AddWorker()
    {
        Rows += "<tr>" +
            "<th scope= \"row\">" + counter++.ToString() + "</th>" +
            "<td><input type = \"text\" class=\"form-control\" id=\"name\"></td>" +
            "<td><input type = \"number\" class=\"form-control\" id=\"speed\"></td></tr>";
    }
   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
