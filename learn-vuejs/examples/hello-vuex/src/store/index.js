import Vue from 'vue'
import Vuex from 'vuex'

import auth from './modules/auth.js'
import todos from './modules/todos.js'

Vue.use(Vuex)

const storeData = {
    modules: {
        auth,
        todos,
    },
}

const store = new Vuex.Store(storeData);

export default store;