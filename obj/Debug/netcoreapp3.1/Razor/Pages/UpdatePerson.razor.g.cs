#pragma checksum "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c5e6a4d6af23d3b89008577a069fdfafb42dc7"
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
#line 1 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using SupportLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\david\Desktop\HomeWork7\BlazorApp\_Imports.razor"
using SupportLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class UpdatePerson : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 3 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
                      person

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<label>Id</label>\r\n            ");
                __builder2.OpenElement(13, "span");
#nullable restore
#line 9 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
__builder2.AddContent(14, person.Id);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label>First Name</label>\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", (object)("form-control"));
                __builder2.AddAttribute(23, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
                                    person.FirstName

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.FirstName = __value, person.FirstName)))));
                __builder2.AddAttribute(25, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.FirstName)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<label>Last Name</label>\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", (object)("form-control"));
                __builder2.AddAttribute(34, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 17 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
                                    person.LastName

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(35, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.LastName = __value, person.LastName)))));
                __builder2.AddAttribute(36, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.LastName)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.AddMarkupContent(42, "<label>Date of Birth</label>\r\n            ");
                global::__Blazor.BlazorApp.Pages.UpdatePerson.TypeInference.CreateInputDate_0(__builder2, 43, 44, "form-control", 45, 
#nullable restore
#line 21 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
                                    person.DateOfBirth

#line default
#line hidden
#nullable disable
                , 46, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.DateOfBirth = __value, person.DateOfBirth)), 47, () => person.DateOfBirth);
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<button class=\"btn btn-primary\" type=\"submit\">Update Person</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\david\Desktop\HomeWork7\BlazorApp\Pages\UpdatePerson.razor"
       
    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public EventCallback<IPersonModel> OnUpdate { get; set; }

    private IPersonModel person = new DisplayPersonModel();

    private async Task HandleValidSubmit()
    {
        await personData.UpdatePerson(person);
        await OnUpdate.InvokeAsync(person);
    }

    protected override async Task OnParametersSetAsync()
    {
        var p = await personData.ReadPeople(Id);

        person.Id = p.Id;
        person.FirstName = p.FirstName;
        person.LastName = p.LastName;
        person.DateOfBirth = p.DateOfBirth;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonDataService personData { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.UpdatePerson
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
