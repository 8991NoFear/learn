<template>
  <MglMap
    class="mapboxgl-container"
    :accessToken="accessToken"
    :mapStyle="mapStyle"
    @load="onMapLoad"
    :maxBounds="mapBounds"
    v-if="dataFetched"
  >
    <MglFullscreenControl />
    <MglNavigationControl />
    <MglScaleControl />
    <MglGeojsonLayer
      :sourceId="geoJsonLayer.source"
      :source="geoJsonSource"
      :layerId="geoJsonLayer.id"
      :layer="geoJsonLayer"
      :before="geoJsonLayer.beforeLayer"
    />
  </MglMap>
</template>

<script>
import Mapbox from "mapbox-gl";
import "mapbox-gl/dist/mapbox-gl.css";
import { mapGetters } from "vuex";

import {
  MglMap,
  MglNavigationControl,
  MglFullscreenControl,
  MglScaleControl,
  MglGeojsonLayer,
} from "vue-mapbox";

export default {
  components: {
    MglMap,
    MglNavigationControl,
    MglFullscreenControl,
    MglScaleControl,
    MglGeojsonLayer,
  },
  data() {
    return {
      accessToken:
        "pk.eyJ1IjoiODk5MW5vZmVhciIsImEiOiJja3YzOWltM3cxZHBjMnVxMXZ1MjFvZzl1In0.INARVM0hWYBasZThvVobhQ",
      mapStyle: "mapbox://styles/8991nofear/ckv6eip4d7jp314o319sxfgzs",
      geoJsonLayer: {
        id: "vn_layer",
        source: "vn_src",
        type: "fill",
        paint: {
          "fill-color": [
            // gg Layer Properties (depend on type above)
            "step", // gg Mapbox Expressions
            ["get", "Dan_So"],
            "#95D5B2",
            100000, // < 100000
            "#74C69D",
            200000, // < 200000
            "#52B788",
            300000, // < 300000
            "#40916C", // >= 400000
          ],
        },
        beforeLayer: "diaphanhuyen-line",
      },
      mapBounds: [
        [95.4, 5.5], // southeast 5.299,
        [121.6, 24.9], // northwest
      ],
    };
  },
  computed: mapGetters(["geoJsonSource", "dataFetched"]),
  created() {
    this.mapbox = Mapbox;
    this.$store.dispatch("fetchSource");
  },
  methods: {
    async onMapLoad(event) {
      const asyncActions = event.component.actions;

      await asyncActions.flyTo({
        center: [108.20623, 16.047079], // danang
        zoom: 4.5,
        speed: 1,
      });
    },
  },
};
</script>

<style>
.mapboxgl-ctrl-bottom-left,
.mapboxgl-ctrl-bottom-right {
  display: none !important;
}

@media (min-width: 0) {
  .mapboxgl-container {
    width: 100%;
    height: 330px;
  }
}

@media (min-width: 576px) {
  .mapboxgl-container {
    width: 100%;
    height: 550px;
  }
}
</style>