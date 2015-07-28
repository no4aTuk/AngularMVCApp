var app = angular.module("AngularApp", ["ngRoute"]);


app.controller('WorkerController', ['$scope', 'service', function ($scope, service) {

    service.success(function (data) {
        $scope.workers = data;
    })
    .error(function (error) {
        $scope.status = "Unable to load data " + error.message;

    });
}]);
app.controller('LoginController', LoginController);
app.controller('RegisterController', RegisterController);


app.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
app.factory('LoginFactory', LoginFactory);
app.factory('RegistrationFactory', RegistrationFactory);



var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider
     
        .when('/', {
            templateUrl: 'Home/Homepage'
        })
        .when('/Home/Index', {
            templateUrl: 'Home/Homepage'
        })

        .when('/workers', {
            templateUrl: 'Worker/ShowWorkers',
            controller: 'WorkerController'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        })
        .when('/register', {
            templateUrl: '/Account/Register',
            controller: RegisterController
        });
    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

}

app.factory('service', ['$http', function ($http) {
    return $http.get('/Worker/GetWorkers')
    .success(function (data) {
        return data;
    })
    .error(function (err) {
        return err;
    });
}]);

configFunction.$inject = ['$routeProvider', '$httpProvider' ];
app.config(configFunction);