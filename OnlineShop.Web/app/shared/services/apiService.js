/// <reference path="E:\Project\Git\OnlineShop.Web\Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.service('apiService', apiService);

    apiService.$inject = ['$http'];
    function apiService($http) {
        return {
            get: get
        }
        function get(url, params, success, failed) {
            $http.get(url, params).then(function (result) {
                success(result);
            }, function (error) {
                failed(error);
            });
        }
    };
})(angular.module('onlineshop.common'));