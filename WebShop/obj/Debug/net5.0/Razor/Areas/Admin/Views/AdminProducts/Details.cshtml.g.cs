#pragma checksum "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe483410d6dc617361f0816c3cbf357be0e97ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Details.cshtml")]
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
#line 1 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe483410d6dc617361f0816c3cbf357be0e97ab6", @"/Areas/Admin/Views/AdminProducts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bfba31bbcaa032efb64f666603006a07f085fa2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminProducts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
   ViewData["Title"] = "Thông tin sản phẩm" + Model.ProductName;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe483410d6dc617361f0816c3cbf357be0e97ab66112", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe483410d6dc617361f0816c3cbf357be0e97ab67815", async() => {
                WriteLiteral("Danh sách sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Thông tin sản phẩm : ");
#nullable restore
#line 11 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                                                 Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </nav>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card-body\">\r\n    <h4 class=\"card-title\">Thông tin sản phẩm : ");
#nullable restore
#line 17 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                           Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"table-responsive\">\r\n        <table class=\"product-info-table m-t-20\">\r\n            <tbody>\r\n                <tr>\r\n                    <td>ID:</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 23 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                                          Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tên sản phẩm:</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Mô tả ngắn:</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Giá:</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Discount:</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Trạng thái:</td>\r\n                    <td>\r\n");
#nullable restore
#line 44 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                         if (Model.Active)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 1882, "\"", 1892, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled/>\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 50 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\" disabled/>\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 57 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Bestseller:</td>\r\n                    <td>");
#nullable restore
#line 62 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                         if (Model.BestSellers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 2670, "\"", 2680, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled/>\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 68 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\" disabled/>\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 75 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>HomeFlag:</td>\r\n                    <td>\r\n");
#nullable restore
#line 81 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                         if (Model.HomeFlag)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 3479, "\"", 3489, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled/>\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 87 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\" disabled/>\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 94 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Danh mục:</td>\r\n                    <td>");
#nullable restore
#line 100 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ngày tạo:</td>\r\n                    <td>");
#nullable restore
#line 104 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ngày chỉnh sửa<td>\r\n                    <td>");
#nullable restore
#line 108 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.DateModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tiêu đề:</td>\r\n                    <td>");
#nullable restore
#line 112 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>MetaDesc:</td>\r\n                    <td>");
#nullable restore
#line 116 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.MetaDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>MetaKey:</td>\r\n                    <td>");
#nullable restore
#line 120 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.MetaKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tags:</td>\r\n                    <td>");
#nullable restore
#line 124 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ảnh đại diện:</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe483410d6dc617361f0816c3cbf357be0e97ab619741", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5072, "~/images/products/", 5072, 18, true);
#nullable restore
#line 129 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 5090, Model.Thumb, 5090, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 129 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 5109, Model.Title, 5109, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Mô tả sản phẩm:</td>\r\n                    <td>");
#nullable restore
#line 134 "D:\EcommerceASP_MVC5\GlocerySHOP\WebShop\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
