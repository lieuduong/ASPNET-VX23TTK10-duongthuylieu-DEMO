#pragma checksum "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_cart), @"mvc.1.0.view", @"/Views/Home/cart.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\_ViewImports.cshtml"
using WebApp

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd", @"/Views/Home/cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"31be4b5165da690ea111e4aefa9807cce9d816105571398c3731040d6b1195b1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
       List<CartItem>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:80px;width:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "removecart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_homePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n");
#nullable restore
#line 6 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"

<div id=""wallpaper"">
    <header>
        <div class=""top"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-12 col-md-6 col-lg-6"">
                        <p>Chào mừng đến với shop bán hàng!</p>
                    </div>
                    <div class=""col-xs-12 col-sm-12 col-md-6 col-lg-6"">
                        <div class=""top-menu"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd8440", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                        </div>
                    </div>
                </div>
            </div>
        </div>




        <div class=""main-header"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6 col-xs-6 col-sm-6 col-md-3 col-lg-3 order-md-0 order-0"">
                        <div class=""logo"">
                            <a href=""/""><img src=""images/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 1015, "\"", 1021, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                            <h1>Website bán hàng</h1>
                        </div>
                    </div>
                    <div class=""col-12 col-xs-12 col-sm-12 col-md-6 col-lg-6 order-md-1 order-2"">
                    </div>
                    <div class=""col-6 col-xs-6 col-sm-6 col-md-3 col-lg-3 order-md-2 order-1"" style=""text-align: right"">

                    </div>
                </div>
            </div>
        </div>
    </header>
    <div id=""content"">
        <div class=""container"">
            <div class=""slider"">
                <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img class=""d-block w-100"" src=""images/banner1.jpg"" alt=""First slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block w-100"" src=""images/banner2.jpg"" alt=""Sec");
            WriteLiteral(@"ond slide"">
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>
        <div class=""product-box"">
            <div class=""container"">
                <h2>GIỎ HÀNG</h2>
");
#nullable restore
#line 79 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                 if (Model.Count > 0)
                {
                    decimal total = 0;
                    int stt = 1;


#line default
#line hidden
#nullable disable

            WriteLiteral(@"                    <table class=""table"">
                        <tr>
                            <th>#</th>
                            <th>Sản phẩm</th>
                            <th>Hình </th>
                            <th>Giá</th>
                            <th>Số lượng</th>
                            <th>Thành tiền</th>
                            <th></th>
                        </tr>
");
#nullable restore
#line 94 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                         foreach (var cartitem in Model)
                        {
                            var thanhtien = cartitem.quantity * cartitem.product.Gia;
                            total += thanhtien;


#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\n                                <td>");
            Write(
#nullable restore
#line 100 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                      stt++

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                                <td>");
            Write(
#nullable restore
#line 101 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                     cartitem.product.TenSP

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd13909", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3810, "~/img/pro/", 3810, 10, true);
            AddHtmlAttributeValue("", 3820, 
#nullable restore
#line 102 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                                         cartitem.product.Hinh

#line default
#line hidden
#nullable disable
            , 3820, 22, false);
            AddHtmlAttributeValue("", 3842, "?", 3842, 1, true);
            AddHtmlAttributeValue("", 3843, 
#nullable restore
#line 102 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                                                                ViewData["rand"]

#line default
#line hidden
#nullable disable
            , 3843, 17, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                                <td>");
            Write(
#nullable restore
#line 104 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                      cartitem.product.Gia.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd16428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => 
#nullable restore
#line 105 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                                     cartitem.quantity

#line default
#line hidden
#nullable disable
            );
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4102, 
#nullable restore
#line 105 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                                                              $"quantity-{cartitem.product.Ma}"

#line default
#line hidden
#nullable disable
            , 4102, 36, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                                <td>");
            Write(
#nullable restore
#line 106 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                      thanhtien.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                                <td>\n                                    <button class=\"btn btn-success updatecartitem\" data-productid=\"");
            Write(
#nullable restore
#line 108 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                                                                                    cartitem.product.Ma

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\"\n                                        name=\"item\">\n                                        Cập nhật\n                                    </button>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd19520", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 112 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                                                                    cartitem.product.Ma

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n                            </tr>\n");
#nullable restore
#line 116 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <tr>\n                            <td colspan=\"4\" class=\"text-right\">Tổng tiền</td>\n                            <td>");
            Write(
#nullable restore
#line 119 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                  total.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                            <td></td>\n                        </tr>\n                    </table>\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd22726", async() => {
                WriteLiteral("Gửi đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd24013", async() => {
                WriteLiteral("Tiếp tục mua hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 126 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"


                }
                else
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <p class=\"alert alert-danger\">Giỏ hàng trống</p>\n");
#nullable restore
#line 132 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
            </div>
        </div>
    </div>
    <br>
    <br>
    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                    <div class=""box-footer info-contact"">
                        <h3>Thông tin liên hệ</h3>
                        <div class=""content-contact"">
                            <p>Website chuyên cung cấp các loại Laptop </p>
                            <p>
                                <strong>Địa chỉ:</strong>331, Hòa Hưng, An Giang
                            </p>
                            <p>
                                <strong>Email: </strong> lieudt090890@sv-onuni.edu.vn
                            </p>
                            <p>
                                <strong>Điện thoại: </strong> 0919276162
                            </p>

                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-sm-12 col-md-4 col-");
            WriteLiteral(@"lg-4"">
                    <div class=""box-footer info-contact"">
                        <h3>Thông tin khác</h3>
                        <div class=""content-list"">
                            <ul>
                                <li><a href=""#""><i class=""fa fa-angle-double-right""></i> Chính sách bảo mật</a></li>
                                <li><a href=""#""><i class=""fa fa-angle-double-right""></i> Chính sách đổi trả</a></li>
                                <li><a href=""#""><i class=""fa fa-angle-double-right""></i> Phí vận chuyển</a></li>
                                <li><a href=""#""><i class=""fa fa-angle-double-right""></i> Hướng dẫn thanh toán</a></li>
                                <li><a href=""#""><i class=""fa fa-angle-double-right""></i> Chương trình khuyến mãi</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                    <di");
            WriteLiteral("v class=\"box-footer info-contact\">\n                        <h3>Form liên hệ</h3>\n                        <div class=\"content-contact\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd58b5aa81ae10bcb383080785505900ea1c40f164d066915c72681e7e113bd28116", async() => {
                WriteLiteral("\n                                <div class=\"row\">\n                                    <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\n                                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 7842, "\"", 7849, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 7850, "\"", 7855, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"Họ và Tên\">\n                                    </div>\n                                    <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-6\">\n                                        <input type=\"email\"");
                BeginWriteAttribute("name", " name=\"", 8094, "\"", 8101, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8102, "\"", 8107, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control""
                                            placeholder=""Địa chỉ mail"">
                                    </div>
                                    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-6"">
                                        <input type=""text""");
                BeginWriteAttribute("name", " name=\"", 8392, "\"", 8399, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8400, "\"", 8405, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control""
                                            placeholder=""Số điện thoại"">
                                    </div>
                                    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                        <input type=""text""");
                BeginWriteAttribute("name", " name=\"", 8692, "\"", 8699, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8700, "\"", 8705, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"Tiêu đề\">\n                                    </div>\n                                    <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\n                                        <textarea");
                BeginWriteAttribute("name", " name=\"", 8933, "\"", 8940, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8941, "\"", 8946, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""10"" class=""form-control""></textarea>
                                    </div>
                                </div>
                                <button type=""submit"" class=""btn-contact"">Liên hệ ngay</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""copyright"">
            <p>Copyright © 2025 DTLSHOP All Rights Reserved - Design by DTL</p>
        </div>
    </footer>
</div>
<script src=""libs/jquery-3.4.1.min.js""></script>
<script src=""libs/bootstrap/js/bootstrap.min.js""></script>
<script src=""js/main.js""></script>
<div id=""fb-root""></div>
<script async defer crossorigin=""anonymous""
    src=""https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v6.0""></script>











<!--Section: Block Content-->
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>

        $('button[name=item]').click(function () {


            var productid = $(this).attr(""data-productid"");
            var quantity = $(""#quantity-"" + productid).val();
            $.ajax({
                method: ""POST"",
                url: """);
                Write(
#nullable restore
#line 240 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                       Url.RouteUrl("updatecart")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\",\n                data: {\n                    productid: productid,\n                    quantity: quantity\n                },\n                success: function (result) {\n                    window.location.href = \"");
                Write(
#nullable restore
#line 246 "C:\Users\doanh\Downloads\ban-laptop\WebApp\Views\Home\cart.cshtml"
                                             Url.RouteUrl("cart")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\";\n                }\n            });\n        });\n\n    </script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
