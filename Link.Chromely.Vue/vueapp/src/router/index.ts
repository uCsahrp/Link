import Vue from 'vue'
import VueRouter from 'vue-router'
import Calendar from '../components/Calendar.vue'

Vue.use(VueRouter)

const routes = [
    { path: '/', name: 'calendar', component: Calendar }
]

const router = new VueRouter({
    routes
})

export default router
