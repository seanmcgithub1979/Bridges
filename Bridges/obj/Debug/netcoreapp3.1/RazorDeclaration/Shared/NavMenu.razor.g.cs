#pragma checksum "C:\SeansStuff\Code\Bridges\Bridges\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c929669e8105f184a597f2b0142b313d8317cb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Bridges.Shared
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
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Bridges;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Bridges.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Bridges.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\SeansStuff\Code\Bridges\Bridges\_Imports.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\SeansStuff\Code\Bridges\Bridges\Shared\NavMenu.razor"
 
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
