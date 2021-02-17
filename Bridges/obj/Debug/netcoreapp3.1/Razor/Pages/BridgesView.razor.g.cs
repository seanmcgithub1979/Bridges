#pragma checksum "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f72538b452b3e19d23a8421385935f6a612740"
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
#line 3 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
using Bridges.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bridgesview/{colcount:int}")]
    public partial class BridgesView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\r\n        \r\n");
#nullable restore
#line 8 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
         if (Colcount != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
             foreach (var bridge in new BridgesService().GetBridges)
            {
                var x = (i) % Colcount;


#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "                ");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", "bridgesdetailview/" + (
#nullable restore
#line 15 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
                                                bridge.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n                        ");
            __builder.OpenElement(11, "h6");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
                             bridge.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "alt", "No" + " image" + " found" + " for" + " bridge" + " with" + " name:" + " " + (
#nullable restore
#line 17 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
                                                                        bridge.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "title", 
#nullable restore
#line 17 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
                                                                                             bridge.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "height", "200");
            __builder.AddAttribute(18, "width", "200");
            __builder.AddAttribute(19, "src", "Images/Thumbs/" + (
#nullable restore
#line 17 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
                                                                                                                                                              bridge.Filename

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 20 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"

                if (x == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "                    </tr>\r\n                    <tr>\r\n");
#nullable restore
#line 25 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
                }

                i++;

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\SeansStuff\Code\Bridges\Bridges\Pages\BridgesView.razor"
 
    int i = 1;

    [Parameter]
    public int Colcount { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
