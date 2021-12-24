<template>
  <MglMap
    class="mapboxgl-container"
    :accessToken="accessToken"
    :mapStyle="mapStyle"
    @load="onMapLoad"
  >
    <MglFullscreenControl />
    <MglNavigationControl />
    <MglScaleControl />
  </MglMap>
</template>

<script>
import Mapbox from "mapbox-gl";
import "mapbox-gl/dist/mapbox-gl.css";

import {
  MglMap,
  MglNavigationControl,
  MglFullscreenControl,
  MglScaleControl,
} from "vue-mapbox";

export default {
  components: {
    MglMap,
    MglNavigationControl,
    MglFullscreenControl,
    MglScaleControl,
  },
  data() {
    return {
      accessToken:
        "pk.eyJ1IjoiODk5MW5vZmVhciIsImEiOiJja3YzOWltM3cxZHBjMnVxMXZ1MjFvZzl1In0.INARVM0hWYBasZThvVobhQ",
      mapStyle: "mapbox://styles/8991nofear/ckv6eip4d7jp314o319sxfgzs",
    };
  },
  created() {
    this.mapbox = Mapbox;
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