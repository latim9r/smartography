import Vue from "vue";
import Vuex from "vuex";
 
Vue.use(Vuex);
 
export default new Vuex.Store({
 state: {
    places: []
 },
 getters: {},
 mutations: {
    updatePlaces (state, payload) {
        state.places = payload
      }
 },
 actions: {}
});