#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c410f6f989e374c4340f845accc38519d23083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QueryBuilder_QueryBuilder), @"mvc.1.0.view", @"/Views/QueryBuilder/QueryBuilder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\_ViewImports.cshtml"
using Exam.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\_ViewImports.cshtml"
using Exam.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c410f6f989e374c4340f845accc38519d23083", @"/Views/QueryBuilder/QueryBuilder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80dac61a8d7dc27969faff32e42edc31be5502e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QueryBuilder_QueryBuilder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrameworkConsole.Model.QueryBuilder.QueryBuilderModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
  
    ViewBag.Title = "QueryBuilder";

    var dt = ViewBag.Result as DataTable;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    table {\r\n        font-size: 12px;\r\n    }\r\n</style>\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
 using (Html.BeginForm("QueryBuilder", "QueryBuilder", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 22 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
      Write(ViewBag.showmessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</title>
    <div class=""formpage"">

        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""panel panel-default"">

                    <div class=""panel-body"">


                        <div class=""form-group"">

                            <div class=""row"">
                                <div class=""col-md-3"">
                                </div>
                                <div class=""col-md-3"">
                                    <b> Authentication (For DML Operation):</b>
                                </div>
                                <div class=""col-md-3"">
                                    ");
#nullable restore
#line 41 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                               Write(Html.PasswordFor(model => model.DMLCode, new { @Value = @ViewBag.DMLCode, autocomplete = "off", @class = "form-control", maxlength = "50", placeholder = "Enter your Authentication Code" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <br />
                                </div>
                                <div class=""col-md-3"">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-2"">
                                </div>
                                <div class=""col-md-8"">
                                    <br />
                                    <h3>Enter your query below</h3>
                                </div>
                                <div class=""col-md-2"">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-2"">
                                </div>
                                <div class=""col-md-8"">
                                    <br />
                                    ");
#nullable restore
#line 62 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                               Write(Html.TextAreaFor(model => model.QueryText, new { @Value = @ViewBag.QueryText, autocomplete = "off", @placeholder = "Enter your query here", @class = "form-control QueryTextbox", style = "height:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""col-md-2"">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-5"">

                                    <br />
                                </div>
                                <div class=""col-md-4"">

                                    <br />
                                    <table>
                                        <tr>

                                            <td>
                                            <td> <input type=""submit"" value=""Execute"" class=""btn btn-success "" name=""Command"" id=""btn1"" /></td>
                                        </tr>
                                    </table>
                                </div>
                                <div class=""col-md-5"">
                                </div>
                            </div>

    ");
            WriteLiteral("                        <div class=\"row\">\r\n                                <div class=\"col-md-12\">\r\n                                    <h5 class=\"text-warning\"><b>");
#nullable restore
#line 89 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                                                           Write(ViewBag.showmessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n");
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-12"">
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 106 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
         if (dt != null)
        {
            int count = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
             foreach (DataRow row in dt.Rows)
            {
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Total row :");
#nullable restore
#line 113 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                        Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 114 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table cellpadding=\"0\" cellspacing=\"0\" class=\"table table-bordered \" id=\"resultDataTable\">\r\n\r\n");
#nullable restore
#line 117 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
             if (dt != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 120 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                     foreach (DataColumn col in dt.Columns)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>");
#nullable restore
#line 122 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                       Write(col.ColumnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 123 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 127 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                 foreach (DataRow row in dt.Rows)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 130 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                         foreach (DataColumn col in dt.Columns)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 132 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                           Write(row[col.ColumnName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 133 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 135 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n\r\n    </div>\r\n");
#nullable restore
#line 143 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\QueryBuilder\QueryBuilder.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrameworkConsole.Model.QueryBuilder.QueryBuilderModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591