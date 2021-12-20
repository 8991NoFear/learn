<template>
  <div class="navbar">
    <h1>My VueX todo list app</h1>
    <ul>
      <li>Home</li>
      <li>About</li>
      <li>Q&A</li>
      <li v-if="auth.isAuthenticated">
          Total todos: {{ todos.length }}
          <button @click="loginOrLogout">Logout</button>
      </li>
      <li v-else>
          <button @click="loginOrLogout">Login</button>
      </li>
    </ul>
  </div>
</template>

<script>
import {mapState} from 'vuex'

export default {
  name: "Navbar",
  computed: mapState(['todos', 'auth']),
  methods: {
      loginOrLogout() {
          this.$store.commit('TOGGLE_AUTH');
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