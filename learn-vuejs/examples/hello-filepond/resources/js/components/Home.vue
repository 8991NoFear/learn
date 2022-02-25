<template>
  <div class="row">
    <h1>Hello World!!!</h1>
    <div class="col-sm-2 offset-sm-5">
      <form @submit.prevent="submit">
        <file-pond
          name="avatar"
          ref="pond"
          accepted-file-types="image/png, image/jpeg, image/gif"
          imagePreviewHeight="200"
          imageCropAspectRatio="1:1"
          imageResizeTargetWidth="200"
          imageResizeTargetHeight="200"
          stylePanelLayout="compact circle"
          styleButtonProcessItemPosition="center bottom"
          styleProgressIndicatorPosition="center bottom"
          styleLoadIndicatorPosition="center bottom"
          styleButtonRemoveItemPosition="center bottom"
          :files="files"
          :credits="null"
          :allow-multiple="false"
          :max-files="1"
          server="/api/user/avatar"
        />
        <div class="d-flex flex-row-reverse">
          <button class="btn btn-primary mx-3" type="submit">OK</button>
          <button
            class="btn btn-outline-danger mx-3"
            type="button"
            @click="cancel"
          >
            Cancel
          </button>
        </div>
      </form>
    </div>
  </div>
</template>

<script>
// Import FilePond
import vueFilePond from "vue-filepond";

// Import plugins
import FilePondPluginFileValidateType from "filepond-plugin-file-validate-type/dist/filepond-plugin-file-validate-type.esm.js";
import FilePondPluginImagePreview from "filepond-plugin-image-preview/dist/filepond-plugin-image-preview.esm.js";

//
import FilePondPluginImageCrop from "filepond-plugin-image-crop";
import FilePondPluginImageResize from "filepond-plugin-image-resize";

// Import styles
import "filepond/dist/filepond.min.css";
import "filepond-plugin-image-preview/dist/filepond-plugin-image-preview.min.css";

// Create FilePond component
const FilePond = vueFilePond(
  FilePondPluginFileValidateType,
  FilePondPluginImagePreview,
  FilePondPluginImageCrop,
  FilePondPluginImageResize
);

import axios from "axios";

export default {
  components: {
    FilePond,
  },

  data() {
    return {
      files: [
        {
          source: "default.jpg",
          options: {
            type: "local",
          },
        },
      ],
    };
  },

  methods: {
    submit(event) {
      try {
        axios.post("/api/user/submit", {
          avatar: event.target.elements.avatar.value,
        });
      } catch (error) {}
    },
    cancel() {},
  },
};
</script>

<style>
</style>