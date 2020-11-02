<template>
  <div id="map">
    <GmapMap
    :center="{lat:51.54814712, lng:-2.55343081}"
    :zoom="12"
    map-type-id="roadmap"
    style="width: 100%; height: 500px; margin: auto; float: left"
    >
    <GmapMarker
      :key="index"
      v-for="(m, index) in this.getData"
      :position="{ lat: parseFloat(m.latitude), lng: parseFloat(m.longitude) }"
      :title="m.id.toString()"
      :clickable="true"
      @click="center=m.position"
    />
  </GmapMap>
  </div>
</template>

<script>
export default {
  name: 'Map',

  computed :{
      getData : function(){
         return this.$store.state.places;
      }
    }, 
}

</script>

<style scoped>
#map {
  width: 100%;
  height: 80%;
}

h1 {
  float: left;
  width: 90%;
}

h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}

.vue-map-container,
.vue-map-container .vue-map {
    width: 100%;
    height: 100%;
}
</style>
