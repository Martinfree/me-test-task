#pragma checksum "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "446111d90ecff65d007a63f8dae4722e73a8acd2"
// <auto-generated/>
#pragma warning disable 1591
namespace me_task_blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using me_task_blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lvarc\source\repos\me-test-task\me-task-blazor\me-task-blazor\Client\_Imports.razor"
using me_task_blazor.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Test task</h1>\r\n\r\nWelcome to my blazor app.\r\n\r\n");
            __builder.OpenComponent<me_task_blazor.Client.Shared.TaskDescription>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<me_task_blazor.Client.Shared.TaskCreateForm>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<me_task_blazor.Client.Shared.Explainings>(5);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591