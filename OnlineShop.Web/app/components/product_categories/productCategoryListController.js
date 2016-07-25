/// <reference path="E:\Project\Git\OnlineShop.Web\Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    app.$inject = ['$scope','apiService'];
    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];
        $scope.getProductCategories = getProductCategories;
        function getProductCategories() {
            apiService.get('/api/productcategory/getall', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('error');
            })
        }
        $scope.getProductCategories();
    };

})(angular.module('onlineshop.product_categories'));