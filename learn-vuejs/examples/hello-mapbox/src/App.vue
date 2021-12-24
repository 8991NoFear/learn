<template>
  <div id="app" class="container-xl">
    <div class="row pt-5">
      <div class="col-md-6 offset-md-3">
        <div class="card h-100">
          <div class="card-body">
            <h5>Vietnamese's population</h5>
            <Map />
            <Legend />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Legend from "./components/Legend.vue";
import Map from "./components/Map.vue";

export default {
  components: {
    Legend,
    Map,
  },
  name: "App",
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
</style>
