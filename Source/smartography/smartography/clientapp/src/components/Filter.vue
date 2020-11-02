<template>
<div class="form-container">

  <div class="box">
    <form id="filter-form" @submit.prevent="getPlaces">
        <div class="field">
            <label class="label">Filter</label>
            <input type="text" class="input" name="filter" v-model="filter">
        </div>
        <button type="submit" class="button is-danger">Search</button>
    </form>
  </div>
</div>
</template>

<script>
import axios from 'axios'
  export default {
    name: 'Filterer',
    components: {
    },

    mounted() {
        this.getPlaces();
    },

    methods: {
      getPlaces: function() {
        axios.get("http://localhost:50598/places", {
            params: {
            filter: this.filter
            }}).then(response => this.$store.commit("updatePlaces", response.data));
        }
    },
    
    data() {
        return {
            filter: '',
        }
    },
  }
</script>

<style scoped>
.box {
    width:100%;
    display:flex;
}

.field {
    display: contents;
}
</style>