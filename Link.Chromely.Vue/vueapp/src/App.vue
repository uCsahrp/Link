<template>
    <div id="app">
        <div class="wrapper">
            <main>
                <router-view />
            </main>

            <!--Sidebar-->
            <sidebar>
                <div class="logo">Link</div>
                <div class="avatar">
                    <div class="avatar__img" href="#">
                        <img src="https://picsum.photos/70" alt="avatar">
                    </div>
                    <div class="avatar__name">John Smith</div>
                </div>
                <nav class="menu">
                    <a class="menu__item menu__item--active" href="#">
                        <router-link to="/">
                            <i class="menu__icon fa fa-home"></i>
                            <span class="menu__text">overview</span>
                        </router-link>
                    </a>
                    <a class="menu__item" href="#">
                        <i class="menu__icon fa fa-envelope"></i>
                        <span class="menu__text">messages</span>
                    </a>
                    <a class="menu__item" href="#">
                        <router-link to="/todolist">
                            <i class="menu__icon fa fa-list"></i>
                            <span class="menu__text">checklist</span>
                        </router-link>
                    </a>
                    <a class="menu__item" href="#">
                        <router-link to="/calendar">
                            <i class="menu__icon fa fa-calendar"></i>
                            <span class="menu__text">calendar</span>
                        </router-link>
                    </a>
                    <a class="menu__item" href="#">
                        <router-link to="/ajax">
                            <i class="menu__icon fa fa-users"></i>
                            <span class="menu__text">Learners</span>
                        </router-link>
                    </a>
                    <a class="menu__item" href="#">
                        <i class="menu__icon fa fa-trophy"></i>
                        <span class="menu__text">achivements</span>
                    </a>
                    <a class="menu__item" href="#">
                        <i class="menu__icon fa fa-sliders"></i>
                        <span class="menu__text">setting</span>
                    </a>
                </nav>
                <div class="copyright">A1 copyright &copy; 2021</div>
            </sidebar>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
var chromelyService = require('../src/services/ChromelyService');

@Component
export default class App extends Vue {

    showDevTools() {
         chromelyService.openExternalUrl('http://command.com/democontroller/showdevtools');
    }
}
</script>

<style>

</style>

