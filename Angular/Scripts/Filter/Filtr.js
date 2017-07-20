angular.module("exampleApp.Filters", []).filter("dayName", function ()
{
    var dayNames = ["niedziela", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota"];
    return function (input) { return angular.isNumber(input) ? dayNames[input] : input; };
});