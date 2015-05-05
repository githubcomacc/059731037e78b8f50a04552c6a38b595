'use strict';
app.controller('profileController', ['$scope', 'profileService', function ($scope, profileService) {

    $scope.profile = [];

    profileService.getProfile().then(function (results) {

        $scope.profile = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

}]);