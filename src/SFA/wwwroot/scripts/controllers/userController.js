﻿app.controller('userController', function ($scope, $window, $location, $mdDialog, userService, roleService, attributeService, churchService, districtService, sectionService, countryService) {
    var id = $location.absUrl().substr($location.absUrl().lastIndexOf('detail/') + 7);




    const isNumericInput = (event) => {
        const key = event.keyCode;
        return ((key >= 48 && key <= 57) || // Allow number line
            (key >= 96 && key <= 105) // Allow number pad
        );
    };

    const isModifierKey = (event) => {
        const key = event.keyCode;
        return (event.shiftKey === true || key === 35 || key === 36) || // Allow Shift, Home, End
            (key === 8 || key === 9 || key === 13 || key === 46) || // Allow Backspace, Tab, Enter, Delete
            (key > 36 && key < 41) || // Allow left, up, right, down
            (
                // Allow Ctrl/Command + A,C,V,X,Z
                (event.ctrlKey === true || event.metaKey === true) &&
                (key === 65 || key === 67 || key === 86 || key === 88 || key === 90)
            )
    };

    const enforceFormat = (event) => {
        // Input must be of a valid number format or a modifier key, and not longer than ten digits
        if (!isNumericInput(event) && !isModifierKey(event)) {
            event.preventDefault();
        }
    };

    const formatToPhone = (event) => {
        if (isModifierKey(event)) { return; }

        const input = event.target.value.replace(/\D/g, '').substring(0, 10); // First ten digits of input only
        const areaCode = input.substring(0, 3);
        const middle = input.substring(3, 6);
        const last = input.substring(6, 10);

        if (input.length > 6) { event.target.value = `(${areaCode}) ${middle} - ${last}`; }
        else if (input.length > 3) { event.target.value = `(${areaCode}) ${middle}`; }
        else if (input.length > 0) { event.target.value = `(${areaCode}`; }
    };

    //These are the liusteners to auto format the phone numbers when a user is adding a new user
    const inputElement = document.getElementById('phoneNumber');
    inputElement.addEventListener('keydown', enforceFormat);
    inputElement.addEventListener('keyup', formatToPhone);

    const inputElement2 = document.getElementById('phoneNumber2');
    inputElement2.addEventListener('keydown', enforceFormat);
    inputElement2.addEventListener('keyup', formatToPhone);

    const inputElement3 = document.getElementById('phoneNumber3');
    inputElement3.addEventListener('keydown', enforceFormat);
    inputElement3.addEventListener('keyup', formatToPhone);


    $scope.edit = false;
    $scope.count = false;
    $scope.churchIdNull = false;
    $scope.isMissonaries = false;


    var pickup = document.getElementById('Address');

    var options = {
        componentRestrictions: {
            country: 'us'
        }
    };
    var autocompletePickup = new google.maps.places.Autocomplete(pickup, options);

    (function (scope) {
        google.maps.event.addListener(autocompletePickup, 'place_changed', function () {
            var place = autocompletePickup.getPlace();
            scope.user.address = place.formatted_address;
        });
    })($scope);


    if (id === "0")
    {
        $scope.edit = true;
    }

    $scope.user = {};
    $scope.isDisabled = false;

    //This is to require the Church to be included when adding a new user
    //10 is the ID for Pastor. 
    $scope.isOneContactRequired = function () {
        if ($scope.dataAccessCode === "P")
            return true;
        else
            return false;
};

    $scope.searchDistrict = function (searchText) {
        $scope.district = [];

        if (searchText !== null && searchText !== undefined && searchText !== "") {
            searchText = searchText.toLowerCase();
            searchText = searchText.toLowerCase();
        }

        angular.forEach($scope.districts, function (event) {           
            if (event.name.toLowerCase().match(searchText)) {
                $scope.district.push(event);
            }
        });

        return $scope.district;
    };
    $scope.selectedDistrictName = function ($item) {
        $scope.user.districtId = $item !== null && $item !== undefined ? $item.id : '0';
        $scope.churches = [];

        if ($scope.user.districtId !== null && $scope.user.districtId !== undefined && $scope.user.districtId !== '0') {

            sectionService.getSectionByDistrictId($scope.user.districtId).then(function (resp) {
                $scope.sections = resp;
            });

            if ($scope.count) {
                angular.forEach($scope.user.churches, function (detail) {
                    detail.church = null;
                });
            }
            $scope.getAllChurchByDistrict($scope.user.districtId);
        }
        else {
            $scope.getAllChurch(); 
        }

        $scope.count = true;
    };


    $scope.getAllChurchByDistrict = function (districtId) {
        churchService.getChurchByDistrict(districtId).then(function (resp) {
            $scope.churches = resp;
        });
    };


    $scope.searchChurch = function (searchText) {
        //if ($scope.user.districtId === null || $scope.user.districtId === undefined || $scope.user.districtId === '0') {
        //    $mdDialog.show(
        //        $mdDialog.alert()
        //            .clickOutsideToClose(false)
        //            .title('ENFINS Admin')
        //            .textContent('Please Search and Select District')
        //            .ariaLabel('Alert Dialog')
        //            .ok('OK')
        //    );
        //    return false;
        //}
        
        $scope.test = [];

        angular.forEach($scope.churches, function (event) {
            $scope.eventStatus = true;
            angular.forEach($scope.user.churches, function (detail) {
                if (event.id === detail.churchId && detail.churchId !== undefined) {
                    $scope.eventStatus = false;
                }
            });
            if ($scope.eventStatus === true && event.churchName.toLowerCase().match(searchText)) {
                $scope.test.push(event);
            }

        });

        return $scope.test;
    };
    $scope.selectedChurchName = function ($item, index) {
        $scope.user.churches[index].churchId = $item !== null && $item !== undefined ? $item.id : '0';

    };

    $scope.addNewChurch = function () {
        $scope.user.churches = $scope.user.churches.concat({});
    };

    $scope.deleteChurch = function (index) {
        var confirm = $mdDialog.confirm()
            .title('Church Admin')
            .textContent('Are You sure To Delete Church?')
            .ariaLabel('Alert Dialog')
            .cancel('No')
            .ok('Yes');

        $mdDialog.show(confirm).then(function () {
            $scope.user.churches.splice(index, 1);
            //$scope.isUpload = false;
        }, function () {
            $mdDialog.hide();
        });
    };

    $scope.addNewState = function () {
        $scope.user.attributes = $scope.user.attributes.concat({});
    };

    $scope.deleteState = function (index) {
        var confirm = $mdDialog.confirm()
            .title('Church Admin')
            .textContent('Are You sure To Delete Attribute?')
            .ariaLabel('Alert Dialog')
            .cancel('No')
            .ok('Yes');

        $mdDialog.show(confirm).then(function () {
            $scope.user.attributes.splice(index, 1);
            //$scope.isUpload = false;
        }, function () {
            $mdDialog.hide();
        });
    };


    $scope.backToMain = function () {
        $window.location.href = '/home';
    };
    $scope.backToList = function () {
        $window.location.href = '/user';
    };

    $scope.save = function () {
        $scope.isDisabled = true;

        angular.forEach($scope.user.churches, function (detail) {
            if (detail.churchId === null || detail.churchId === undefined || detail.churchId === '0') {
                $scope.churchIdNull = true;
            }
            else { $scope.churchIdNull = false;}
        });
        if ($scope.churchIdNull && $scope.user.roleId === 10) {
            $mdDialog.show(
                $mdDialog.alert()
                    .clickOutsideToClose(false)
                    .title('ENFINS Admin')
                    .textContent('Please Search And Select correct Church')
                    .ariaLabel('Alert Dialog')
                    .ok('OK')
            ).then(function () {
                $scope.isDisabled = false;
            });
            return false;
        }

        userService.save($scope.user).then(function (resp) {
            if (resp.data !== null && resp.data !== undefined && resp.data === 1) {
                $mdDialog.show(
                    $mdDialog.alert()
                        .clickOutsideToClose(false)
                        .title('ENFINS Admin')
                        .textContent('User Saved successfully')
                        .ariaLabel('Alert Dialog')
                        .ok('OK')
                ).then(function () {
                    $window.location.href = '/user';
                    $scope.isDisabled = false;
                });
            }
            else if (resp.data !== null && resp.data !== undefined && resp.data === -1) {
                $mdDialog.show(
                    $mdDialog.alert()
                        .clickOutsideToClose(false)
                        .title('ENFINS Admin')
                        .textContent('User Email already exist and it should be unique')
                        .ariaLabel('Alert Dialog')
                        .ok('OK')
                ).then(function () {
                    $scope.isDisabled = false;
                });
            }
            else {
                $mdDialog.show(
                    $mdDialog.alert()
                        .clickOutsideToClose(false)
                        .title('ENFINS Admin')
                        .textContent(resp.data)
                        .ok('OK')
                ).then(function () {
                    $scope.isDisabled = false;
                });
            }
        });
    };

    $scope.getAttribute = function (typeId,index) {
        attributeService.getByTypeId(typeId).then(function (resp) {
            $scope.user.attributes[index].butes = resp;
        });

    };

    $scope.getAllChurch = function () {
        churchService.getAll().then(function (resp) {
            $scope.churches = resp.data;
        });

    };
    $scope.roleChange = function (roleId) {
        $scope.dataAccessCode = null;

        angular.forEach($scope.roles, function (value) {
            if (value.id === roleId) {
                $scope.dataAccessCode = value.dataAccessCode;
            }
        });

        if ($scope.dataAccessCode === "M" && $scope.dataAccessCode !== null && $scope.dataAccessCode !== undefined) {
            $scope.isMissonaries = true;
        }
        else {
            $scope.isMissonaries = false;
        }

        if (($scope.dataAccessCode === "M" || $scope.dataAccessCode === "H") && $scope.dataAccessCode !== null && $scope.dataAccessCode !== undefined) {
            $scope.user.attributes = [];
            $scope.user.churches = [];
        }
        else {
           if($scope.user.churches.length === 0) {
                $scope.user.churches = $scope.user.churches.concat({});
            }
            if ($scope.user.attributes.length === 0) {
                $scope.user.attributes = $scope.user.attributes.concat({});
            }            
        }
    };

    $scope.typeSearch = function (index) {
        $scope.test = [];
        $scope.user.attributes[index].attributeTypeId = undefined;

        angular.forEach($scope.types, function (event) {
            $scope.eventStatus = true;
            angular.forEach($scope.user.attributes, function (detail) {
                if (event.id === detail.attributeTypeId && detail.attributeTypeId !== undefined) {
                    $scope.eventStatus = false;
                }
            });
            if ($scope.eventStatus === true) {
                $scope.test.push(event);
            }            
        });
        $scope.user.attributes[index].types = $scope.test;
    };

    function init() {
        $scope.getAllChurch();

        districtService.getAll().then(function (resp) {
            $scope.districts = resp.data;
        });

        roleService.getAll().then(function (resp) {
            $scope.roles = resp.data;
        });

        attributeService.getAll().then(function (resp) {
            $scope.types = resp.data;
        });

        countryService.getAll().then(function (resp) {
            $scope.countries = resp.data;
        });

        $scope.salutations = [{ "id": "Mr.", "name": "Mr." }, { "id": "Ms.", "name": "Ms." }, { "id": "Mrs.", "name": "Mrs." }, { "id": "Rev", "name": "Rev" }, { "id": "Pastor", "name": "Pastor" }];
        $scope.travelingViaOptions = [{ "id": "Travel trailer", "name": "Travel trailer" }, { "id": "Motorhome", "name": "Motorhome" }, { "id": "Vehicle", "name": "Vehicle" }, { "id": "Bicycle", "name": "Bicycle" }];
        $scope.genders = [{ "id": "Male", "name": "Male" }, { "id": "Female", "name": "Female" }];
        if (id !== null && id !== undefined && id !== '0') {
            userService.get(id).then(function (resp) {
                $scope.user = resp;

                if ($scope.user.districtId !== null && $scope.user.districtId !== undefined && $scope.user.districtId !== '0') {
                    $scope.getAllChurchByDistrict($scope.user.districtId);

                    $scope.user.district = { "id": $scope.user.districtId, "name": $scope.user.districtName };
                }

                angular.forEach($scope.user.churches, function (detail) {
                    detail.church = { "id": detail.id, "churchName": detail.churchName, "address": detail.address };
                });

                angular.forEach($scope.user.attributes, function (detail) {
                    detail.types = $scope.types;
                });
            });
        }
        else {
            $scope.user = {};
            $scope.user.IsWebUser = true;
            $scope.user.isActive = true;
            $scope.user.churches = [{}];
            $scope.user.attributes = [{}];
        }
    }

    init();
});