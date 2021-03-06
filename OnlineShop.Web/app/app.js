﻿/// <reference path="E:\Project\Git\OnlineShop.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module("onlineshop",
        [
        "onlineshop.products",
        "onlineshop.product_categories",
        'onlineshop.common'
        ]).config(config);
    config.$inject = ["$stateProvider", "$urlRouterProvider"];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state("home", {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    };
})();