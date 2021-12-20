import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

const storeData = {
    state: {
        todos: [
            { id: 1, title: "Nấu cơm", completed: true },
            { id: 2, title: "Rửa bát", completed: true },
            { id: 3, title: "Ngủ trưa", completed: false },
        ],
        auth: {
            isAuthenticated: false,
        },
    },
    getters: {
        doneTodos: state => state.todos.filter(todo => todo.completed),
        progress: (state, getters) => {
            return Math.round(getters.doneTodos.length / state.todos.length * 100);
        }
    },
    mutations: {
        TOGGLE_AUTH(state) {
            state.auth.isAuthenticated = !state.auth.isAuthenticated;
        }
    }
}

const store = new Vuex.Store(storeData);

export default store;