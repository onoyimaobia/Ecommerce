#pragma checksum "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf2b3522109e9420b7516b60b85c88f7f8487c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__foodsPartial), @"mvc.1.0.view", @"/Views/Shared/_foodsPartial.cshtml")]
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
#line 1 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\_ViewImports.cshtml"
using Klir.TechChallenge.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\_ViewImports.cshtml"
using Klir.TechChallenge.Web.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2b3522109e9420b7516b60b85c88f7f8487c4f", @"/Views/Shared/_foodsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6cb978f15d4f85f57408d20888194a198b7df4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__foodsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Klir.TechChallenge.SharedLib.Shared.Models.ProductResource>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 7 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
 foreach (var food in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\n            <div class=\"card\">\n");
#nullable restore
#line 11 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                  var item = @food.ImageUrl.Split(".").Last(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                 if (item == "mp4")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <video loop=\"loop\" muted autoplay=\"autoplay\" style=\"width:100%; max-height:100%;\">\n            <source");
            BeginWriteAttribute("src", " src=\"", 522, "\"", 555, 1);
#nullable restore
#line 15 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
WriteAttributeValue("", 528, Url.Content(food.ImageUrl), 528, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"video/mp4\" />\n        </video> ");
#nullable restore
#line 16 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                 }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 663, "\"", 696, 1);
#nullable restore
#line 19 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
WriteAttributeValue("", 669, Url.Content(food.ImageUrl), 669, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" card-img-top img-fluid\" height=\"50\" width=\"100\">");
#nullable restore
#line 19 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-body\" style=\"padding:0\">\n                    <div class=\"col-sm-12\" style=\"padding:0\">\n                        <h6 style=\"text-align:center\">");
#nullable restore
#line 22 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                                                 Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    </div>\n                   \n                    <div class=\"col-sm-12\">\n                        <div class=\"row\">\n                            <div class=\"col-sm-6\" style=\"padding:0\">\n                                <p> Price: ₦");
#nullable restore
#line 28 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                                        Write(string.Format("{0:N}", food.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                            </div>\n                            <div class=\"col-sm-6\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf2b3522109e9420b7516b60b85c88f7f8487c4f8692", async() => {
                WriteLiteral(" Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
                                                                               WriteLiteral(food.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 39 "C:\Users\tooch\source\repos\KlirTechChallenge\KlirTechChallenge\aspnet-core\modules\Klir.TechChallenge.Web\src\Klir.TechChallenge.Web.Mvc\Views\Shared\_foodsPartial.cshtml"
 }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Klir.TechChallenge.SharedLib.Shared.Models.ProductResource>> Html { get; private set; }
    }
}
#pragma warning restore 1591
