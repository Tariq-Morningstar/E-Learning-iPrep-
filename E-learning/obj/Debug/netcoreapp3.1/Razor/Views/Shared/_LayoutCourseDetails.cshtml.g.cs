#pragma checksum "E:\Internship final project\E-learning\E-learning\E-learning\Views\Shared\_LayoutCourseDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fab69d938ed8ceabe5bf7a67c02255bd0bc1cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutCourseDetails), @"mvc.1.0.view", @"/Views/Shared/_LayoutCourseDetails.cshtml")]
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
#line 1 "E:\Internship final project\E-learning\E-learning\E-learning\Views\_ViewImports.cshtml"
using E_learning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Internship final project\E-learning\E-learning\E-learning\Views\_ViewImports.cshtml"
using E_learning.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Shared\_LayoutCourseDetails.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fab69d938ed8ceabe5bf7a67c02255bd0bc1cea", @"/Views/Shared/_LayoutCourseDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23ee5d6484b2cae01d12209b36147c3399dee59", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutCourseDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<!-- Mirrored from gambolthemes.net/html-items/cursus_main_demo/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Tue, 15 Mar 2022 09:48:37 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fab69d938ed8ceabe5bf7a67c02255bd0bc1cea3733", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, shrink-to-fit=9"">
    <meta name=""description"" content=""Gambolthemes"">
    <meta name=""author"" content=""Gambolthemes"">
    <title>Cursus - Index</title>

    <link rel=""icon"" type=""image/png"" href=""../wwwroot/images/fav.png"">
    <link rel=""stylesheet"" type=""text/css"" href=""../../css/font-awesome.min.css"" />
    <link href=""https://fonts.googleapis.com/css?family=Roboto:400,700,500"" rel='stylesheet'>
    <link href='../../vendor/unicons-2.0.1/css/unicons.css' rel='stylesheet'>
    <link href=""../../css/vertical-responsive-menu.min.css"" rel=""stylesheet"">
    <link href=""../../css/style.css"" rel=""stylesheet"">
    <link href=""../../css/responsive.css"" rel=""stylesheet"">
    <link href=""../../css/night-mode.css"" rel=""stylesheet"">

    <link href=""../../vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"">
    <link href=""../../vendor/OwlCarousel/assets/");
                WriteLiteral(@"owl.carousel.css"" rel=""stylesheet"">
    <link href=""../../vendor/OwlCarousel/assets/owl.theme.default.min.css"" rel=""stylesheet"">
    <link href=""../../vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" type=""text/css"" href=""../../vendor/semantic/semantic.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fab69d938ed8ceabe5bf7a67c02255bd0bc1cea6129", async() => {
                WriteLiteral(@"


    <header class=""header clearfix"">
        <button type=""button"" id=""toggleMenu"" class=""toggle_menu"">
            <i class='uil uil-bars'></i>
        </button>
        <button id=""collapse_menu"" class=""collapse_menu"">
            <i class=""uil uil-bars collapse_menu--icon ""></i>
            <span class=""collapse_menu--label""></span>
        </button>
        <div class=""main_logo"" id=""logo"">
            <a href=""../Home""><img src=""../../images/logo_iprep.png""");
                BeginWriteAttribute("alt", " alt=\"", 2095, "\"", 2101, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n            <a href=\"../Home\"><img class=\"logo-inverse\" src=\"../../images/logo_iprep.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2198, "\"", 2204, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
        </div>
        <div class=""top-category"">
            <div class=""ui compact menu cate-dpdwn"">
                <div class=""ui simple dropdown item"">
                    <a href=""#"" class=""option_links p-0"" title=""categories""><i class=""uil uil-apps""></i></a>
                    <div class=""menu dropdown_category5"">
                        <a href=""#"" class=""item channel_item"">Development</a>
                        <a href=""#"" class=""item channel_item"">Business</a>
                        <a href=""#"" class=""item channel_item"">Finance & Accounting</a>
                        <a href=""#"" class=""item channel_item"">IT & Software</a>
                        <a href=""#"" class=""item channel_item"">Office Productivity</a>
                        <a href=""#"" class=""item channel_item"">Personal Development</a>
                        <a href=""#"" class=""item channel_item"">Design</a>
                        <a href=""#"" class=""item channel_item"">Marketing</a>
                        <a href=""#"" c");
                WriteLiteral(@"lass=""item channel_item"">Lifestyle</a>
                        <a href=""#"" class=""item channel_item"">Photography</a>
                        <a href=""#"" class=""item channel_item"">Health & Fitness</a>
                        <a href=""#"" class=""item channel_item"">Music</a>
                        <a href=""#"" class=""item channel_item"">Teaching & Academics</a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""search120"">
            <div class=""ui search"">
                <div class=""ui left icon input swdh10"">
                    <input class=""prompt srch10"" type=""text"" placeholder=""Search for Tuts Videos, Tutors, Tests and more.."">
                    <i class='uil uil-search-alt icon icon1'></i>
                </div>
            </div>
        </div>
        <div class=""header_right"">
            <ul>

                <li>
                    <a href=""/TeacherArea/CreateCourses/Indexcreatecourses"" class=""upload_btn"" title=""Create New C");
                WriteLiteral("ourse\">Create New Course</a>\r\n                </li>\r\n\r\n\r\n\r\n            </ul>\r\n        </div>\r\n        <div class=\"btn-group\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 4394, "\"", 4401, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"opts_account\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                <img src=\"../../images/hd_dp.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4541, "\"", 4547, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </a>
            <ul class=""dropdown-menu"">
                <li>
                    <div class=""menu dropdown_account"">
                        <div class=""channel_my"">
                            <div class=""profile_link"">

                                <div class=""pd_content"">
                                    <div class=""rhte85"">
                                        <h6>");
#nullable restore
#line 99 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Shared\_LayoutCourseDetails.cshtml"
                                       Write(Accessor.HttpContext.Session.GetString("User_Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                                        <div class=""mef78"" title=""Verify"">
                                            <i class='uil uil-check-circle'></i>
                                        </div>
                                    </div>
                                      </div>
                            </div>

                        </div>
                        <div class=""night_mode_switch__btn"">
                            <a href=""#"" id=""night-mode"" class=""btn-night-mode"">
                                <i class=""uil uil-moon""></i> Night mode
                                <span class=""btn-night-mode-switch"">
                                    <span class=""uk-switch-button""></span>
                                </span>
                            </a>
                        </div>
                    </div>
                </li>




                <li> <a href=""../../SignInSignUp/IndexSignIn"" class=""dp_link_12"" style=""text-align: center"">Sign Out</a></l");
                WriteLiteral(@"i>



            </ul>
        </div>
    </header>
    <nav class=""vertical_nav"">
        <div class=""left_section menu_left"" id=""js-menu"">
            <div class=""left_section"">
                <ul>
                    <li class=""menu--item"">

                        <a href=""../../TeacherHome/Indexteacherhome"" class=""menu--link"" title=""Dashboard"">
                            <i class=""uil uil-apps menu--icon""></i>
                            <span class=""menu--label"">Dashboard</span>
                        </a>
                    </li>
                    <li class=""menu--item"">
                        <a href=""/TeacherArea/MyCourses/Indexmycourses"" class=""menu--link"" title=""Courses"">
                            <i class='uil uil-book-alt menu--icon'></i>
                            <span class=""menu--label"">Courses</span>
                        </a>
                    </li>
                    <li class=""menu--item"">
                        <a href=""instructor_analyics.html"" ");
                WriteLiteral(@"class=""menu--link"" title=""Analyics"">
                            <i class='uil uil-analysis menu--icon'></i>
                            <span class=""menu--label"">Analyics</span>
                        </a>
                    </li>
                    <li class=""menu--item"">
                        <a href=""/TeacherArea/CourseTopic/Indexcoursetopic"" class=""menu--link "" title=""Create Course"">
                            <i class='uil uil-plus-circle menu--icon'></i>
                            <span class=""menu--label"">Add Topic</span>
                        </a>
                    </li>



                </ul>
            </div>

        </div>
    </nav>

    <div class=""wrapper"">
        <div class=""sa4d25"">
            <div class=""container-fluid"">
                <div class=""row"">

                    ");
#nullable restore
#line 172 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Shared\_LayoutCourseDetails.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
            </div>

        </div>

        <footer class=""footer mt-30"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-3 col-sm-6"">
                        <div class=""item_f1"">
                            <a href=""about_us.html"">About</a>

                            <a href=""career.html"">Careers</a>

                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-6"">
                        <div class=""item_f1"">
                            <a href=""help.html"">Help</a>
                            <a href=""coming_soon.html"">Advertise</a>
                            <a href=""coming_soon.html"">Developers</a>
                            <a href=""contact_us.html"">Contact Us</a>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-6"">
                        <div class=""item_f1"">
                WriteLiteral(@"
                            <a href=""terms_of_use.html"">Copyright Policy</a>
                            <a href=""terms_of_use.html"">Terms</a>

                            <a href=""sitemap.html"">Sitemap</a>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-6"">
                        <div class=""item_f3"">
                            <a href=""#"" class=""btn1542"">Teach on iPREP</a>
                            <div class=""lng_btn"">
                                <div class=""ui language bottom right pointing dropdown floating"" id=""languages"" data-content=""Select Language"">
                                    <a href=""#""><i class='uil uil-globe lft'></i>Language<i class='uil uil-angle-down rgt'></i></a>
                                    <div class=""menu"">
                                        <div class=""scrolling menu"">
                                            <div class=""item"" data-percent=""100"" data-value=""en"" data-english=""E");
                WriteLiteral(@"nglish"">
                                                <span class=""description"">English</span>
                                                English
                                            </div>


                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""footer_bottm"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <ul class=""fotb_left"">
                                        <li>
                                            <a href=""../Home/Indexlandingpage"">
                                                <div class=""footer_logo"">
                                                    <img src=""../../images/minilogosize-removebg-preview (1).png"" alt=""im");
                WriteLiteral(@"age"">
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <p>© 2022 <strong>iPREP</strong>. All Rights Reserved.</p>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""edu_social_links"">
                                        <a href=""#""><i class=""fab fa-facebook-f""></i></a>

                                        <a href=""#""><i class=""fab fa-google-plus-g""></i></a>
                                        <a href=""#""><i class=""fab fa-linkedin-in""></i></a>
                                        <a href=""#""><i class=""fab fa-instagram""></i></a>
                                        <a href=""#""><i class=""fab fa-youtube""></i></a>

 ");
                WriteLiteral(@"                                   </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
    </div>

    <script data-cfasync=""false"" src=""../../cdn-cgi/scripts/5c5dd728/cloudflare-static/email-decode.min.js""></script>
    <script src=""js/vertical-responsive-menu.min.js""></script>
    <script src=""js/jquery-3.3.1.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""vendor/OwlCarousel/owl.carousel.js""></script>
");
                WriteLiteral("    <script src=\"js/custom.js\"></script>\r\n    <script src=\"js/night-mode.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from gambolthemes.net/html-items/cursus_main_demo/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Tue, 15 Mar 2022 09:49:22 GMT -->\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; }
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