#pragma checksum "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8c066f53504161322f9380fe62eb05a5075332"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to the adult database manager!</h1>\r\n\r\nHere you can manage adults.\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "hidden", 
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Index.razor"
              hideLogin

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "login-div");
            __builder.AddMarkupContent(4, "\r\n    To do this, you must be logged in.\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(5, "<a href=\"login\">\r\n        Login \r\n    </a>\r\n    or\r\n    ");
            __builder.AddMarkupContent(6, "<a href=\"register\">\r\n        register\r\n    </a>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Index.razor"
       
    private bool hideLogin = true;

    protected override async Task OnInitializedAsync()
    {
        Start();
    }
    
    public void Start()
    {
        Console.WriteLine("TheUser: " + TheUser.userName);

        if (TheUser.userName == null)
        {
            Console.WriteLine("User is not logged in!");

            hideLogin = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private User TheUser { get; set; }
    }
}
#pragma warning restore 1591
