import Vue from 'vue'
import Vuex from 'vuex'

import axios from 'axios'

Vue.use(Vuex)

const storeData = {
    state: {
        todos: [
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
        },
        TOGGLE_COMPLETED: (state, id) => {
            state.todos.forEach(todo => {
                if (todo.id == id) {
                    todo.completed = !todo.completed;
                }
            });
        },
        DELETE_TODO: function (state, id) {
            state.todos = state.todos.filter(todo => todo.id != id);
        },
        ADD_TODO(state, newTodo) {
            state.todos.unshift(newTodo);
        },
        GET_TODOS(state, todos) {
            state.todos = todos;
        },
    },
    actions: {
        async deleteTodo({ commit }, id) {
            try {
                await axios.delete(`https://jsonplaceholder.typicode.com/todos/${id}`);
                commit('DELETE_TODO', id);
            } catch (error) {
                console.log(error);
            }
        },
        async addTodo({ commit }, newTodo) {
            try {
                await axios.post('https://jsonplaceholder.typicode.com/todos', newTodo);
                commit('ADD_TODO', newTodo);
            } catch (error) {
                console.log(error);
            }
        },
        async getTodos({ commit }) {
            try {
                const response = await axios.get('https://jsonplaceholder.typicode.com/todos?_limit=5');
                commit('GET_TODOS', response.data);
            } catch (error) {
                console.log(error);
            }
        },
    }
}

const store = new Vuex.Store(storeData);

export default store;