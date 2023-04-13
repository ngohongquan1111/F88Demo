import { fileURLToPath, URL } from 'node:url'

import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import vueJsx from '@vitejs/plugin-vue-jsx'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue(), vueJsx()],
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url))
    }
  },
  build: {
    outDir: '../loan-application-build', //property specifies the output directory for the built files
    assetsDir: '.',  //property specifies the directory where the assets will be copied
    emptyOutDir: true,
    rollupOptions: {
      input: './src/main.js',
      output: {
        entryFileNames: 'app.js',
        chunkFileNames: '[name].js',
        assetFileNames: '[name][extname]',
      }
     }  //specify the entry point for the application.
  },
 // base: '/Home/Index/' //property sets up the base URL for the application. In this case, it is set to /vue/, which means that the application will be served from http://localhost:port/vue/ when running the .NET MVC application
})
