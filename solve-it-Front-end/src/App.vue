<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
body {
    margin: 0;
    color: #6a6f8c;
    background: #c8c8c8;
          background:linear-gradient(135deg, #172a74, #21a9af);
    font: 600 16px/18px 'Open Sans', sans-serif
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}

@import'~bootstrap/dist/css/bootstrap.css'
</style>
