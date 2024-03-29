﻿/// <reference path="churchservicetimedetailcontroller.js" />
app.controller('usersController', function ($scope, $window, $mdDialog, userService, roleService) {
    $scope.filter = {
        options: {
            debounce: 500
        }
    };
    $scope.query = {
        name: '',
        limit: 20,
        order: 'name',
        page: 1
    };
    $scope.selected = [];
    $scope.showFilter = false;
    $scope.data = [];

    $scope.filter = function () {
        $scope.showFilter = true;
    };
    $scope.close = function () {
        $scope.showFilter = false;

        $scope.query = {
            name: '',
            limit: 20,
            order: 'name',
            page: 1
        };
        $scope.search();
    };


    $scope.$watch('query.name', function (newValue, oldValue) {
        if (!oldValue) {
            bookmark = $scope.query.page;
        }
        if (newValue !== oldValue) {
            $scope.query.page = 1;
        }
        if (!newValue) {
            $scope.query.page = bookmark;
        }

        $scope.search();
    });

    $scope.search = function () {
        $scope.promise = userService.search($scope.query).then(success);
    };

    $scope.detail = function (id) {
        if (id === undefined) {
            id = '0';
        }
        $window.location.href = '/user/detail/' + id;
    };

    $scope.import = function () {
        $window.location.href = '/user/export';
    };

    $scope.changeDistrict = function () {
        $window.location.href = '/user/changeDistrict';
    };

    $scope.export = function () {
        var confirm = $mdDialog.confirm()
            .title('Church Admin')
            .textContent('Are You sure To Export All Users Data?')
            .ariaLabel('Alert Dialog')
            .cancel('No')
            .ok('Yes');

        $mdDialog.show(confirm).then(function () {
            userService.exportListData().then(processSuccess, processError);
        }, function () {
            $mdDialog.hide();
        });
    };
    function processSuccess(obj) {
        $mdDialog.show(
            $mdDialog.alert()
                .clickOutsideToClose(false)
                .title('Church Admin')
                .textContent('Export Successfully.')
                .ariaLabel('Alert Dialog')
                .ok('OK')
        );
    }

    function processError(error) {
        $mdDialog.show(
            $mdDialog.alert()
                .clickOutsideToClose(false)
                .title('Church Admin')
                .textContent('Failed To Export')
                .ok('OK')
        );
    }

    function success(resp) {
        $scope.users = resp.data.result;
        $scope.count = resp.data.count;
    }
    function init() {
        roleService.getAll().then(function (resp) {
            $scope.roles = resp.data;
        });
        $scope.search();
    }
    init();
});
