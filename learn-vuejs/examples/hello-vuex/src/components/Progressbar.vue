<template>
  <div class="progress-bar" v-if="auth.isAuthenticated">
    <p>Progress: {{ progress }}%</p>
  </div>
</template>

<script>
import { mapGetters, mapState } from "vuex";

export default {
  name: "Progressbar",
  computed: { ...mapGetters(["progress"]), ...mapState(["auth"]) },
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