import Vue from 'vue'
import App from './App.vue'
import * as VueGoogleMaps from 'vue2-google-maps'
import Grid from 'gridjs-vue'
import store from "./store";

Vue.config.productionTip = false

Vue.use(store)

Vue.use(VueGoogleMaps, {
  load: {
    libraries: 'places',
  },
})

Vue.use(Grid)

new Vue({
  render: h => h(App),
  store: store,
}).$mount('#app')

