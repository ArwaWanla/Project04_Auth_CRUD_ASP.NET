#pragma checksum "C:\Users\arwaw\MVC\Project04_Auth_CRUD_ASP.NET\HotelReservationManagement\HotelReservationManagement\Views\Admin\AdminBookingCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b740cc035e217d0b797f0f826f47e838c1a85a79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminBookingCreate), @"mvc.1.0.view", @"/Views/Admin/AdminBookingCreate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\arwaw\MVC\Project04_Auth_CRUD_ASP.NET\HotelReservationManagement\HotelReservationManagement\Views\_ViewImports.cshtml"
using HotelReservationManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arwaw\MVC\Project04_Auth_CRUD_ASP.NET\HotelReservationManagement\HotelReservationManagement\Views\_ViewImports.cshtml"
using HotelReservationManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b740cc035e217d0b797f0f826f47e838c1a85a79", @"/Views/Admin/AdminBookingCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f9526e0bad77879ec0857ff1aa901df08b87c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminBookingCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\arwaw\MVC\Project04_Auth_CRUD_ASP.NET\HotelReservationManagement\HotelReservationManagement\Views\Admin\AdminBookingCreate.cshtml"
   
    var users= (List<AdvanceUser>)ViewData["users"];
    var rooms = (List<RoomModel>)ViewData["rooms"];
   var hotels = (List<HotelModel>) ViewData["hotels"];

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
