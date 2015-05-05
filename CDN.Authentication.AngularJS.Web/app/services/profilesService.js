'use strict';
app.factory('profilesService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var profilesServiceFactory = {};

    var _getProfiles = function () {

        return $http.get(serviceBase + 'api/profiles').then(function (results) {
            return results;
        });
    };

    profilesServiceFactory.getProfiles = _getProfiles;

    return profilesServiceFactory;

}]);