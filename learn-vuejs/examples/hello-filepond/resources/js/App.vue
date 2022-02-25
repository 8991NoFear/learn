<template>
  <div class="container">
    <home />
  </div>
</template>

<script>
import Home from "./components/Home.vue";
import bootstrap from "bootstrap";

export default {
  name: "App",

  components: {
    Home,
  },
};
</script>

<style>
@import "bootstrap/dist/css/bootstrap.min.css";
</style>