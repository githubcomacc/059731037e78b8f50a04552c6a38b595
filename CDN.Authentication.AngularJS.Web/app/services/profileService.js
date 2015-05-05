'use strict';
app.factory('profileService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var profileServiceFactory = {};

    var _getProfile = function () {

        return $http.get(serviceBase + 'api/profile').then(function (results) {
            return results;
        });
    };

    profileServiceFactory.getProfile = _getProfile;

    return profileServiceFactory;

}]);