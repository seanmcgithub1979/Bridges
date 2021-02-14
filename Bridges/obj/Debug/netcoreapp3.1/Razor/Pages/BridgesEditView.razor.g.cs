#pragma checksum "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f463b3155acf01337fe3bb8d58eff3411e99108"
// <auto-generated/>
#pragma warning disable 1591
namespace Bridges.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Bridges;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Bridges.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Bridges.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
using Bridges.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bridgeseditview")]
    public partial class BridgesEditView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<form method=\"post\">\r\n    <h3>Edit bridges</h3>\r\n</form>\r\n\r\n");
            __builder.OpenElement(1, "body");
            __builder.AddAttribute(2, "style", "opacity: 0.7");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", ".table .thead-dark");
            __builder.AddAttribute(6, "style", "background-color: lightgoldenrodyellow; color: darkslategray; width: 100%");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, @"<thead style=""background-color: darkslategray; color: white"" ;>
        <th><h5>Name</h5></th>
        <th><h5>Description</h5></th>
        <th><h5>Filename</h5></th>
        <th><h5>Lng</h5></th>
        <th><h5>Lat</h5></th>
        <th><h5>Zoom</h5></th>
    <th><h5>Height</h5></th>
    </thead>

");
#nullable restore
#line 22 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
      
        foreach (var bridge in new BridgesService().GetBridges)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 26 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Filename

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 29 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Lng

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 30 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Lat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 31 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Zoom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 32 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
                     bridge.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesEditView.razor"
        }
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
