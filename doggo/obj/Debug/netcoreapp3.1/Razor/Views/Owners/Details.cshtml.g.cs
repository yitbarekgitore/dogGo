#pragma checksum "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2959ba9669b3e96b6da297592c67a8cc915ec13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_Details), @"mvc.1.0.view", @"/Views/Owners/Details.cshtml")]
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
#line 1 "C:\Users\Owner\workspace\doggo\doggo\Views\_ViewImports.cshtml"
using doggo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\workspace\doggo\doggo\Views\_ViewImports.cshtml"
using doggo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2959ba9669b3e96b6da297592c67a8cc915ec13d", @"/Views/Owners/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb09e8111daf42d4e6a5599e0cf413235c5f983", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<doggo.Models.ViewModels.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
   ViewData["Title"] = "Profile"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1 class=\"mb-4\">");
#nullable restore
#line 5 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                Write(Model.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <section class=""container"">
        <img style=""width:100px;float:left;margin-right:20px""
             src=""https://upload.wikimedia.org/wikipedia/commons/a/a0/Font_Awesome_5_regular_user-circle.svg"" />
        <div>
            <label class=""font-weight-bold"">Address:</label>
            <span>");
#nullable restore
#line 12 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
             Write(Model.Owner.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label class=\"font-weight-bold\">Phone:</label>\r\n            <span>");
#nullable restore
#line 16 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
             Write(Model.Owner.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label class=\"font-weight-bold\">Email:</label>\r\n            <span>");
#nullable restore
#line 20 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
             Write(Model.Owner.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </section>\r\n\r\n    <hr class=\"mt-5\" />\r\n    <div class=\"clearfix\"></div>\r\n\r\n    <div class=\"row\">\r\n        <section class=\"col-8 container mt-5\">\r\n            <h1 class=\"text-left\">Dogs</h1>\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 32 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                 foreach (Dog dog in Model.Dogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card m-4\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 35 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                         if (String.IsNullOrEmpty(dog.ImageUrl))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"https://cdn.pixabay.com/photo/2018/08/15/13/12/dog-3608037_960_720.jpg\"\r\n                                 class=\"card-img-top\"\r\n                                 alt=\"Doggo\" />\r\n");
#nullable restore
#line 40 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 1551, "\"", 1570, 1);
#nullable restore
#line 43 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
WriteAttributeValue("", 1557, dog.ImageUrl, 1557, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Doggo\" />\r\n");
#nullable restore
#line 44 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body\">\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Name:</label>\r\n                                <span>");
#nullable restore
#line 48 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                                 Write(dog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Breed:</label>\r\n                                <span>");
#nullable restore
#line 52 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                                 Write(dog.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Notes:</label>\r\n                                <p>");
#nullable restore
#line 56 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                              Write(dog.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n\r\n        <section class=\"col-lg-4 col-md-8 container mt-5\">\r\n            <h1>Walkers Near Me</h1>\r\n\r\n            <ul class=\"list-group mt-4\">\r\n");
#nullable restore
#line 68 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                 foreach (Walker walker in Model.Walkers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item disabled\" aria-disabled=\"true\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2750, "\"", 2772, 1);
#nullable restore
#line 71 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
WriteAttributeValue("", 2756, walker.ImageUrl, 2756, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px\" />\r\n                        <span class=\"font-weight-bold ml-4\">");
#nullable restore
#line 72 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                                                       Write(walker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </li>\r\n");
#nullable restore
#line 74 "C:\Users\Owner\workspace\doggo\doggo\Views\Owners\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </section>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<doggo.Models.ViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
