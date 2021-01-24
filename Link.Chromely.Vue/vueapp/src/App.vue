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
                    <div class="avatar__img">
                        <img src="https://picsum.photos/70" alt="avatar">
                    </div>
                    <div class="avatar__name">John Smith</div>
                </div>
                <nav class="menu">
                    <a class="menu__item" href="#">
                        <i class="menu__icon fa fa-home"></i>
                        <span class="menu__text">overview</span>
                    </a>
                    <a class="menu__item" href="#">
                        <i class="menu__icon fa fa-envelope"></i>
                        <span class="menu__text">messages</span>
                    </a>
                    <a class="menu__item">
                        <i class="menu__icon fa fa-list"></i>
                        <router-link to="/todolist">
                            <span class="menu__text">checklist</span>
                        </router-link>
                    </a>
                    <a class="menu__item menu__item--active" href="#">
                        <i class="menu__icon fa fa-calendar"></i>
                        <span class="menu__text">calendar</span>
                    </a>
                    <a class="menu__item" href="#">
                        <i class="menu__icon fa fa-bar-chart"></i>
                        <span class="menu__text">goals</span>
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

            <!-- Links -->
            <!--<div class="collapse navbar-collapse justify-content-end" id="nav-content">
          <ul class="nav nav-pills">
            <li class="nav-item">
              <a class="nav-link"><router-link to="/">home</router-link></a>
            </li>
            <li class="nav-item">
              <a class="nav-link"><router-link to="/tmdbmovies">tmdb movies</router-link></a>
            </li>
            <li class="nav-item">
              <a class="nav-link"><router-link to="/todolist">todo list</router-link></a>
            </li>
            <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" aria-haspopup="true" aria-expanded="false">basics</a>
                <div class="dropdown-menu dropdown-menu-right">
                    <a class="dropdown-item"><router-link to="/msgrouter">Message Router Demo</router-link></a>
                    <a class="dropdown-item"><router-link to="/ajax">Ajax Demo</router-link></a>
                    <a class="dropdown-item"><router-link to="/javascriptdemo">Execute JavaScript Demo</router-link></a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item"><router-link to="/html5tests">HTML5 Tests</router-link></a>
                     <a class="dropdown-item"><router-link to="/html6tests">HTML6 Tests</router-link></a>
                    <a class="dropdown-item"><router-link to="/shakatests">Google Shaka Support Tests</router-link></a>
                     <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);"><router-link to="/" v-on:click.native="showDevTools">Show DevTools</router-link></a>
                </div>
            </li>
          </ul>
          </div>
        </nav>
        <div class="container-fluid">
                <div class="row">
                    <div class="col-12 p-0">
                        <div class="text-center m-0  d-flex flex-column justify-content-center">
                            <router-view />
                        </div>
                    </div>
                </div>
            </div>-->
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

