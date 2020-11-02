<template>
  <grid :cols="cols" :rows="getData" :width="width" ></grid>
</template>

<script>
  import Grid from 'gridjs-vue'

  export default {
    name: 'Places',
    components: {
      Grid
    },
           
    computed :{
      getData : function(){
         return this.$store.state.places;
      }
    },  
    

    data() {
        return {
            cols: ['Id', 'Postcode', 'Description'],
            width: "100%",
        }
    }
  }
</script>