#pragma checksum "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CreateCourses\Indexcreatecourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d84595a4f29b576a9497afb2455db862f2bf6c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TeacherArea_Views_CreateCourses_Indexcreatecourses), @"mvc.1.0.view", @"/Areas/TeacherArea/Views/CreateCourses/Indexcreatecourses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d84595a4f29b576a9497afb2455db862f2bf6c4", @"/Areas/TeacherArea/Views/CreateCourses/Indexcreatecourses.cshtml")]
    public class Areas_TeacherArea_Views_CreateCourses_Indexcreatecourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CreateCourses\Indexcreatecourses.cshtml"
   Layout = "/Views/Shared/_LayoutTeacher.cshtml";

     

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d84595a4f29b576a9497afb2455db862f2bf6c43009", async() => {
                WriteLiteral(@"
    <!------!!!!!!!!!!!!!  EDITIOR IS NOT FULLY FUNCTIONAL WE HAVE TO ADD SOME PLUGINS !!!!!!!!!!!!-->

    <div class=""sa4d25"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h2 class=""st_title""><i class=""uil uil-analysis""></i> Create New Course</h2>
                </div>
            </div>
            <form action=""IndexcreatecoursesSave"" method=""post"" id=""form_course"" onsubmit=""return validateform()"">

                <!--alert message-->
               <div style=""color:red"">
                   <h3> ");
#nullable restore
#line 19 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CreateCourses\Indexcreatecourses.cshtml"
                   Write(TempData["Msg"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                </div>


                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""course_tabs_1"">
                            <div class=""step-content"">
                                <div class=""step-tab-panel step-tab-info active"">
                                    <div class=""tab-from-content"">
                                        <div class=""title-icon"">
                                            <h3 class=""title""><i class=""uil uil-info-circle""></i>Course Information</h3>
                                        </div>


                                        <div class=""course__form""  >
                                            <div class=""general_info10"">
                                                <div class=""row"">
                                                    <div class=""col-lg-12 col-md-12"">
                                                        <div class=""ui search focus mt-30 lbel25"">
                                  ");
                WriteLiteral(@"                          <label>Course Name*</label>
                                                            <div class=""ui left icon input swdh19"">
                                                                <input class=""prompt srch_explore"" autocomplete=""off"" type=""text""  placeholder=""Course Name here"" oninput=""setCustomValidity('')"" autofocus oninvalid=""this.setCustomValidity('Get Lost')"" name=""Course_name"" required   data-purpose=""edit-course-title"" minlength=""5"" maxlength=""60"" id=""main[title]""");
                BeginWriteAttribute("value", " value=\"", 2206, "\"", 2214, 0);
                EndWriteAttribute();
                WriteLiteral(@" >
                                                                <div class=""badge_num"">60</div>
                                                            </div>
                                                            <div class=""help-block"">(Please make this a maximum of 60 characters and unique.)</div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-12 col-md-12"">
                                                        <div class=""ui search focus mt-30 lbel25"">
                                                            <label>Course Title*</label>
                                                            <div class=""ui left icon input swdh19"">
                                                                <input class=""prompt srch_explore"" type=""text"" placeholder=""Course title here"" name=""Course_Title""");
                BeginWriteAttribute("required", " required=\"", 3187, "\"", 3198, 0);
                EndWriteAttribute();
                WriteLiteral("  data-purpose=\"edit-course-title\" maxlength=\"60\" id=\"main[title]\"");
                BeginWriteAttribute("value", " value=\"", 3265, "\"", 3273, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                                <div class=""badge_num"">60</div>
                                                            </div>
                                                            <div class=""help-block"">(Please make this a maximum of 60 characters and unique.)</div>
                                                        </div>
                                                    </div>
                                                    <!--  <div class=""col-lg-12 col-md-12"">
                                            <div class=""ui search focus lbel25 mt-30"">
                                                <label>Short Description*</label>
                                                <div class=""ui form swdh30"">
                                                    <div class=""field"">
                                                        <textarea rows=""3"" name=""Course_Description"" id="""" placeholder=""Course description here...""></textarea>
                   ");
                WriteLiteral(@"                                 </div>
                                                </div>
                                                <div class=""help-block"">220 words</div>
                                            </div>
                                        </div>-->
                                                    <div class=""col-lg-12 col-md-12"">
                                                        <div class=""course_des_textarea mt-30 lbel25"">
                                                            <label>Course Description*</label>
                                                            <div class=""course_des_bg"">
                                                                <ul class=""course_des_ttle"">
                                                                    <li><a href=""#""><i class=""uil uil-bold""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-italic""></i></a></li>
                             ");
                WriteLiteral(@"                                       <li><a href=""#""><i class=""uil uil-list-ul""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-left-to-right-text-direction""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-right-to-left-text-direction""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-list-ui-alt""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-link""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-text-size""></i></a></li>
                                                                    <li><a href=""#""><i class=""uil uil-text""></i></a></li>
                                                                </ul>
                                                                <d");
                WriteLiteral(@"iv class=""textarea_dt"">
                                                                    <div class=""ui form swdh339"">
                                                                        <div class=""field"">
                                                                            <textarea rows=""5"" name=""Course_Description""  id=""id_course_description""");
                BeginWriteAttribute("required", " required=\"", 6708, "\"", 6719, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Insert your course description""></textarea>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <!-- <div class=""col-lg-6 col-md-12"">
                                            <div class=""ui search focus lbel25 mt-30"">
                                                <label>What will students learn in your course?*</label>
                                                <div class=""ui form swdh30"">
                                                    <div class=""field"">
                                                        <textarea rows=""3"" name=""Course_Description"" id="""" placeholder=""""");
                WriteLiteral(@"></textarea>
                                                    </div>
                                                </div>
                                                <div class=""help-block"">Student will gain this skills, knowledge after completing this course. (One per line).</div>
                                            </div>
                                        </div>-->

                                                    <div class=""col-lg-6 col-md-12"">
                                                        <div class=""mt-30 lbel25"">
                                                            <label>Course Level*</label>
                                                        </div>
                                                        <select class=""ui hj145 dropdown cntry152 prompt srch_explore""");
                BeginWriteAttribute("required", " required=\"", 8576, "\"", 8587, 0);
                EndWriteAttribute();
                WriteLiteral("  name=\"Course_Level\">\n                                                            <option");
                BeginWriteAttribute("value", " value=\"", 8678, "\"", 8686, 0);
                EndWriteAttribute();
                WriteLiteral(@">Select Level</option>
                                                            <option value=""Beginner"">Beginner</option>
                                                            <option value=""Intermediate"">Intermediate</option>
                                                            <option value=""Expert"">Expert</option>
                                                        </select>
                                                    </div>

                                                    <div class=""col-lg-6 col-md-6"">
                                                        <div class=""mt-30 lbel25"">
                                                            <label>Course Category*</label>
                                                        </div>
                                                        <select class=""ui hj145 dropdown cntry152 prompt srch_explore""");
                BeginWriteAttribute("required", " required=\"", 9589, "\"", 9600, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"Course_Category\">\n                                                            <option");
                BeginWriteAttribute("value", " value=\"", 9693, "\"", 9701, 0);
                EndWriteAttribute();
                WriteLiteral(@">Select</option>

                                                            <option class=""ui horizontal divider opt_title"">Development</option>
                                                            <option value=""Web Development"">Web Development</option>
                                                            <option value=""Data Science"">Data Science</option>
                                                            <option value=""Programming Languages"">Programming Languages</option>
                                                            <option value=""Mobile Apps"">Mobile Apps</option>
                                                            <option value=""Game Development"">Game Development</option>
                                                            <option value=""Databases"">Databases</option>
                                                            <option value=""Software Testing"">Software Testing</option>
                                                            <option ");
                WriteLiteral(@"value=""Software Engineering"">Software Engineering</option>
                                                            <option value=""Development Tools"">Development Tools</option>


                                                        </select>

                                                    </div>
                                                    <!--course image-->
                                                    <div class=""col-lg-6 col-md-6"">
                                                        <div class=""ui search focus mt-30 lbel25"">
                                                            <label>Course image*</label>
                                                            <div class=""ui left icon input swdh19"">
                                                                <input class=""prompt srch_explore"" type=""file"" placeholder=""Course image here""");
                BeginWriteAttribute("required", " required=\"", 11620, "\"", 11631, 0);
                EndWriteAttribute();
                WriteLiteral(@"  name=""Course_Image"" data-purpose=""edit-course-title"" maxlength=""60"" id=""main[title]"" onchange=""encodeImgtoBase64(this)"">
                                                                <input id=""convertImg"" name=""convertImg"" type=""hidden"" />

                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>

                    <div class=""step-footer step-tab-pager"">

                        <button data-direction=""finish"" class=""btn btn-default steps_btn""   ");
                WriteLiteral("\">Submit</button>\n                    </div>\n\n                </div>\n            </form>\n        </div>\n    </div>\n\n\n");
                WriteLiteral(@"
    <script type=""text/javascript"">


        function encodeImgtoBase64(element) {
            var img = element.files[0];
            var reader = new FileReader();

            reader.onloadend = function () {
                $(""#convertImg"").attr(""value"", reader.result);

            }

            reader.readAsDataURL(img);


        }

        //function validateform() {
        //    let x = document.forms[form_course][course_name].value;
        //    if (x == """") {
        //        alert(""course_name must be filled."");
        //        return false;
        //    }
           
        //}


        //$(document).ready(function () {
        //    $(""#form_course"").validate({

        //        rules: {

        //            'Course_name': {
        //                required: true,
        //                minlength: 5,
        //                maxlength: 60
        //            }
        //        },
        //        messages: {
        //            'Course_name':""Please E");
                WriteLiteral("nter Course Name.\"\r\n        //        }\r\n        //    });\r\n        //});\n    </script>\n");
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
