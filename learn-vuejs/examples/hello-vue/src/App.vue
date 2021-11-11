<template>
  <div id="app">
    <Menu />
    <input type="text" v-model="inputText">
    {{ inputText }}
    <input type="checkbox" v-model="inputCheckbox">Accept terms&service
    <input type="radio" value="1" v-model="inputRadio">1
    <input type="radio" value="2" v-model="inputRadio">2
  </div>
</template>

<script>
import Menu from './components/Menu.vue'

export default {
  components: {
    Menu // Menu: Menu
  },
  data() {
    return {
      inputText: "BinhLD",
      inputCheckbox: true,
      inputRadio: 2
    }
  }
}
</script>

<style>
</style>
