<template>
  <div id="app" class="container-xl">
    <div class="row pt-5">
      <div class="col-md-10 offset-md-1">
        <div class="card h-100">
          <div class="card-body">
            <h5>Vaccination sites by locations</h5>
            <Datatable />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Datatable from "./components/Datatable.vue";

export default {
  name: "App",
  components: {
    Datatable,
  },
};
</script>

<style>
@import "~ag-grid-community/dist/styles/ag-grid.css";
@import "~ag-grid-community/dist/styles/ag-theme-alpine.css";

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
</style>
