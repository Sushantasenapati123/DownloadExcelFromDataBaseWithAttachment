#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\Sport\Sport_Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d6e66911003405ee7e504039d76af71b66fe6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sport_Sport_Registration), @"mvc.1.0.view", @"/Views/Sport/Sport_Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d6e66911003405ee7e504039d76af71b66fe6a", @"/Views/Sport/Sport_Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80dac61a8d7dc27969faff32e42edc31be5502e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sport_Sport_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam.Domain.Sports.Spot>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sport_Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View_SportRegistration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Club"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("GetAllSubCatByCId()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/validation/validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\Sport\Sport_Registration.cshtml"
  
    ViewData["Title"] = "AddDoctor";

    
 
    var ResultData = ViewBag.Result as List<Exam.Domain.Sports.Spot>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
   
</style>
<div class=""container position-sticky"">
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><span><i class=""fa fa-home""></i></span></li>
            <li class=""breadcrumb-item active alert-danger"">Sports Club Registration Form</li>
           </ol>
    </nav>
</div>
");
            WriteLiteral("<!--<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12\">\r\n        <div class=\"card\">-->\r\n");
            WriteLiteral("            <!--<div class=\"card-header\">\r\n                <div class=\"card-header\">-->\r\n");
            WriteLiteral("\r\n                <!--</div>\r\n\r\n            </div>-->\r\n");
            WriteLiteral("\r\n            <!--<!-- BASIC FORM ELEMENTS -->\r\n            <!--===================================================-->\r\n            <!--<div class=\"card-body\">\r\n\r\n                <div class=\"row\">-->\r\n");
            WriteLiteral("                <!--</div>\r\n\r\n                <div class=\"row\">-->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                <!--</div>\r\n\r\n                <div class=\"row\">-->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                <!--</div>\r\n                <div class=\"form-group center\">\r\n                    <label class=\"col-12 col-md-2 col-xl-2 control-label\"></label>\r\n                    <div class=\"col-12 col-md-6 col-xl-4\">-->\r\n");
            WriteLiteral(@"
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card"">
                            <div class=""card-header d-sm-inline-flex justify-content-between"">
                                <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d6e66911003405ee7e504039d76af71b66fe6a9879", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d6e66911003405ee7e504039d76af71b66fe6a11356", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </ul>
                                <div class=""indicatorslist"">
                                    <p class=""ml-2 text-danger"">(*) Indicates mandatory </p>
                                </div>
                            </div>
                            <div class=""card-body"">
                                <div class=""container"">

                                    <div class=""row mt-2 mb-2"">
                                        <div class=""form-group col-sm-6"">
                                            <label>CLUB NAME<span class=""text-danger"">*</span></label>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d6e66911003405ee7e504039d76af71b66fe6a13483", async() => {
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#nullable restore
#line 147 "C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\Views\Sport\Sport_Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.UnitName,"club_id","club_name"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""form-group col-sm-6"">
                                            <label>SPORTS NAME<span class=""text-danger"">*</span></label>
                                            <select id=""Sports"" class=""form-control"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d6e66911003405ee7e504039d76af71b66fe6a15682", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>


                                    <fieldset class=""border-2"">
                                        <legend>Applicant Details</legend>
                                        <div class=""row mt-2 mb-2"">
                                            <div class=""form-group col-sm-4"">
                                                <label>Applicant Name <span class=""text-danger"">*</span></label>
                                                <input id=""NAme"" class=""form-control"" onchange=""NamevalidationC('NAme','lblErrorName')"" />
                                                <span id=""lblErrorName"" style=""color:red""></span>
                                            </div>
                                            <div class=""form-group col-sm-4 "">
                                                <label>Email <span class=""text-danger"">*</span></");
            WriteLiteral(@"label>
                                                <input id=""Email"" type=""email"" class=""form-control"" onchange=""emailValidate('Email','lblError')"" />
                                                <span id=""lblError"" style=""color:red""></span>
                                            </div>
                                            <div class=""form-group col-sm-4 "">
                                                <label>Mobile No<span class=""text-danger"">*</span></label>
                                                <input id=""Mobile"" class=""form-control"" onchange=""Phonevalidate('Mobile','lblErrorPhone')"" />
                                                <span id=""lblErrorPhone"" style=""color:red""></span>
                                            </div>
                                        </div>
                                        <div class=""row mt-2 mb-2"">
                                            <div class=""form-group col-sm-3 "">
                                        ");
            WriteLiteral(@"        <label>Date of Birth<span class=""text-danger"">*</span></label>
                                                <input id=""dob"" class=""form-control "" type=""date"" />
                                            </div>
                                            <div class=""form-group col-sm-4"">
                                                <label>Gender<span class=""text-danger"">*</span></label>
                                                <div class=""d-flex col-sm-6 mt-1"">
                                                    <div class=""form-check col-sm-5"">
                                                        <input type=""radio"" id=""type1"" class=""form-check-input s_type"" name=""SchoolType"" value=""Male"">
                                                        <label for=""type1"" class=""form-check-label"">Male</label>
                                                    </div>
                                                    <div class=""form-check col-sm-3 "">
                             ");
            WriteLiteral(@"                           <input type=""radio"" id=""type2"" class=""form-check-input s_type"" name=""SchoolType"" value=""Female"">
                                                        <label for=""type2"" class=""form-check-label"">Female</label><br>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-group col-sm-3"">
                                                <label>Upload PHOTO<span class=""text-danger"">*</span></label>
                                                <input id=""Image"" class=""form-control"" type=""file"" />
                                                <img");
            BeginWriteAttribute("src", " src=\"", 10960, "\"", 10966, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""img"" height=""50"" width=""50"" />
                                            </div>
                                        </div>

                                        <div class=""row mt-2 mb-2"">
                                            <div class=""col-sm-""></div>
                                            <div class=""form-group col-sm-6"">
                                                <button class=""btn btn-success mb-1"" id=""btnSubmit"">Submit</button>
                                                <button class=""btn btn-danger mb-1"" id=""btnCancel"">Reset</button>
                                            </div>
                                        </div>
                                    </fieldset>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


    


        <div class=""form-group col-md-4"">

            <input id=""PatientID"" class=""f");
            WriteLiteral("orm-control\" hidden />\r\n        </div>\r\n\r\n\r\n     \r\n\r\n\r\n  \r\n    <!--===================================================-->\r\n    <!-- END BASIC FORM ELEMENTS -->\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d6e66911003405ee7e504039d76af71b66fe6a22288", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d6e66911003405ee7e504039d76af71b66fe6a23328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        //breadcumb
        var id = getUrlVars()[""id""];
        if (id != undefined) {
            $(""#btnSubmit"").html(""Update"");
            $(""#btnCancel"").html(""Cancel"");

            Edit(id);
        }
    });
    function GetAllSubCatByCId() {

        $.ajax({
            url: ""/Sport/GetSubCatByCId?clubid="" + $('#Club').val(),
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.sport_Id + "">"" + item.sprot_name + ""</option>"";
                });
                $(""#Sports"").html(v);
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
                bootbox.alert(""Error : "" + jsonValue);
            }
        });
    }

    function validate");
            WriteLiteral(@"() {
          if ($('#Club').val() == ""0"") {
            alert(""Please Select Club !"");
            return false;
            $('#Club').focus();
        }

        else if ($('#Sports').val() == ""0"") {
            alert(""Please Select Sports !"");
            return false;
            $('#Sports').focus();
        }
       else if ($('#NAme').val() == """") {
            alert(""Please Enter Name!"");
            $('#NAme').focus();
            return false;
        }
        else if ($('#Email').val() == """") {
            alert(""Please Enter Email!"");
            return false;
            $('#Email').focus();
        }
        else if ($('#Mobile').val() == """") {
            alert(""Please Enter Mobile"");
            $('#Mobile').focus();
            return false;
          }
          else if ($('#dob').val() == """") {
              alert(""Please Select dob !"");
              return false;
              $('#dob').focus();
          }
        else if ($('#Gender').val() == ""0"") {
");
            WriteLiteral(@"            alert(""Please Select Gender!"");
            $('#Gender').focus();
            return false;
        }
          else if ($('#Image').val() == """") {
              alert(""Please Select Image !"");
              return false;
              $('#Image').focus();
          }
        else
            return true;



    }
    function reset() {
        $('#PatientID').val("""");
        $(""#NAme"").val("""");
        $(""#Email"").val("""");
        $(""#Mobile"").val("""");

        $(""#dob"").val("""");

        $(""#Gender"").val(""0"");
        $(""#Club"").val(""0"");
        $(""#Sports"").val(""0"");
    }
    $(""#btnCancel"").click(function () { reset()});

    $(""#btnSubmit"").click(function () {
       
      

        var doc = {
            Registration_Id: $(""#PatientID"").val(),
            Applicant_name: $(""#NAme"").val(),
            Email: $(""#Email"").val(),
            Mobile_no: $(""#Mobile"").val(),
            image_path: $(""#Image"").val(),
            //Gender: $(""#Gender"").val");
            WriteLiteral(@"(),
            Gender: $("".s_type:checked"").val(),
            dob: $(""#dob"").val(),
            club_id: $(""#Club"").val(),
            sport_Id: $(""#Sports"").val(),


        };
        if (validate() && emailValidate('Email', 'lblError') == true && Phonevalidate('Mobile', 'lblErrorPhone') == true && NamevalidationC('NAme', 'lblErrorName')) {
            $.ajax({
                url: ""/Sport/Add"",
                data: doc,
                type: ""POST"",
                success: function (result) {
                    if (result==""Age must Be Greater Than 13"")
                        alert(result);
                    else {
                        Email();
                        //alert(result);
                        //window.location.href = ""/Sport/View_SportRegistration"";
                    }

                },
                //error: function (errormessage) {
                //    alert(errormessage.responseText);
                //}
            });

        }


    }");
            WriteLiteral(@");
    function Email() {
        var formData = new FormData();

        formData.append(""ToEmail"", $(""#Email"").val());
        formData.append(""Subject"", ""Success"");
        formData.append(""Body"", ""You have successfully registered. Your Name is:"" + $(""#NAme"").val() + "" & Your Email:"" + $(""#Email"").val());

        var photoInput = $(""#Image"")[0]; // Assuming your input id is ""Photo""

        if (photoInput.files.length > 0) {
            formData.append(""Attachment"", photoInput.files[0]);
        }

        $.ajax({
            type: ""post"",
            url: ""/Sport/SendEmailAsyncFromAPath"",//SendEmailAsyncFromAPath OR SendSucessEmail
            data: formData,
            processData: false,
            contentType: false,
            success: function (data) {
                if (data === 1) {
                    alert('Data Saved successfully.');
                    window.location.href = ""/Sport/View_SportRegistration"";
                } else {
                    alert(""Pleas");
            WriteLiteral(@"e change the Network"");
                }
            }
        });

        return false;
    }


    //function Email() {

    //    $.ajax({
    //        type: ""post"",
    //        url: ""/Sport/SendSucessEmail"",
    //        data: {
    //            ToEmail: $(""#Email"").val()
    //            , Subject: ""Success""
    //            , Body: ""You have successfully registered. Your Name is:"" + $(""#NAme"").val() + "" & Your Email:"" + $(""#Email"").val()
    //            , Attachments: """"
    //        },
    //        datatype: ""json"",
    //        traditional: true,
    //        success: function (data) {
    //            if (data == 1) {

    //                alert('Data Saved successfully.');
    //                window.location.href = ""/Sport/View_SportRegistration"";


    //            }

    //            else {
    //                alert(""Please change the Network"");
    //            }
    //        }

    //    });
    //    return false;
    //}

    //U");
            WriteLiteral(@"PDATE
    function Edit(id) {
        $(""#btnSubmit"").html('Update')
        $.ajax({
            url: ""/Sport/MedicineGetById?id="" + id,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                $(""#PatientID"").val(id);
                $(""#NAme"").val(result.Applicant_name);
                $(""#Email"").val(result.Email);
                $(""#Mobile"").val(result.Mobile_no);

                $.ajax({
                    url: ""/Sport/GetSubCatByCId?clubid="" + result.club_id,
                    type: ""GET"",
                    success: function (result1) {
                        data = JSON.parse(result1);
                        var v = ""<option value='0'>--Select--</option>"";
                        $.each(data, function (i, item) {
                            v += ""<option value="" + item.sport_Id + "">"" + item.sprot_name + ""</option>"";
                        });
             ");
            WriteLiteral(@"           $(""#Sports"").html(v);
                        $(""#Sports"").val(result.sport_Id);

                    },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        bootbox.alert(""Error : "" + jsonValue);
                    }
                });

               // $(""#Gender"").val(result.Gender);

                $('input[type=""radio""]').each(function () {
                    if ($(this).val() == result.Gender) {
                        $(this).attr('checked', 'checked');
                    }
                });
                $(""#dob"").val(result.dob);
                $(""#Club"").val(result.club_id);
                $(""#img"").attr(""src"", ""../""+result.image_path);


            },
            //error: function (errormessage) {
            //    alert(errormessage.responseText);
            //}
        });
        return false;
    }


    function readURL(input) {
        if (input.f");
            WriteLiteral(@"iles && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#img').attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[0]);
        }
    }

    $(""#Image"").change(function () {
        readURL(this);
    });



    //DELETE

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam.Domain.Sports.Spot> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
