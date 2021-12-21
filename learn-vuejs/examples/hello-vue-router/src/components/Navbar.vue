<template>
  <div class="navbar">
    <h1>My Vue Router</h1>
    <ul class="nav-link">
      <li><router-link :to="{ name: 'home' }">Home</router-link></li>
      <li><router-link :to="{ name: 'about' }">About</router-link></li>
      <li><router-link :to="{ name: 'qna' }">QnA</router-link></li>
    </ul>
  </div>
</template>

<script>
export default {};
</script>

<style scoped>
.navbar {
  background: #333;
  color: #fff;
  text-align: center;
  padding: 16px;
}

.navbar ul.nav-link {
  display: flex;
  justify-content: space-around;
  align-items: center;
  list-style: none;
  padding: 0;
}

.navbar ul li a {
  color: #fff;
  text-decoration: none;
}

.navbar ul li a:hover {
  color: lightblue;
}
</style>