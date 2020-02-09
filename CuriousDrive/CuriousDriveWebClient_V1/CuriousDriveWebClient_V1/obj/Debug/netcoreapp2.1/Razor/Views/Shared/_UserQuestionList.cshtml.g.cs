#pragma checksum "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4453522096e92f642dc6ec4bfa3631166452e302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserQuestionList), @"mvc.1.0.view", @"/Views/Shared/_UserQuestionList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_UserQuestionList.cshtml", typeof(AspNetCore.Views_Shared__UserQuestionList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4453522096e92f642dc6ec4bfa3631166452e302", @"/Views/Shared/_UserQuestionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserQuestionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CuriousDriveWebClient.UserQuestionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 59, true);
            WriteLiteral("\r\n<div class=\"col-md-12 col-xs-12\">\r\n    <br />\r\n</div>\r\n\r\n");
            EndContext();
#line 7 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml"
 using (Html.BeginForm("UserQuestionList", "Question", FormMethod.Post, new { role = "form" }))
{

#line default
#line hidden
            BeginContext(218, 134, true);
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <span style=\"font-weight:bolder;font-size:x-large\">Questions</span>\r\n        <hr />\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml"

    if (Model.Count > 0)
    {
        for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
            BeginContext(445, 99, true);
            WriteLiteral("        <div class=\"col-md-12 hover_effect\">\r\n            <div class=\"col-md-12\">\r\n                ");
            EndContext();
            BeginContext(545, 430, false);
#line 20 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml"
           Write(Html.ActionLink(Model[i].questionTitle, "Question", "Question",
                                                  new
                                                  {
                                                      id = Model[i].questionId,
                                                      title = Model[i].questionTitleURL
                                                  }, new { @class = "bold-main-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(975, 51, true);
            WriteLiteral("\r\n                <br />\r\n                asked on ");
            EndContext();
            BeginContext(1027, 74, false);
#line 27 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml"
                    Write(String.Format("{0:MMM d, yyyy}", Convert.ToDateTime(Model[i].createdDate)));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml"
            
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1188, 138, true);
            WriteLiteral("        <div class=\"col-md-12\">\r\n            <span>\r\n                There are no questions to show\r\n            </span>\r\n        </div>\r\n");
            EndContext();
#line 40 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Shared\_UserQuestionList.cshtml"
    }

}

#line default
#line hidden
            BeginContext(1338, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CuriousDriveWebClient.UserQuestionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
