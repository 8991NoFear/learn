<template>
  <ag-grid-vue
    style="width: 100%; height: 100%;"
    class="ag-theme-alpine"
    :columnDefs="columnDefs"
    :rowData="rowData"
    @grid-ready="onGridReady"
    pagination="true"
    domLayout="autoHeight"
    paginationPageSize="10"
  >
  </ag-grid-vue>
</template>

<script>
import { AgGridVue } from "ag-grid-vue";

export default {
  data() {
    return {
      columnDefs: null,
      rowData: null,
    };
  },

  components: {
    "ag-grid-vue": AgGridVue,
  },

  beforeMount() {
    this.columnDefs = [
      { field: "make", sortable: true, filter: true, resizable: true },
      { field: "price", sortable: true, filter: true, resizable: true },
      { field: "model", sortable: true, filter: true, resizable: true },
    ];

    this.rowData = [
      { make: "Toyota 1", model: "Celica", price: 35000 },
      { make: "Ford 1", model: "Mondeo", price: 32000 },
      { make: "Porsche 1", model: "Boxter", price: 72000 },
      { make: "Toyota 2", model: "Celica", price: 35000 },
      { make: "Ford 2", model: "Mondeo", price: 32000 },
      { make: "Porsche 2", model: "Boxter", price: 72000 },
      { make: "Toyota 3", model: "Celica", price: 35000 },
      { make: "Ford 3", model: "Mondeo", price: 32000 },
      { make: "Porsche 3", model: "Boxter", price: 72000 },
      { make: "Toyota 4", model: "Celica", price: 35000 },
      { make: "Ford 4", model: "Mondeo", price: 32000 },
      { make: "Porsche 4", model: "Boxter", price: 72000 },
      { make: "Toyota 5", model: "Celica", price: 35000 },
      { make: "Ford 5", model: "Mondeo", price: 32000 },
      { make: "Porsche 5", model: "Boxter", price: 72000 },
    ];
  },

  methods: {
    onGridReady(params) {
      params.api.sizeColumnsToFit();
    },
  },
};
</script>

<style>
</style>