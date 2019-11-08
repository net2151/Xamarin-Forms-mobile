#pragma checksum "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf35205ca57243aeb93367bd45edee489511e1e7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publishers")]
    public class Publishers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3><b>Enter Publisher Information</b></h3>\r\n    <hr>\r\n    ");
            __builder.OpenComponent<BlazorApp.Shared.ServerValidations>(4);
            __builder.AddAttribute(5, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                  IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Results", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                      Results

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<span>Publisher : </span>");
                __builder2.AddContent(10, 
#nullable restore
#line 10 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                  RecordName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(11, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                      publisher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                 SavePublisher

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-12 row");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.AddMarkupContent(21, "<label class=\"col-2 font-weight-bold\">first name :</label>\r\n            ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "class", "form-control col-3");
                __builder2.AddAttribute(24, "placeholder", "publisher\'s name");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                                                                 publisher.Publisher_Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => publisher.Publisher_Name = __value, publisher.Publisher_Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddElementReferenceCapture(27, (__value) => {
#nullable restore
#line 18 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                         publisherNameTextBox = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            &nbsp;");
                __Blazor.BlazorApp.Pages.Publishers.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 19 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                            () => publisher.Publisher_Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-12 row");
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.AddMarkupContent(36, "<label class=\"col-2 font-weight-bold\">city :</label>\r\n            ");
                __Blazor.BlazorApp.Pages.Publishers.TypeInference.CreateInputSelect_1(__builder2, 37, 38, "form-control col-3", 39, 
#nullable restore
#line 24 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                      publisher.City

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => publisher.City = __value, publisher.City)), 41, () => publisher.City, 42, (__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n");
#nullable restore
#line 25 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                 if (@Cities != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                     foreach (var city in Cities)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(44, "                        ");
                    __builder3.OpenElement(45, "option");
                    __builder3.AddAttribute(46, "value", 
#nullable restore
#line 29 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                        city

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, 
#nullable restore
#line 29 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                                               city

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\r\n");
#nullable restore
#line 30 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                     
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(49, "            ");
                }
                );
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(52, @"<div class=""col-12 row"">
            <span class=""col-2""></span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
            <span>&nbsp;</span>
            <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
        </div>

    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n<br>\r\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-6");
            __builder.AddMarkupContent(57, "\r\n\r\n    ");
            __builder.AddMarkupContent(58, "<h3><b>Publishers</b></h3>\r\n\r\n    ");
            __builder.OpenElement(59, "table");
            __builder.AddAttribute(60, "class", "table");
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.AddMarkupContent(62, "<thead>\r\n            <tr>\r\n                <th>PublisherId</th>\r\n                <th>Publisher Name</th>\r\n                <th>City</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(63, "tbody");
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 61 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
             foreach (var publisher in publisherList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                ");
            __builder.OpenElement(66, "tr");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 64 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                         publisher.Pub_Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 65 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                         publisher.Publisher_Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 66 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
                         publisher.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 68 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Data\CuriousDrive\PublicProjects\BlazorApp\BlazorApp\Pages\Publishers.razor"
       

    public Publisher publisher { get; set; }
    public List<Publisher> publisherList { get; set; }
    public string[] Cities { get; set; }
    ElementReference publisherNameTextBox;

    public bool IsVisible { get; set; }
    public string RecordName { get; set; }
    public bool Results { get; set; }
    

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Cities == null)
        {
            Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

            StateHasChanged();
        }
    }

    protected override void OnInitialized()
    {
        publisher = new Publisher();
        publisherList = publisherService.GetPublishers();
    }

    private async Task SavePublisher()
    {
        Results = publisherService.SavePublisher(publisher);
        IsVisible = true;
        RecordName = publisher.Publisher_Name;

        publisher = new Publisher();

        //await JSRuntime.InvokeVoidAsync("saveMessage",publisherName, "");
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", publisherNameTextBox);
    }

    public async Task DeletePublisher(string publisherId)
    {
        var confirm = await JSRuntime.InvokeAsync<bool>("confirmDelete");

        if (confirm)
            publisherService.DeletePublisher(publisherId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Publishers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
