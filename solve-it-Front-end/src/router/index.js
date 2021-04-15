import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../components/HomePage.vue'
import UrlErrorRedirection from '../components/Authentication/UrlErrorRedirection.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/signup',
    name: 'Sign up',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../components/Authentication/SignUpForm.vue')
  },
  {
    path: '/login',
    name: 'Login',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../components/Authentication/Login.vue')
  },
  {
    path: '/forget-password',
    name: 'forget-password',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../components/Authentication/ForgetPassword.vue')
  },
  {
    path: '*',
    name: 'Error',
    component: UrlErrorRedirection
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
