#pragma checksum "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\Pages\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85966fa32f560a41708c3beb7c81f782e4edddc6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\kaspe\Source\Repos\kasperhoffmann94\ASPCore.BlazorDemo\BlazorDemo\BlazorDemo\Pages\Calculator.razor"
       
    string num1;
    string num2;
    string finalresult;
    void AddNumbers()
    {
        finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
    }
    void SubtractNumbers()
    {
        finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
    }
    void MultiplyNumbers()
    {
        finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
    }
    void DivideNumbers()
    {
        if (Convert.ToDouble(num2) != 0)
        {
            finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
        }
        else
        {
            finalresult = "Cannot Divide by Zero";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
