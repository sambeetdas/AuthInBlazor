#pragma checksum "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\Pages\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd39532625b20ff13a4b52d69dfe03a7aa318240"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EComm_Blazor.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using EComm_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\_Imports.razor"
using EComm_Blazor.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\Pages\Shared\MainLayout.razor"
using EComm_Blazor.Provider;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Epsilon\POC\MyGITRepository\AuthInBlazor\EComm_Blazor\EComm_Blazor\Pages\Shared\MainLayout.razor"
       

    private async Task Signout()
    {
        await localStorage.RemoveItemAsync("ECOMM_AUTH_COOKIE");
        ((CustomAuthStateProvider)authStateProvider).MarkUserAsUnAuthenticated();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
