#pragma checksum "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c5cba5ffce021188d9bd77b2360d02b6a2f3f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_DishesList), @"mvc.1.0.view", @"/Views/Dish/DishesList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dish/DishesList.cshtml", typeof(AspNetCore.Views_Dish_DishesList))]
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
#line 1 "D:\Beta2.2.8\Canteen\Canteen\Views\_ViewImports.cshtml"
using Canteen;

#line default
#line hidden
#line 2 "D:\Beta2.2.8\Canteen\Canteen\Views\_ViewImports.cshtml"
using Canteen.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c5cba5ffce021188d9bd77b2360d02b6a2f3f4", @"/Views/Dish/DishesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95fc556730a98f139cfbd9553ca7344c2e2d668", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_DishesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
 foreach (Dish i in Model) // карточка блюда 
{

#line default
#line hidden
            BeginContext(71, 330, true);
            WriteLiteral(@"<div class=""col-lg-6 col-md-6 col-sm-6"">
    <div class=""product"">
        <div class=""product__inner"">
            <div class=""pro__thumb"">
                <a data-toggle=""modal"" data-target=""#productModal"" title=""Quick View"" class=""quick-view modal-view detail-link"" href=""#"">
                    <img class=""product_image""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 401, "\"", 413, 1);
#line 10 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 407, i.Img, 407, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(414, 191, true);
            WriteLiteral(" alt=\"product images\">\r\n                </a>\r\n            </div>\r\n            <div class=\"product__hover__info\">\r\n                <ul class=\"product__action\">\r\n                    <a href=\"\">");
            EndContext();
            BeginContext(606, 9, false);
#line 15 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                          Write(i.Calorie);

#line default
#line hidden
            EndContext();
            BeginContext(615, 82, true);
            WriteLiteral(" калорий (100 гр)</a>\r\n                    <br />\r\n                    <a href=\"\">");
            EndContext();
            BeginContext(698, 9, false);
#line 17 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                          Write(i.Protein);

#line default
#line hidden
            EndContext();
            BeginContext(707, 73, true);
            WriteLiteral("% белков</a>\r\n                    <br />\r\n                    <a href=\"\">");
            EndContext();
            BeginContext(781, 5, false);
#line 19 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                          Write(i.Fat);

#line default
#line hidden
            EndContext();
            BeginContext(786, 72, true);
            WriteLiteral("% жиров</a>\r\n                    <br />\r\n                    <a href=\"\">");
            EndContext();
            BeginContext(859, 14, false);
#line 21 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                          Write(i.Carbohydrate);

#line default
#line hidden
            EndContext();
            BeginContext(873, 167, true);
            WriteLiteral("% углеводов</a>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"product__details\">\r\n            <h1 class=\"float-left-style food_name\">");
            EndContext();
            BeginContext(1041, 7, false);
#line 26 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                              Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 155, true);
            WriteLiteral("</h1>\r\n            <!--                                                         <h3 class=\"price\">Цена</h3>\r\n             -->\r\n            <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1203, "\"", 1215, 2);
            WriteAttributeValue("", 1208, "t_", 1208, 2, true);
#line 29 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 1210, i.Id, 1210, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1216, 83, true);
            WriteLiteral(">\r\n                <div class=\"col-sm-9\">\r\n                    <div class=\"tabs\">\r\n");
            EndContext();
#line 32 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                         foreach (SizePrice j in @i.SizePrice)
                        {

#line default
#line hidden
            BeginContext(1390, 47, true);
            WriteLiteral("                            <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1437, "\"", 1455, 2);
            WriteAttributeValue("", 1444, "inset_", 1444, 6, true);
#line 34 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 1450, i.Id, 1450, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1456, 13, true);
            WriteLiteral(" data-price=\"");
            EndContext();
            BeginContext(1470, 7, false);
#line 34 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                                                          Write(j.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1477, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1478, "\"", 1488, 1);
#line 34 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 1483, j.Id, 1483, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1489, "\"", 1502, 1);
#line 34 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 1497, i.Id, 1497, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1503, 48, true);
            WriteLiteral("\r\n                                   data-size=\"");
            EndContext();
            BeginContext(1552, 6, false);
#line 35 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                         Write(j.Size);

#line default
#line hidden
            EndContext();
            BeginContext(1558, 38, true);
            WriteLiteral("\">\r\n                            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1596, "\"", 1607, 1);
#line 36 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 1602, j.Id, 1602, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1608, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1610, 6, false);
#line 36 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                          Write(j.Size);

#line default
#line hidden
            EndContext();
            BeginContext(1616, 12, true);
            WriteLiteral(" г</label>\r\n");
            EndContext();
#line 37 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                        }

#line default
#line hidden
            BeginContext(1655, 93, true);
            WriteLiteral("\r\n                        <br />\r\n                        <br />\r\n                        <h3");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1748, "\"", 1764, 2);
            WriteAttributeValue("", 1753, "price_", 1753, 6, true);
#line 41 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
WriteAttributeValue("", 1759, i.Id, 1759, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1765, 212, true);
            WriteLiteral(" class=\"price text-left\" style=\"margin-left: 5%;\"></h3>\r\n                    </div>\r\n                </div>\r\n                <h2><a title=\"Add TO Cart\" href=\"#buy\">\r\n                    <span id=\"none\" data-img=\"");
            EndContext();
            BeginContext(1978, 5, false);
#line 45 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                         Write(i.Img);

#line default
#line hidden
            EndContext();
            BeginContext(1983, 11, true);
            WriteLiteral("\" data-pr=\"");
            EndContext();
            BeginContext(1995, 9, false);
#line 45 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                                          Write(i.Protein);

#line default
#line hidden
            EndContext();
            BeginContext(2004, 12, true);
            WriteLiteral("\" data-clr=\"");
            EndContext();
            BeginContext(2017, 9, false);
#line 45 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                                                                Write(i.Calorie);

#line default
#line hidden
            EndContext();
            BeginContext(2026, 12, true);
            WriteLiteral("\" data-fat=\"");
            EndContext();
            BeginContext(2039, 5, false);
#line 45 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                                                                                      Write(i.Fat);

#line default
#line hidden
            EndContext();
            BeginContext(2044, 38, true);
            WriteLiteral("\"\r\n                         data-crb=\"");
            EndContext();
            BeginContext(2083, 14, false);
#line 46 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                              Write(i.Carbohydrate);

#line default
#line hidden
            EndContext();
            BeginContext(2097, 14, true);
            WriteLiteral("\" data-title=\"");
            EndContext();
            BeginContext(2112, 7, false);
#line 46 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
                                                           Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2119, 230, true);
            WriteLiteral("\" data-price=\"none\" data-size=\"none\"\r\n                          class=\"ti-shopping-cart float-left-style\">\r\n                    Купить\r\n                    </span></a></h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 54 "D:\Beta2.2.8\Canteen\Canteen\Views\Dish\DishesList.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
