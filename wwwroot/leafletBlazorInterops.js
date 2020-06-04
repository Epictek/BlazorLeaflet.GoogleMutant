window.googleMutant = {
    addGoogleMutantLayer: function (mapId, mutantLayer, objectReference) {
        const layer =  L.gridLayer.googleMutant({
                type: mutantLayer.type
            });

        window.console.log("addGoogleMutantLayer");
        addLayer(mapId, layer, layer.id);
    }
};