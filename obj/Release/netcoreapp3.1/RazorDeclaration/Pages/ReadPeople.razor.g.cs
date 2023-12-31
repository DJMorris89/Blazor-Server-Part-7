// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using SupportLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\david\source\repos\HomeWork7\BlazorApp\_Imports.razor"
using SupportLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\source\repos\HomeWork7\BlazorApp\Pages\ReadPeople.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/readpeople")]
    public partial class ReadPeople : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\david\source\repos\HomeWork7\BlazorApp\Pages\ReadPeople.razor"
       
    private List<IPersonModel> people;
    private bool showEditForm = false;
    private int idToUpdate = 0;
    private int idToDelete = 0;

    private void UpdatePerson(int id)
    {
        idToUpdate = id;
        showEditForm = true;
    }

    private async Task DeletePerson(int id)
    {
        await personData.DeletePerson(id);
        people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        idToDelete = 0;
    }

    private void HandleOnUpdate(IPersonModel person)
    {
        showEditForm = false;

        var p = people.Where(x => x.Id == person.Id).FirstOrDefault();

        if (p != null)
        {
            p.FirstName = person.FirstName;
            p.LastName = person.LastName;
            p.DateOfBirth = person.DateOfBirth;
        }
    }

    protected override async Task OnParametersSetAsync()
    {
        people = await personData.ReadPeople();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonDataService personData { get; set; }
    }
}
#pragma warning restore 1591
