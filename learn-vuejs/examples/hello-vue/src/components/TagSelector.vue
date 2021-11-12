<template>
  <div>
    <div class="list">
      <div v-for="(language, index) in languages" :key="index" @click="language.selected = !language.selected" :class="{selected: language.selected}">
        <span>{{ language.name }}</span>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      languages: [
        { name: "html", selected: false },
        { name: "css", selected: false },
        { name: "js", selected: false },
        { name: "php", selected: false },
        { name: "java", selected: false },
      ],
    };
  },
};
</script>

<style scoped>
div.list div {
  display: inline-block;
  border: 1px solid #ebebeb;
  padding: 4px 16px;
  margin: 4px;
  border-radius: 4px;
}

div.list div.selected {
  background-color: cornflowerblue;
  color: white;
}
</style>