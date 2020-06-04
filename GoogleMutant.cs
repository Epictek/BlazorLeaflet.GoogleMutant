using Microsoft.JSInterop;
using System;
using System.Drawing;
using System.Threading.Tasks;
using BlazorLeaflet.GoogleMutant.Models;

namespace BlazorLeaflet.GoogleMutant
{
    public static class GoogleMutant
    {
        private static readonly string _BaseObjectContainer = "window.googleMutant";

        public static ValueTask AddGoogleMutantLayer(this Map map, IJSRuntime jsRuntime, MutantLayer layer) =>
            jsRuntime.InvokeVoidAsync($"{_BaseObjectContainer}.addGoogleMutantLayer", map.Id, layer,
                DotNetObjectReference.Create(layer));

    }
}