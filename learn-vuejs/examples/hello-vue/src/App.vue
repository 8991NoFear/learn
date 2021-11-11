<template>
  <div id="app">
    <Menu />
    <input type="text" v-model="inputText">
    {{ inputText }}
    <hr>
    <input type="checkbox" v-model="inputCheckbox">Accept terms&service
    <input type="radio" value="1" v-model="inputRadio">1
    <input type="radio" value="2" v-model="inputRadio">2
    <hr>
    <div v-show="isShow">
      <h1>Hello World!</h1>
    </div>
    <button @click="isShow = !isShow">
      <span v-if="isShow">Hide</span>
      <span v-else>Show</span>
    </button>
    <hr>
    <h1 :id="id">Nani</h1>
    <hr>
    <input :disabled="disabled" />
    <button @click="disabled = !disabled">Lock/Unlock</button>
    <hr>
    <h1 :class="{red: isRed}">Red or Black</h1>
    <hr>
    <form action="abc">
      <button type="submit" v-on:click.prevent="doSomething()">Submit Form</button>
    </form>
    <hr>
    <input type="text" v-model="newTask">
    <button @click="tasks.push({content: newTask, done: false})">Add</button>
    <p v-for="(task, index) in tasks" :key="index">
      <input type="checkbox" v-model="task.done">
      <span :class="{ done: task.done }">{{ task.content }}</span>
    </p>
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
      inputRadio: 2,
      isShow: true,
      id: "abc",
      disabled: true,
      isRed: true,
      tasks: [
        {content: 'take a shower', done: false},
        {content: 'eat breakfast', done: false},
        {content: 'code', done: false},
      ]
    }
  }
}
</script>
<style>
.red {
  color: red;
}

.done {
  text-decoration: line-through;
}
</style>
