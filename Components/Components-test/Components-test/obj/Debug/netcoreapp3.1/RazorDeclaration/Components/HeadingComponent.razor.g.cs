// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Components_test.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Components_test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Components_test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\_Imports.razor"
using Components_test.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\Components\HeadingComponent.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class HeadingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\emanu\Source\Repos\MaCoEv\emanuele.bambini-Blazor\Components\Components-test\Components-test\Components\HeadingComponent.razor"
      
    private static TextInfo _tinfo = CultureInfo.CurrentCulture.TextInfo;
    private static _headingText =
    _tinfo.ToTitleCase("welcome to blazor!");
private string _headingFontStyle = "normal";
    private bool _italicsCheck = false;

    //When UpdateHeading is executed, _italicsCheck determines
    //the value of _headingFontStyle to set the font style of the heading.
    public void UpdateHeading()
    {
        _headingFontStyle = _italicsCheck ? "italic" : "normal";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591