#pragma checksum "D:\Repos\ToDoApp\ToDoApp\ToDoApp\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f532057dcc8bbf27b3ab2cdbad44cc3c5e1a3d5e"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using ToDoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\_Imports.razor"
using ToDoApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>To-Do</h3>\r\n\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 6 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\Pages\ToDo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddContent(3, 
#nullable restore
#line 8 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\Pages\ToDo.razor"
             todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\Pages\ToDo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Repos\ToDoApp\ToDoApp\ToDoApp\Pages\ToDo.razor"
       

    private List<TodoItem> todos = new();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
