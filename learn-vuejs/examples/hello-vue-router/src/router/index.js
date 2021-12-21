import Vue from 'vue'
import VueRouter from 'vue-router'

import Home from '../components/Home.vue'
import About from '../components/About.vue'
import QnA from '../components/QnA.vue'
import Error from '../components/Error.vue'

Vue.use(VueRouter)

const routes = [
    { path: '/', name: 'home', component: Home },
    { path: '/about', name: 'about', component: About },
    { path: '/qna', name: 'qna', component: QnA },
    { path: '/:pathMatch(.*)*', name: 'error', component: Error }
]

export default new VueRouter({
    routes,
    mode: 'history'
})