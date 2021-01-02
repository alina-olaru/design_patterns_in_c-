#pragma checksum "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088332ed38a6fad89a87e13e89338e5c424005f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Forecast), @"mvc.1.0.view", @"/Views/Home/Forecast.cshtml")]
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
#line 1 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\_ViewImports.cshtml"
using DecoratorDesignPattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\_ViewImports.cshtml"
using DecoratorDesignPattern.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"088332ed38a6fad89a87e13e89338e5c424005f2", @"/Views/Home/Forecast.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1c46b379c9c39ab12dcbffe35ead7a5952f1eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Forecast : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DecoratorDesignPattern.WeatherInterface.LocationForecast>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
  
    ViewData["Title"] = "Forecast";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>Forecast for ");
#nullable restore
#line 7 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
            Write(Model.Location.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n\n<div class=\"row\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "088332ed38a6fad89a87e13e89338e5c424005f24434", async() => {
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""col font-weight-bold"">
                <label id=""forecastCityLabel"" for=""forecastCity"" class=""col-form-label"">Get Forecast</label>
            </div>
            <div class=""col"">
                <input id=""forecastCity"" name=""location"" class=""form-control"" type=""text"" placeholder=""City name"" />
            </div>
            <div class=""col"">
                <button type=""submit"" id=""getForecast"" class=""btn btn-primary"">Get Forecast</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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

<div class=""row"" style=""margin-top: 10px"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Forecast Time
                </th>
                <th>
                    Conditions
                </th>
                <th>
                    Temp (F)
                </th>
                <th>
                    Humidity (%)
                </th>
                <th>
                    Barometer (in/Hg)
                </th>
                <th>
                    Wind (mph)
                </th>
                <th>
                    Cloud Cover (%)
                </th>
                <th>
                    Rain
                </th>
                <th>
                    Snow
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 60 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
             foreach (var item in Model.Forecasts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 64 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.ForecastTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 67 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.Conditions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 70 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.Temperature.ToString("#0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("&deg;\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 73 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.Humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 76 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.Pressure.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 79 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.WindDirection.Abbreviation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 79 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                                                    Write(item.WindSpeed.ToString("#0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 82 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.CloudCover);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 85 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.ExpectedRainfall.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 88 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
                   Write(item.ExpectedSnowfall.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                </tr>\n");
#nullable restore
#line 92 "C:\Alina\courses - for git\.net\designPatterns\structural\Decorator Design Pattern - Weather app demo\DecoratorDesignPattern\Views\Home\Forecast.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DecoratorDesignPattern.WeatherInterface.LocationForecast> Html { get; private set; }
    }
}
#pragma warning restore 1591
