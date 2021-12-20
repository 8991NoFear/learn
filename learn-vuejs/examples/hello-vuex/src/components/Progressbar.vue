<template>
  <div class="progress-bar">
    <p>Progress: {{ progress }}%</p>
  </div>
</template>

<script>
export default {
  name: "Progressbar",
  computed: {
    progress() {
      const todos = this.$store.state.todos;
      return Math.round(todos.filter((todo) => todo.completed).length / todos.length * 100);
    },
  },
};
</script>

<style>
.progress-bar {
  padding: 5px;
  text-align: center;
  background: rgb(106, 248, 118);
  color: black;
}
</style>