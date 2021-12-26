<template>
  <div id="app">
    <hello-world></hello-world>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";

export default {
  name: "App",
  components: {
    "hello-world": HelloWorld,
  },
};
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Pushster&display=swap');

#app {
  font-family: Pushster, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
</style>