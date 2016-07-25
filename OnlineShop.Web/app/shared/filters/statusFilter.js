/// <reference path="E:\Project\Git\OnlineShop.Web\Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.filter('status', function () {
        return function (input) {
            if (input) {
                return 'Kích hoạt';
            } else {
                return 'Khóa';
            }
        };
    });
})(angular.module('onlineshop.common'));