#pragma checksum "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb093c780d01b6fcc4751cf7e4d3905e54475e9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\_ViewImports.cshtml"
using eTicketMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\_ViewImports.cshtml"
using eTicketMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb093c780d01b6fcc4751cf7e4d3905e54475e9f", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f133b7dcc0db6c0f7e3491c868e2907809f6af3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
   
    ViewData["Title"] = "List of Movies";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3"">
            <div class=""card mb-3"" style=""max-width:540px"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    ");
#nullable restore
#line 18 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                               Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <a class=""text-white float-right""><i class=""bi bi-pencil-square""></i></a> 
                                </h5>
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 895, "\"", 916, 1);
#nullable restore
#line 25 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
WriteAttributeValue("", 901, movie.ImageURL, 901, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 930, "\"", 947, 1);
#nullable restore
#line 25 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
WriteAttributeValue("", 936, movie.Name, 936, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                            Write(movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 30 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                                           Write(movie.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 31 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                                             Write(movie.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>StartDate: </b>");
#nullable restore
#line 32 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                                              Write(movie.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>EndDate: </b>");
#nullable restore
#line 33 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                                            Write(movie.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">\r\n                                <b>Status: </b>\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                 if (DateTime.Now >= movie.StartDate && DateTime.Now <= movie.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-success text-white\">AVAILABLE</span>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                }
                                else if(DateTime.Now > movie.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-danger text-white\">EXPIRED</span>\r\n");
#nullable restore
#line 43 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-primary text-white\">UPCOMING</span>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </p>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer"">
                            <p class=""card-text"">
                                <a class=""btn btn-outline-primary float-right""><i class=""bi bi-eye-fill""></i>Show Details</a>
                                <a class=""btn btn-success text-white""><i class=""bi bi-cart-plus""></i>Add To Cart (Price ");
#nullable restore
#line 55 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"
                                                                                                                   Write(movie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Movies\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591