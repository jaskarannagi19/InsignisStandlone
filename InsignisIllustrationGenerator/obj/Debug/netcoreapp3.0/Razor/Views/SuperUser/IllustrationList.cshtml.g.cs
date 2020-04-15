#pragma checksum "D:\insignis\ExternalIllustrator\Clients\InsignisIllustrationGenerator\Views\SuperUser\IllustrationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6bb2881c40f79a2abacfd981b7966c5dc3d54b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperUser_IllustrationList), @"mvc.1.0.view", @"/Views/SuperUser/IllustrationList.cshtml")]
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
#line 1 "D:\insignis\ExternalIllustrator\Clients\InsignisIllustrationGenerator\Views\_ViewImports.cshtml"
using InsignisIllustrationGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\insignis\ExternalIllustrator\Clients\InsignisIllustrationGenerator\Views\_ViewImports.cshtml"
using InsignisIllustrationGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6bb2881c40f79a2abacfd981b7966c5dc3d54b", @"/Views/SuperUser/IllustrationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc31017ea0574b4bf5a5115fd6862ed4d7895b5", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperUser_IllustrationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IllustrationListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\insignis\ExternalIllustrator\Clients\InsignisIllustrationGenerator\Views\SuperUser\IllustrationList.cshtml"
  
    ViewData["Title"] = "IllustrationList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""middle-section"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""right""><input type=""submit"" href=""#"" id=""GenerateCSV"" class=""btn btn-primary"" value=""Generate CSV"" /></div>
            </div>
            <div class=""col-lg-12 col-sm-12"">
                <div class=""illustration-generator"">

                    <h4 class=""heading-1"">Search By:</h4>
                    <span id=""validationerror"" class=""text-danger""></span>
                    <div class=""gray-bg"">
                        <div class=""form-row"">
                            <div class=""form-group col-lg-4"">
                                <label for=""inputEmail4"">Advisor Name</label>
                                <input type=""text"" class=""form-control"" id=""PartnerName"" name=""PartnerName"" placeholder=""Advisor Name"">
                            </div>
                            <div class=""form-group col-lg-4"">
             ");
            WriteLiteral(@"                   <label for=""inputPassword4"">Client Name</label>
                                <input type=""text"" class=""form-control"" id=""ClientName"" name=""ClientName"" placeholder=""Client Name"">
                            </div>
                            <div class=""form-group col-lg-4"">
                                <label for=""inputPassword4"">Company Name</label>
                                <input type=""text"" class=""form-control"" id=""CompanyName"" name=""CompanyName"" placeholder=""Company Name"">
                            </div>
                            <div class=""form-group col-lg-4"">
                                <label for=""inputPassword4"">Illustration Unique Reference</label>
                                <input type=""text"" class=""form-control"" name=""IllustrationUniqueReference"" id=""IllustrationUniqueReference"" placeholder=""Illustration Unique Reference"">
                            </div>
                            <div class=""form-group col-lg-4"">
                     ");
            WriteLiteral(@"           <label for=""inputPassword4"">From Date</label>
                                <input type=""date"" class=""form-control"" name=""IllustrationFrom"" id=""IllustrationFrom"" placeholder=""dd-mm-yyyy"">
                            </div>
                            <div class=""form-group col-lg-4"">
                                <label for=""inputPassword4"">To Date</label>
                                <input type=""date"" class=""form-control"" name=""IllustrationTo"" id=""IllustrationTo"" placeholder=""dd-mm-yyyy"">
                            </div>
                        </div>

                        <div class=""col-lg-12 center"">
                            <input id=""btnSearch"" type=""button"" class=""btn btn-primary"" value=""Search"" />
");
            WriteLiteral("                            ");
#nullable restore
#line 50 "D:\insignis\ExternalIllustrator\Clients\InsignisIllustrationGenerator\Views\SuperUser\IllustrationList.cshtml"
                       Write(Html.ActionLink("Reset", "IllustrationList", "SuperUser", new { actionid = "IllustrationList" }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"clear1\"></div>\r\n        ");
#nullable restore
#line 61 "D:\insignis\ExternalIllustrator\Clients\InsignisIllustrationGenerator\Views\SuperUser\IllustrationList.cshtml"
   Write(Html.Partial("_IllustrationList", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

</div>
<script>
    $(document).ready(function () {
        LoadData();
    })

    $(document).on(""click"", ""#bankDetailRow"", function () {
        var illustrationUniqueReference = $(this).closest('tr').find('#item_IllustrationUniqueReference').val();

        window.location = ""/SuperUser/GetIllustration?uniqueReferenceId="" + illustrationUniqueReference;
    });
    $(document).on(""click"", ""#GenerateCSV"", function () {

        $.ajax({
            url: ""../../SuperUser/ExportCSV"",
            type: ""POST"",
            data: {
                AdvisorName: $(""#AdvisorName"").val(),
                ClientName: $(""#ClientName"").val(),
                CompanyName: $(""#CompanyName"").val(),
                IllustrationUniqueReference: $(""#IllustrationUniqueReference"").val(),
                IllustrationFrom: $(""#IllustrationFrom"").val(),
                IllustrationTo: $(""#IllustrationTo"").val()
            },

            success: function (response, textStatus, jqXHR) {
");
            WriteLiteral(@"                var element = document.createElement('a');
                element.setAttribute('href', 'data:text/plain;charset=utf-8,' + response.data);
                element.setAttribute('download', response.fileName);

                element.style.display = 'none';
                document.body.appendChild(element);

                element.click();

                document.body.removeChild(element);

            },
            error: function (jqXHR, textStatus, errorThrown) {

            }
        });
    });



    function check_advisorName(letters) {
        debugger;
        var regex = /^[0-9]+$/;
        if (regex.test(letters) == false) {
            $(""#validationError"").text(""Advisor name must be in digits only"");
            return false;
        }
        return true;
    }
    function check_CompanyName(letters) {
        var regex = /^[a-zA-Z0-9-;:,.&$£€#/\\. """"]{0,160}/
        if (regex.test(letters) == false) {
            $(""#validationError"").text(""");
            WriteLiteral(@"Advisor name must be in digits only"");
            return false;
        }
        return true;
    }


     function check_ClientName(letters) {
        var regex =/^[a-zA-Z0-9-_,£$/\\. """"]{0,60}/
        if (regex.test(letters) == false) {
            $(""#validationError"").text(""Advisor name must be in digits only"");
            return false;
        }
        return true;
    }

     function check_IllustrationName(letters) {
        var regex =/^[a-zA-Z0-9-_]+$/ 
        if (regex.test(letters) == false) {
            $(""#validationError"").text(""Advisor name must be in digits only"");
            return false;
        }
        return true;
    }

    $(document).on(""click"", ""#btnSearch"", function () {
        //validation
        var ad = check_advisorName($(""#AdvisorName"").val())
        var cn=check_ClientName($(""#ClientName"").val())
        var ccn=check_CompanyName($(""#CompanyName"").val())
        var ci= check_IllustrationName($(""#IllustrationUniqueReference"").val())

");
            WriteLiteral(@"        
            LoadData();
        
    });

     var LoadData = function () {
        $.ajax({
            url: ""../../SuperUser/SearchIllustration"",
            type: ""POST"",
            data: {
                PartnerName: $(""#PartnerName"").val(),
                ClientName: $(""#ClientName"").val(),
                CompanyName: $(""#CompanyName"").val(),
                IllustrationUniqueReference: $(""#IllustrationUniqueReference"").val(),
                IllustrationFrom: $(""#IllustrationFrom"").val(),
                IllustrationTo: $(""#IllustrationTo"").val()
            },

            success: function (response, textStatus, jqXHR) {
                debugger;
                $('#validationerror').text("""");
                //if( $('#dvIllustration')!==undefined) $('#dvIllustration').html("""");


                
                var tbl = '<table class=""table table-striped table-bordered table-responsive-sm illustrationListTable"">';
                tbl += '<thead class=""thead-da");
            WriteLiteral(@"rk"">';
                tbl += '     <tr class=""d-flex"">';
                tbl += '         <th class=""col-md-1"" style=""padding:10px;  min-width:112px;"">Advisor Name</th>';
                tbl += '         <th class=""col-md-1""  style=""padding:10px; min-width:130px;"">Client Name</th>';
                tbl += '         <th class=""col-md-2""  style=""padding:10px; min-width:180px;"">Company Name</th>';
                tbl += '         <th class=""col-md-2""  style=""padding:10px; min-width:260px;"">Illustration Unique Reference</th>';
                tbl += '         <th class=""col-md-2""  style=""padding:10px; min-width:170px;"">Generation Date</th>';
                tbl += '         <th class=""col-md-1""  style=""padding:10px; min-width:89px;"">Status</th>';
                tbl += '      </tr>';
                tbl += '  </thead>';
                tbl += '<tbody id=""tblbody"">';
                tbl += '</tbody>';
                tbl += '</table>';



                $('#dvIllustration').html(tbl);
          ");
            WriteLiteral(@"      if (response.success == false) {
                    //$(""#validationError"").text(response.data);
                    for (var i = 0; i < response.data.length; i++) {
                        
                        $('#validationerror').append(""<br>""+response.data[i]);
                    }
                     
                }
                else {
                    $.each(response.data, function () {
                        if (this.comment == null) {
                            this.comment = """";
                        }
                        var date = this.generateDate.split(""T"")[0].split(""-"");
                        debugger
                        var deletedClass = """"
                        var status = this.status;
                        if (status == ""Deleted"") {
                            deletedClass = ""disabled-gray"";
                        }
                        
                        $("".illustrationListTable tbody"").append('<tr class=""d-flex '+dele");
            WriteLiteral(@"tedClass +'"" id=""bankDetailRow""><td class=""col-md-1"" style=""min-width:112px;"">' + this.partnerName + '</td><td class=""col-md-1"" style=""min-width:130px"">' + this.clientName + '</td><td class=""col-md-2"" style=""min-width:180px"">' + this.partnerOrganisation + '</td><td class=""col-md-2"" style=""min-width:260px"" >' + this.illustrationUniqueReference + '<input type=""hidden"" id=""item_IllustrationUniqueReference"" value=""' + this.illustrationUniqueReference + '""/></td><td class=""col-md-2"" style=""min-width:170px"">' + date[2] + ""/"" + date[1] + ""/"" + date[0] + '</td><td class=""col-md-1"" style=""min-width:89px"">' + status + '</td></tr>');
                        

                    });
                }
                $('.illustrationListTable').DataTable({
                    //  ""dom"": '<""top""i>rt<""bottom""flp><""clear"">', //for using a search in buttom
                    // ""scrollY"": ""400px"",
                    ""scrollX"": false,
                    ""scrollCollapse"": false,
                    ""paging"": true,");
            WriteLiteral(@"
                    ""searching"": false,
                    ""pageLength"": 25,
                    ""order"": [],
                    language: {
                        ""emptyTable"": ""Sorry, we couldn’t find any illustrations matching your search criteria.""
                    }
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {

            }
        });
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IllustrationListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
