﻿webApp.controller("SecurityCtrl", ["$scope", "$http", "$location", "Security", function ($scope, $http, $location, security) {

    var searchObject = $location.search();

    $scope.username = "";
    $scope.password = "";

    $scope.$watch("user", function (newUser) {
        if (newUser) {
            //console.log(searchObject.returnUrl);
            $location.url(searchObject.returnUrl);
        }
    });
    $scope.login;
    $scope.password;
    $scope.tryLogin = function (username, password) {
        security.Login(username, password);
    };
    $scope.register = function (username, password) {
        security.Register(username, password, username, "/").then(function (dara) {
            console.log(dara);
        });
    }
    $scope.logout = function () {
        security.Logout();
    }
}]);