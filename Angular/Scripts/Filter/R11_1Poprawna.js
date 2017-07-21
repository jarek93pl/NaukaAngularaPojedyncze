var app = angular.module("exampleApp", []);
app.controller("topLevelCtrl", function ($scope)
{
    $scope.z = { dataValue: "Witaj, Adam"};
    $scope.reverseText = function () {
        $scope.z.dataValue = $scope.z.dataValue.split("").reverse().join("");
    }
    $scope.changeCase = function ()
    {
        var result = [];
        angular.forEach($scope.z.dataValue.split(""),
            function (char, index)
            {
                result.push(index % 2 === 1 ? char.toString().toUpperCase() : char.toString().toLowerCase());
            });
        $scope.z.dataValue = result.join("");
    };
});
app.controller("firstChildCtrl", function ($scope)
{
    $scope.changeCase = function ()
    { $scope.z.dataValue = $scope.z.dataValue.toUpperCase(); };
});
app.controller("secondChildCtrl", function ($scope)
{
    $scope.changeCase = function ()
    {
        $scope.z.dataValue = $scope.z.dataValue.toLowerCase();
    };
    $scope.shiftFour = function ()
    {
        var result = []; angular.forEach($scope.z.dataValue.split(""),
            function (char, index)
            { result.push(index < 4 ? char.toUpperCase() : char); });
        $scope.z.dataValue = result.join("");
    }
});
