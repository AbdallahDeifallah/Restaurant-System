#pragma checksum "E:\Asp.Net Core Mvc\System-Res\SystemRestaurant\Restaurant\Areas\Admin\Views\Shared\Components\MasterMenuComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efdc159a8dce7547619855d193d65a7450e24685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_MasterMenuComponent_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/MasterMenuComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efdc159a8dce7547619855d193d65a7450e24685", @"/Areas/Admin/Views/Shared/Components/MasterMenuComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d286704faafb66f6c362a6279f19f91eff5f", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_MasterMenuComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/assets/img/messages-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/assets/img/messages-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/assets/img/messages-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""header-nav ms-auto"">
    <ul class=""d-flex align-items-center"">

        <li class=""nav-item d-block d-lg-none"">
            <a class=""nav-link nav-icon search-bar-toggle "" href=""#"">
                <i class=""bi bi-search""></i>
            </a>
        </li><!-- End Search Icon-->

        <li class=""nav-item dropdown"">

            <a class=""nav-link nav-icon"" href=""#"" data-bs-toggle=""dropdown"">
                <i class=""bi bi-bell""></i>
                <span class=""badge bg-primary badge-number"">4</span>
            </a><!-- End Notification Icon -->

            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow notifications"">
                <li class=""dropdown-header"">
                    You have 4 new notifications
                    <a href=""#""><span class=""badge rounded-pill bg-primary p-2 ms-2"">View all</span></a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li c");
            WriteLiteral(@"lass=""notification-item"">
                    <i class=""bi bi-exclamation-circle text-warning""></i>
                    <div>
                        <h4>Lorem Ipsum</h4>
                        <p>Quae dolorem earum veritatis oditseno</p>
                        <p>30 min. ago</p>
                    </div>
                </li>

                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""notification-item"">
                    <i class=""bi bi-x-circle text-danger""></i>
                    <div>
                        <h4>Atque rerum nesciunt</h4>
                        <p>Quae dolorem earum veritatis oditseno</p>
                        <p>1 hr. ago</p>
                    </div>
                </li>

                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""notification-item"">
                    <i class=""bi bi-check-circle text-success""></i>
          ");
            WriteLiteral(@"          <div>
                        <h4>Sit rerum fuga</h4>
                        <p>Quae dolorem earum veritatis oditseno</p>
                        <p>2 hrs. ago</p>
                    </div>
                </li>

                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""notification-item"">
                    <i class=""bi bi-info-circle text-primary""></i>
                    <div>
                        <h4>Dicta reprehenderit</h4>
                        <p>Quae dolorem earum veritatis oditseno</p>
                        <p>4 hrs. ago</p>
                    </div>
                </li>

                <li>
                    <hr class=""dropdown-divider"">
                </li>
                <li class=""dropdown-footer"">
                    <a href=""#"">Show all notifications</a>
                </li>

            </ul><!-- End Notification Dropdown Items -->

        </li><!-- End Notification Nav -->");
            WriteLiteral(@"

        <li class=""nav-item dropdown"">

            <a class=""nav-link nav-icon"" href=""#"" data-bs-toggle=""dropdown"">
                <i class=""bi bi-chat-left-text""></i>
                <span class=""badge bg-success badge-number"">3</span>
            </a><!-- End Messages Icon -->

            <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow messages"">
                <li class=""dropdown-header"">
                    You have 3 new messages
                    <a href=""#""><span class=""badge rounded-pill bg-primary p-2 ms-2"">View all</span></a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""message-item"">
                    <a href=""#"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efdc159a8dce7547619855d193d65a7450e246859910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div>
                            <h4>Maria Hudson</h4>
                            <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                            <p>4 hrs. ago</p>
                        </div>
                    </a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""message-item"">
                    <a href=""#"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efdc159a8dce7547619855d193d65a7450e2468511629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div>
                            <h4>Anna Nelson</h4>
                            <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                            <p>6 hrs. ago</p>
                        </div>
                    </a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""message-item"">
                    <a href=""#"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efdc159a8dce7547619855d193d65a7450e2468513348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div>
                            <h4>David Muldon</h4>
                            <p>Velit asperiores et ducimus soluta repudiandae labore officia est ut...</p>
                            <p>8 hrs. ago</p>
                        </div>
                    </a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li class=""dropdown-footer"">
                    <a href=""#"">Show all messages</a>
                </li>

            </ul><!-- End Messages Dropdown Items -->

        </li><!-- End Messages Nav -->

        <li class=""nav-item dropdown pe-3"">
");
            WriteLiteral("            <a class=\"nav-link nav-profile d-flex align-items-center pe-0\" href=\"#\" data-bs-toggle=\"dropdown\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efdc159a8dce7547619855d193d65a7450e2468515406", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5996, "~/User_img/", 5996, 11, true);
#nullable restore
#line 154 "E:\Asp.Net Core Mvc\System-Res\SystemRestaurant\Restaurant\Areas\Admin\Views\Shared\Components\MasterMenuComponent\Default.cshtml"
AddHtmlAttributeValue("", 6007, Model.user_image, 6007, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"d-none d-md-block dropdown-toggle ps-2\">\r\n\r\n                    ");
#nullable restore
#line 157 "E:\Asp.Net Core Mvc\System-Res\SystemRestaurant\Restaurant\Areas\Admin\Views\Shared\Components\MasterMenuComponent\Default.cshtml"
               Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </a><!-- End Profile Iamge Icon -->\r\n\r\n            <ul class=\"dropdown-menu dropdown-menu-end dropdown-menu-arrow profile\">\r\n                <li class=\"dropdown-header\">\r\n                    <h6>");
#nullable restore
#line 163 "E:\Asp.Net Core Mvc\System-Res\SystemRestaurant\Restaurant\Areas\Admin\Views\Shared\Components\MasterMenuComponent\Default.cshtml"
                   Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <span>Web Designer</span>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li>
                    <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                        <i class=""bi bi-person""></i>
                        <span>My Profile</span>
                    </a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li>
                    <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                        <i class=""bi bi-gear""></i>
                        <span>Account Settings</span>
                    </a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li>
                    <a class=""dropdown-item d-flex align-items-center"" href=""page");
            WriteLiteral(@"s-faq.html"">
                        <i class=""bi bi-question-circle""></i>
                        <span>Need Help?</span>
                    </a>
                </li>
                <li>
                    <hr class=""dropdown-divider"">
                </li>

                <li>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efdc159a8dce7547619855d193d65a7450e2468519425", async() => {
                WriteLiteral("\r\n                        <i class=\"bi bi-box-arrow-right\"></i>\r\n                        <span>Sign Out</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n\r\n            </ul><!-- End Profile Dropdown Items -->\r\n        </li><!-- End Profile Nav -->\r\n\r\n    </ul>\r\n</nav><!-- End Icons Navigation -->\r\n");
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
