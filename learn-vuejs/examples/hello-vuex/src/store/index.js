import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

const storeData = {
    state: {
        todos: [
            {id: 1, title: "Nấu cơm", completed: false},
            {id: 2, title: "Rửa bát", completed: false},
            {id: 3, title: "Ngủ trưa", completed: false},
        ],
        auth: {
            isAuthenticated: false,
        },
    }
}

const store = new Vuex.Store(storeData);

export default store;