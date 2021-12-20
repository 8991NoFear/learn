import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

const storeData = {
    state: {
        todos: [
            {id: 1, title: "Nấu cơm", completed: true},
            {id: 2, title: "Rửa bát", completed: true},
            {id: 3, title: "Ngủ trưa", completed: false},
        ],
        auth: {
            isAuthenticated: false,
        },
    }
}

const store = new Vuex.Store(storeData);

export default store;