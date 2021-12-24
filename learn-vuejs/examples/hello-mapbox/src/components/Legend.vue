<template>
  <div class="row mx-auto map-legend">
    <div class="col-3 fs-6 text-center" style="background-color: #95d5b2">
      <span class="mapboxgl-legend-text">0%-5%</span>
    </div>
    <div class="col-3 fs-6 text-center" style="background-color: #74c69d">
      <span class="mapboxgl-legend-text">5%-10%</span>
    </div>
    <div class="col-3 fs-6 text-center" style="background-color: #52b788">
      <span class="mapboxgl-legend-text">10%-15%</span>
    </div>
    <div class="col-3 fs-6 text-center" style="background-color: #40916c">
      <span class="mapboxgl-legend-text">>15%</span>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style>
@media (min-width: 0) {
  .mapboxgl-legend-text {
    font-size: xx-small;
    color: white;
  }
}

@media (min-width: 576px) {
  .mapboxgl-legend-text {
    font-size: small;
    color: white;
  }
}
</style>