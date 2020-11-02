<template>
  <div id="app">
    <div id=page-title>
      <h1>smartography!</h1>
      <p>cartography, but smart(ish).</p>
    </div>
    <Filterer/>
    <div id=map-container><Map/></div>
    <div id="table-container"><Places /></div>
  </div>
</template>

<script>
import Map from './components/Map.vue'
import Places from './components/Places.vue'
import Filterer from './components/Filter.vue'

export default {
  name: 'app',
  components: {
    Map,
    Places,
    Filterer,
  },
  data() {
    return {
      info: null,
    };
  },
}
</script>

<style>
html {
  background-color:lightgray
}

#logo {
  flex:10%;
}

#page-title {
  flex:100%;
  text-align: left;
  font-style: italic;
}

.form-container {
  flex:100%;
  display: flex;
  text-align: left;
  font-style: italic;
}

#table-container {
  flex: 40%;
}

#map-container {
  flex:50%;
      border-radius: 8px;
    border-bottom-width: 1px;
    overflow: auto;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    -webkit-box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.1), 0 1px 2px 0 rgba(0, 0, 0, 0.26);
    box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.1), 0 1px 2px 0 rgba(0, 0, 0, 0.26);
    border-top-width: 1px;
    border-color: #e5e7eb;
    -webkit-font-smoothing: antialiased;
}

#app {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#app > div {
  margin: 1%;
}

@media (max-width: 1200px) {
  #app {
    flex-direction: column;
  }
}
</style>
