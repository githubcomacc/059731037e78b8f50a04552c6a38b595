'use strict';
app.controller('profilesController', ['$scope', 'profilesService', function ($scope, profilesService) {

    $scope.profiles = [];

    profilesService.getProfiles().then(function (results) {

        $scope.profiles = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

}]);