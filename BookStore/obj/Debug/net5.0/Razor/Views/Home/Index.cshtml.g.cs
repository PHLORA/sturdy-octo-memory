#pragma checksum "E:\диплом asp.net core\BookStore\BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1237554a820be2f25c11adb94bc2b5df89a3de"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1237554a820be2f25c11adb94bc2b5df89a3de", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\диплом asp.net core\BookStore\BookStore\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная страница";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .con {
        width: 1100px;
        margin-right: auto;
        margin-left: auto;
        margin-top: 20px;
    }

    .page__side {
        float: left;
        position: sticky;
    }

    .filter {
        border: 4px solid #27ae61;
        width: 270px;
    }

    .filter__title {
        padding: 25px 15px 5px 15px;
        color: #27ae61;
        font-size: 24px;
        font-weight: 700;
        text-transform: uppercase;
        letter-spacing: 0px;
    }

    .section-filter {
        padding: 20px 15px;
        border-bottom: 1px solid #27ae61;
    }

    .section-filter__title {
        color: #27ae61;
        font-size: 16px;
        font-weight: 700;
        line-height: 22px;
        margin: 0px 0px 15px 0;
        min-height: 30px;
        display: flex;
        align-items: center;
    }

    .values-price-filter {
        display: flex;
        margin: 0px -15px;
    }

    .values-price-filter__column {
        padding: 0px 15px");
            WriteLiteral(@";
        flex: 0 1 50%;
        display: flex;
        align-items: center;
    }

    .values-price-filter__label {
        color: #999999;
        font-size: 14px;
        font-weight: 300;
    }

    .values-price-filter__input {
        flex: 1 1 auto;
        padding: 0px 0px 0px 10px;
    }

    .price-input {
        font-size: 14px;
        height: 20px;
        border: 1px solid #27ae61;
        width: 80%;
        outline: none;
    }

    .section-filter__checkbox {
        display: block;
        margin: 0px 0px 15px 0px;
    }

    .checkbox__input {
        position: absolute;
        width: 0;
        height: 0;
        opacity: 0;
        visibility: hidden;
    }

        .checkbox__input:checked + .checkbox__text:before {
            border: 2px solid #27ae61;
        }

        .checkbox__input:checked + .checkbox__text:after {
            content: """";
            position: absolute;
            left: 3px;
            top: 3px;
            wid");
            WriteLiteral(@"th: 9px;
            height: 9px;
            background-color: #27ae61;
        }

    .checkbox__text {
        display: inline-flex;
        align-items: center;
        position: relative;
        font-size: 14px;
        line-height: calc(15/12);
        cursor: pointer;
        font-weight: 500;
    }

        .checkbox__text::before {
            content: """";
            align-self: flex-start;
            margin: 0px 14px 0px 0px;
            flex: 0 0 15px;
            left: 0;
            top: 0;
            width: 15px;
            height: 15px;
            background: #fff;
            border: 2px solid #dadada;
        }

    .filter__footer {
        display: flex;
        padding: 5px;
        justify-content: space-between;
    }

    .form__btn {
        display: inline-flex;
        padding: 0px 25px;
        justify-content: center;
        align-items: center;
        transition: all 0.3s ease 0s;
        border: none;
        height: 39px;
       ");
            WriteLiteral(@" font-size: 12px;
        font-weight: 900;
        line-height: 18px;
        text-transform: uppercase;
    }

    .btn_orange {
        background-color: #f68038;
        color: white;
        width: 100%;
    }

        .btn_orange:hover {
            background-color: #d05700;
        }

        .btn_orange:focus {
            outline: none;
        }

    .btn_grey {
        color: #666666;
        background-color: #e6e6e6;
    }

        .btn_grey:hover {
            background-color: #a1a1a1;
        }

        .btn_grey:focus {
            outline: none;
        }

    .catalog {
        overflow: auto;
        padding-left: 40px;
    }

    .catalog__title {
        color: black;
        font-size: 30px;
        margin-bottom: 20px;
        text-transform: uppercase;
        font-weight: 600;
    }

    .actions-catalog {
        padding: 10px 0px 10px 0px;
        background: #f3efea;
        display: flex;
        align-items: center;
        bor");
            WriteLiteral(@"der: 1px solid #d7d7d7;
    }

    .order-catalog {
        display: flex;
        align-items: center;
        justify-content: right;
        margin-left: auto;
        margin-right: 25px;
    }

    .order-catalog__label {
        color: black;
        font-weight: 700;
        margin: 0px 10px 0 10px;
        float: right;
    }

    .view-catalog {
        display: flex;
    }

    .catalog__actions {
        margin: 0px 0px 15px 0px;
    }

    .items-products__column {
        border: 1px solid #dee0ee;
        width: 236px;
        height: 495px;
        margin-bottom: 15px;
        margin-right: 27px;
    }

        .items-products__column:hover {
            border: 1px solid #27ae61;
        }

    .item-product {
        position: relative;
    }

    .item-product__labels {
        position: absolute;
        left: 15px;
        top: 15px;
    }

    .item-product__image {
        padding-top: 20px;
        height: 178px;
        display: table;
            WriteLiteral(@"
        margin-left: auto;
        margin-right: auto;
    }

    img {
        max-width: 100%;
        height: 275px;
    }

    .item-product__body {
        margin-left: 20px;
    }

    .item-product__title {
        text-decoration: underline;
        color: black;
        font-size: 14px;
        display: -webkit-box;
        -webkit-line-clamp: 1;
        -webkit-box-orient: vertical;
        overflow: hidden;
    }

        .item-product__title:hover {
            color: #27ae61;
            text-decoration: none;
        }

    .item-product__author {
        margin-top: 10px;
    }

    .item-product__footer {
        margin-top: 40px;
    }

    .item-product_price {
        color: black;
        font-weight: 700;
        font-size: 22px;
    }

    .item-product__add {
        float: right;
        margin-right: 20px;
        color: white;
        margin-top: 10px;
        text-transform: uppercase;
        background-color: #27ae61;
        font-");
            WriteLiteral(@"size: 14px;
        border-radius: 7px;
        border: 2px solid #27ae61;
        padding: 2px 20px 2px 20px;
        outline: none;
    }

        .item-product__add:hover {
            background-color: black;
            border-color: black;
        }

        .item-product__add:focus {
            background-color: black;
            border-color: black;
            outline: none;
        }

    select:focus {
        outline: none;
    }

    .count__books {
        margin-left: 25px;
        font-weight: 700;
    }
</style>

<div class=""con"">
    <aside class=""page__side"">
        <form action=""#"" id=""tags"" class=""filter"">
            <div class=""filter__title"">Фильтр товаров</div>
            <div class=""filter__body"">
                <div class=""filter__section section-filter"" id=""genres"">
                    <div class=""section-filter__title"">Жанр:</div>
                    <div class=""section-filter__body"">
                        <label class=""section-filter__ch");
            WriteLiteral(@"eckbox"">
                            <input type=""checkbox"" id=""genre"" value=""Роман"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Роман</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""genre"" value=""Фантастика"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Фантастика</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""genre"" value=""Детектив"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Детектив</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""genre"" value=""Компьютерная литература"" class=""checkbox__input"" />
            ");
            WriteLiteral(@"                <span class=""checkbox__text""><span>Компьютерная литература</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""genre"" value=""Психология"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Психология</span></span>
                        </label>
                    </div>
                </div>
                <div class=""filter__section section-filter"">
                    <div class=""section-filter__title"">Цена (грн.):</div>
                    <div class=""section-filter__body"">
                        <div class=""price-filter"">
                            <div class=""price-filter__values values-price-filter"">
                                <div class=""values-price-filter__column"">
                                    <div class=""values-price-filter__label"">от</div>
                                    <div class=""values-price");
            WriteLiteral(@"-filter__input"">
                                        <input type=""text"" id=""price_start"" class=""price-input"" />
                                    </div>
                                </div>
                                <div class=""values-price-filter__column"">
                                    <div class=""values-price-filter__label"">до</div>
                                    <div class=""values-price-filter__input"">
                                        <input type=""text"" id=""price_end"" class=""price-input"" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""filter__section section-filter"">
                    <div class=""section-filter__title"">Язык:</div>
                    <div class=""section-filter__body"" id=""languages"">
                        <label class=""section-filter__checkbox"">
              ");
            WriteLiteral(@"              <input type=""checkbox"" id=""language"" value=""Английский"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Английский</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""language"" value=""Русский"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Русский</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""language"" value=""Украинский"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Украинский</span></span>
                        </label>
                    </div>
                </div>
                <div class=""filter__section section-filter"" id=""covers"">
                    <div class=""section-filter__title"">Тип переплета:</div>
    ");
            WriteLiteral(@"                <div class=""section-filter__body"">
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""cover"" value=""Мягкий"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Мягкий</span></span>
                        </label>
                        <label class=""section-filter__checkbox"">
                            <input type=""checkbox"" id=""cover"" value=""Твердый"" class=""checkbox__input"" />
                            <span class=""checkbox__text""><span>Твердый</span></span>
                        </label>
                    </div>
                </div>

            </div>
            <div class=""filter__footer"">
                <button type=""submit"" id=""search"" class=""form__btn btn_orange"">Подобрать</button>
            </div>
        </form>
    </aside>
    <div class=""catalog"">
        <h1 class=""catalog__title"">Список товаров</h1>
        <div class=""catalog__actions acti");
            WriteLiteral(@"ons-catalog"">
            <div class=""count__books"" id=""bc""> </div>
            <div class=""actions-catalog_order order-catalog"">
                <div class=""order-catalog__label"">Сортировка:</div>
                <div class=""order-catalog__select"">
                    <select name=""form[] select"" class=""form form-select"" id=""sort"">
                        <option selected=""selected"">По умолчанию</option>
                        <option>Цена (по убыванию)</option>
                        <option>Цена (по возрастанию)</option>
                        <option>По названию(А-Я)</option>
                        <option>По названию(Я-А)</option>
                    </select>
                </div>
            </div>
        </div>
        <div id=""books"">

        </div>
");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1237554a820be2f25c11adb94bc2b5df89a3de16862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(""#search_l"").on('input', function () {
        $(""#search"").click();

    });
    $('#sort').on('input', function () {
        console.log(1);
        $(""#search"").click();
    });
    $(document).ready(function () {
        $(""#search"").click();
    });
    $(""#search"").on('click', function () {
        var languageList = new Array(), language = document.forms['tags']['language'];
        for (var i = 0, elm; elm = language[i]; i++) {
            if (elm.checked) {
                languageList.push(elm.value);
            }
        }
        var genresList = new Array(), genre = document.forms['tags']['genre'];
        for (var i = 0, elm; elm = genre[i]; i++) {
            if (elm.checked) {
                genresList.push(elm.value);
            }
        }
        var coverList = new Array(), cover = document.forms['tags']['cover'];
        for (var i = 0, elm; elm = cover[i]; i++) {
            if (elm.checked) {
                coverList.push(elm.value);
 ");
            WriteLiteral(@"           }
        }
        var sort_l = document.getElementById(""sort"").value;
        let search_l = document.getElementById(""search_l"").value;
        let price_st = document.getElementById(""price_start"").value;
        let price_end = document.getElementById(""price_end"").value;


        $.ajax({
            host: 'localhost',
            type: 'POST',
            url: '/Home/BooksList',
            data: { genres: genresList, languages: languageList, cover: coverList, sort: sort_l, searchLine: search_l,ps:price_st,pe:price_end },
            success: function (data) {
                $(""#books"").html(data);
            },
            complete: function () {
                var value = document.getElementById(""books_count"").value;
                document.getElementById(""bc"").textContent = (""Найдено книг: "" + value);
            }
        });

    });
</script>");
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