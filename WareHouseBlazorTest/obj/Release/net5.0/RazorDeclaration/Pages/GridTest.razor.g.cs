// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WareHouseBlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using WareHouseBlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using WareHouseBlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using WareHouseBlazorTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\_Imports.razor"
using WareHouseBlazorTest.Mocks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Gridtest")]
    public partial class GridTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Gsu\source\repos\WareHouseBlazorTest\WareHouseBlazorTest\Pages\GridTest.razor"
       

    private Section curSection;

    private string currentCargoDescription;

    private void Refresh()
    {
        InvokeAsync(() => this.StateHasChanged());
    }







    protected override void OnInitialized()
    {
        curSection = singleton.Section;
        currentCargoDescription = string.Empty;

        singleton.ChangeSectionsValuesEvent += Refresh;
    }

   


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SectionMockSingleton singleton { get; set; }
    }
}
#pragma warning restore 1591
