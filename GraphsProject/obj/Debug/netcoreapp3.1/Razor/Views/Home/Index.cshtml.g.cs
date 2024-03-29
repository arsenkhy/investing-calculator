#pragma checksum "/Users/arsen/Desktop/Projects/investing-calculator/GraphsProject/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9663430d9f17706499fdc4e94dd1ce20674a065"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/arsen/Desktop/Projects/investing-calculator/GraphsProject/Views/_ViewImports.cshtml"
using GraphsProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arsen/Desktop/Projects/investing-calculator/GraphsProject/Views/_ViewImports.cshtml"
using GraphsProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9663430d9f17706499fdc4e94dd1ce20674a065", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184341e7675e7c28edc427bea324a0462cd21257", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "annually", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "monthly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return SendRequest(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("my_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/arsen/Desktop/Projects/investing-calculator/GraphsProject/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9663430d9f17706499fdc4e94dd1ce20674a0655780", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Investment Calculator</title>

    <!-- css -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
          integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

    <style>
        /* Chrome, Safari, Edge, Opera */
        input::-webkit-outer-spin-button,
        input::-webkit-inner-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }

        /* Firefox */
        input[type=number] {
            -moz-appearance: textfield;
        }
    </style>

    <!-- js -->
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""
            integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n""
            crossorigin=""anonymous""></script>");
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""
            integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo""
            crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""
            integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6""
            crossorigin=""anonymous""></script>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9663430d9f17706499fdc4e94dd1ce20674a0658296", async() => {
                WriteLiteral("\r\n\r\n    <section>\r\n\r\n        <div class=\"py-5\">\r\n            <h1 class=\"text-primary\">Investment Calculator</h1>\r\n        </div>\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 1735, "\"", 1743, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9663430d9f17706499fdc4e94dd1ce20674a0658876", async() => {
                    WriteLiteral(@"
                <div class=""d-flex flex-row justify-content-around"">
                    <div class=""form-group"">
                        <label class=""form-label"">Starting Amount:</label>
                        <br>
                        <input type=""number"" value=""10000"" name=""starting"" id=""starting"" class=""form-control"" min=""0"" max=""1000000"">
                    </div>

                    <div class=""form-group"">
                        <label class=""form-label"">Additional Contribution:</label>
                        <br>
                        <div class=""row"">
                            <input type=""number"" value=""100"" name=""contribution"" id=""contribution"" class=""form-control col-6""
                                   min=""0"" max=""100000"">
                            <select name=""period"" id=""period"" class=""form-control col-6"">
                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9663430d9f17706499fdc4e94dd1ce20674a06510082", async() => {
                        WriteLiteral("Annually");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9663430d9f17706499fdc4e94dd1ce20674a06511388", async() => {
                        WriteLiteral("Monthly");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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

                    <div class=""form-group"">
                        <label class=""form-label"">Rate of Return:</label>
                        <br>
                        <input type=""number"" value=""10"" name=""return_rate"" id=""return_rate"" class=""form-control"" min=""0"" max=""100"">
                    </div>

                    <div class=""form-group"">
                        <label class=""form-label"">Years to Grow:</label>
                        <br>
                        <input type=""number"" value=""10"" name=""years"" id=""years"" class=""form-control"" min=""0"" max=""50"">
                    </div>
                </div>

                <div class=""text-center"">
                    <button type=""submit"" class=""btn btn-primary"">Calculate</button>
                </div>

            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>

        <div class=""py-5 text-center"">
            This Investment will be worth <h3 class=""text-primary"" id=""worth""> $47,555 </h3>
        </div>

    </section>

    <section>
        <div class=""row w-100"">
            <div class=""col-md-8"" id=""barParent"">
                <canvas id=""bar""></canvas>
            </div>
            <div class=""col-md-4"" id=""pieParent"">
                <canvas id=""pie""></canvas>
            </div>
        </div>
    </section>

    <section>
        <div class=""py-5"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">Year</th>
                        <th scope=""col"">Starting Amount</th>
                        <th scope=""col"">Annual Contribution</th>
                        <th scope=""col"">Total Contribution</th>
                        <th scope=""col"">Interest Earned</th>
                        <th scope=""col"">Total Interest Earned</th>
       ");
                WriteLiteral(@"                 <th scope=""col"">End Balance</th>
                    </tr>
                </thead>
                <tbody id=""tab"">
                    <tr>
                        <td>2021</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$1,200</td>
                        <td>$1,104</td>
                        <td>$1,104</td>
                        <td>$12,304</td>
                    </tr>
                    <tr>
                        <td>2022</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$2,400</td>
                        <td>$1,345</td>
                        <td>$2,449</td>
                        <td>$14,849</td>
                    </tr>
                    <tr>
                        <td>2023</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$3,600</td>
                 ");
                WriteLiteral(@"       <td>$1,611</td>
                        <td>$4,060</td>
                        <td>$17,660</td>
                    </tr>
                    <tr>
                        <td>2024</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$4,800</td>
                        <td>$1,906</td>
                        <td>$5,966</td>
                        <td>$20,766</td>
                    </tr>
                    <tr>
                        <td>2025</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$6,000</td>
                        <td>$2,231</td>
                        <td>$8,197</td>
                        <td>$24,197</td>
                    </tr>
                    <tr>
                        <td>2026</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$7,200</td>
                     ");
                WriteLiteral(@"   <td>$2,590</td>
                        <td>$10,787</td>
                        <td>$27,987</td>
                    </tr>
                    <tr>
                        <td>2027</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$8,400</td>
                        <td>$2,987</td>
                        <td>$13,774</td>
                        <td>$32,174</td>
                    </tr>
                    <tr>
                        <td>2028</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$9,600</td>
                        <td>$3,426</td>
                        <td>$17,200</td>
                        <td>$36,800</td>
                    </tr>
                    <tr>
                        <td>2029</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$10,800</td>
                     ");
                WriteLiteral(@"   <td>$3,910</td>
                        <td>$21,110</td>
                        <td>$41,910</td>
                    </tr>
                    <tr>
                        <td>2030</td>
                        <td>$10,000</td>
                        <td>$1,200</td>
                        <td>$12,000</td>
                        <td>$4,445</td>
                        <td>$25,555</td>
                        <td>$47,555</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </section>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.min.js""></script>
<script>
    function SendRequest(e) {
        e.preventDefault();
        var xhttp = new XMLHttpRequest();
        var return_rate = document.getElementById('return_rate').value;
        var period = document.getElementById('period').value;
        var years = document.getElementById('years').value;
        var contribution = document.getElementById('contribution').value;
        var starting = document.getElementById('starting').value;
        xhttp.open(""GET"", ""../Home/Calculate?years="" + years + ""&contribution="" + contribution +
            ""&starting="" + starting + ""&period="" + period + ""&return_rate="" + return_rate, true);
        xhttp.send();

        xhttp.onreadystatechange = function (data) {
            var response = JSON.parse(this.responseText);
            var mytable = """";
            for (var row of response) {
                mytable += ""<tr>"" + ""<td scope='row'>"" + row.year +
  ");
            WriteLiteral(@"                  ""</td>"" + ""<td>"" + row.startAmount + ""</td>"" + ""<td>"" + row.contribution +
                    ""</td>"" + ""<td>"" + row.totalContribution + ""</td>"" + ""<td>"" +
                    Math.round(row.interest) + ""</td>"" + ""<td>"" + Math.round(row.totalInterest) +
                    ""</td>"" + ""<td>"" + Math.round(row.total) + ""</td>"" + ""</tr>"";
            }
            document.getElementById(""tab"").innerHTML = mytable;
            updateChart(response);
            //if (this.readyState == 2 && this.status == 200) {
            //
            //}
        };
    }

    var barchart = new Chart(bar, {
        type: 'bar',
        data: {
            labels: ['2021', '2022', '2023', '2024', '2025', '2026', '2027', '2028', '2029', '2030'], // responsible for how many bars are gonna show on the chart
            // create 12 datasets, since we have 12 items
            // data[0] = labels[0] (data for first bar - 'Standing costs') | data[1] = labels[1] (data for second bar - 'Running co");
            WriteLiteral(@"sts')
            // put 0, if there is no data for the particular bar
            datasets: [{
                label: 'Starting Amount',
                data: [10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000],
                backgroundColor: 'rgb(57, 192, 251)'
            }, {
                label: 'Total Contributions',
                data: [1104, 2449, 3600, 4800, 6000, 7200, 8400, 9600, 10800, 12000],
                backgroundColor: 'rgb(109, 211, 133)'
            }, {
                label: 'Total Interest Earned',
                data: [1200, 2400, 4060, 5966, 8197, 10787, 13774, 17200, 21110, 25555],
                backgroundColor: 'rgb(255, 208, 50)'
            },]
        },
        options: {
            responsive: true,
            legend: {
                display: false,
                position: 'right' // place legend on the right side of chart
            },
            scales: {
                xAxes: [{
                    stacked: true /");
            WriteLiteral(@"/ this should be set to make the bars stacked
                }],
                yAxes: [{
                    stacked: true // this also..
                }]
            }
        }
    });


    var piechart = new Chart(pie, {
        type: 'pie',
        data: {
            labels: ['Starting Amount', 'Total Contributions', 'Total Interest Earned'],
            datasets: [{
                label: 'Investment by the end of Last Year',
                data: [10000, 12000, 25555],
                backgroundColor: ['rgb(57, 192, 251)', 'rgb(109, 211, 133)', 'rgb(255, 208, 50)']
            },]
        },
        options: {
            responsive: true,
            legend: {
                position: 'right' // place legend on the right side of chart
            },
            scales: {
                xAxes: [{
                    stacked: true // this should be set to make the bars stacked
                }],
                yAxes: [{
                    stacked: true // this al");
            WriteLiteral(@"so..
                }]
            }
        }
    });
    
    function updateChart(data) {

        barchart.data.labels = [];
        barchart.data.datasets = [];
        barchart.update();

        for (var row of data) {

            barchart.data.labels.push(row.year);
        }

        contribution = []
        interest = []
        starting = []
        pie = []
        total = 0
        for (var row of data) {
            pie = []
            contribution.push(Math.round(row.totalContribution));
            interest.push(Math.round(row.totalInterest));
            starting.push(Math.round(row.startAmount));
            pie.push(Math.round(row.totalContribution));
            pie.push(Math.round(row.totalInterest));
            pie.push(Math.round(row.startAmount));
            total = Math.round(row.total);
        }

        mydataset = [{
            label: 'Starting Amount',
            data: starting,
            backgroundColor: 'rgb(57, 192, 251)'
        ");
            WriteLiteral(@"}, {
            label: 'Total Contribution',
            data: contribution,
                backgroundColor: 'rgb(109, 211, 133)'
        }, {
            label: 'Total Interest',
            data: interest,
                backgroundColor: 'rgb(255, 208, 50)'
        },]

        barchart.data.datasets.push(mydataset[0]);
        barchart.data.datasets.push(mydataset[1]);
        barchart.data.datasets.push(mydataset[2]);

        barchart.update();

        piechart.data.labels = ['Contribution', 'Interest', 'Starting'];
        piechart.data.datasets = [];
        piechart.update();

        piedata = {
            label: 'Investment Balance Last Year',
            data: pie,
            backgroundColor: ['rgb(109, 211, 133)', 'rgb(255, 208, 50)', 'rgb(57, 192, 251)']
        }

        piechart.data.datasets.push(piedata);
        piechart.update();

        document.getElementById('worth').innerHTML = '$'+total;
        
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
