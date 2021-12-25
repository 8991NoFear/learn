import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

const storeData = {
    state: {
        geoJsonSource: {
            type: 'geojson',
            data: null
        },
        dataFetched: false,
    },
    getters: {
        geoJsonSource(state) {
            return state.geoJsonSource
        },
        dataFetched(state) {
            return state.dataFetched
        }
    },
    mutations: {
        SET_SOURCE(state, source) {
            state.geoJsonSource.data = source
        },
        SET_DATA_FETCHED(state) {
            state.dataFetched = true
        }
    },
    actions: {
        async fetchSource({ commit }) {
            const response = await fetch('http://localhost:8080/diaphanhuyen.geojson', {
                headers: {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json'
                }
            })
            const source = await response.json()
            commit('SET_SOURCE', source)
            console.log(source)
            commit('SET_DATA_FETCHED')
        }
    }
}

export default new Vuex.Store(storeData);