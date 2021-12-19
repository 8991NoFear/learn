<template>
  <div class="navbar">
    <h1>My VueX todo list app</h1>
    <ul>
      <li>Home</li>
      <li>About</li>
      <li>Q&A</li>
      <li>Total todos: {{ totalTodos }}</li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "Navbar",
  computed: {
      totalTodos() {
          return this.$store.state.todos.length;
      }
  }
};
</script>

<style>
.navbar {
  padding: 5px;
  text-align: center;
  background: rgb(240, 240, 240);
  color: black;
}

.navbar ul {
  display: flex;
  justify-content: space-around;
  align-items: center;
  list-style: none;
  padding: 0;
}
</style>