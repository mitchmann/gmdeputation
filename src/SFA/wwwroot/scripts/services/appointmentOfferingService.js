﻿app.service('appointmentOfferingService', function ($http) {
    this.getAll = function () {
        return $http.get('/appointments/all');
    };
    this.get = function (id) {
        return $http.get('/appointments/get/' + id).then(function (resp) {
            return resp.data;
        });
    };
    this.search = function (query) {
        return $http.post('/appointments/search', query);
    };
    this.add = function (data) {
        return $http.post('/appointments/addOfferingOnly', data).then(function (resp) {
            return resp;
        });
    };
    this.save = function (data) {
        return $http.post('/appointments/save', data).then(function (resp) {
            return resp;
        });
    };
    this.submitAppointment = function (data) {
        return $http.post('/appointments/submitAppointment', data).then(function (resp) {
            return resp;
        });
    };
    this.acceptAppointmentByPastor = function (data) {
        return $http.post('/appointments/acceptAppointmentByPastor', data).then(function (resp) {
            return resp;
        });
    };
    this.forwardAppointmentForMissionary = function (data) {
        return $http.post('/appointments/forwardAppointmentForMissionary', data).then(function (resp) {
            return resp;
        });
    };
    this.acceptAppointmentByMissionary = function (data) {
        return $http.post('/appointments/acceptAppointmentByMissionary', data).then(function (resp) {
            return resp;
        });
    };
    this.approvedPastorApointmentsIds = function (data) {
        return $http.post('/appointments/approvedPastorApointmentsIds', data).then(function (resp) {
            return resp;
        });
    };
    this.approvedMissionaryApointmentsIds = function (data) {
        return $http.post('/appointments/approvedMissionaryApointmentsIds', data).then(function (resp) {
            return resp;
        });
    };
});