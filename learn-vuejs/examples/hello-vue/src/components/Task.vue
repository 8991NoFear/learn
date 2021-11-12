<template>
  <div>
      <span>{{ taskData.content }}</span>
  </div>
</template>

<script>
export default {
    props: {
        taskData: Object
    },
    // props: [
    //     'taskData'
    // ],
    data() {
        return {
            content: 'ABC'
        }
    }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
