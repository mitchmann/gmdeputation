﻿app.controller('macroscheduleWiseAppoinmentReportsController', function ($scope, $window, $mdDialog, reportsService) {
    $scope.reportParams = {};

    $scope.search = function () {
        reportsService.getMacroscheduleWiseAppoinmentData($scope.reportParams).then(function (resp) {
            $scope.searchDatas = resp.data;
        });
    };

    $scope.generateExcell = function () {
        if ($scope.searchDatas.length === 0) {
            $mdDialog.show(
                $mdDialog.alert()
                    .clickOutsideToClose(false)
                    .title('Church Admin')
                    .textContent('Data Not Found')
                    .ariaLabel('Alert Dialog')
                    .ok('OK')
            );
        }
        else {
            reportsService.generateMacroscheduleWiseAppoinmentReport($scope.searchDatas).then(processSuccess, processError);
        }
    };

    $scope.generatePdf = function () {
        if ($scope.searchDatas.length === 0) {
            $mdDialog.show(
                $mdDialog.alert()
                    .clickOutsideToClose(false)
                    .title('Church Admin')
                    .textContent('Data Not Found')
                    .ariaLabel('Alert Dialog')
                    .ok('OK')
            );
        }
        else {
            reportsService.generateMacroscheduleWiseAppoinmentReportPdf($scope.searchDatas).then(processSuccess, processError);
        }
    };

    $scope.generateWord = function () {
        if ($scope.searchDatas.length === 0) {
            $mdDialog.show(
                $mdDialog.alert()
                    .clickOutsideToClose(false)
                    .title('Church Admin')
                    .textContent('Data Not Found')
                    .ariaLabel('Alert Dialog')
                    .ok('OK')
            );
        }
        else {
            reportsService.generateMacroscheduleWiseAppoinmentReportWord($scope.searchDatas).then(processSuccess, processError);
        }
    };
    function processSuccess(obj) {
        $mdDialog.show(
            $mdDialog.alert()
                .clickOutsideToClose(false)
                .title('Church Admin')
                .textContent('Data Download Successfully.')
                .ariaLabel('Alert Dialog')
                .ok('OK')
        );
    }

    function processError(error) {
        $mdDialog.show(
            $mdDialog.alert()
                .clickOutsideToClose(false)
                .title('Church Admin')
                .textContent('Failed To Download')
                .ok('OK')
        );
    }
    function init() {
        $scope.searchDatas = [];
    }
    init();
});