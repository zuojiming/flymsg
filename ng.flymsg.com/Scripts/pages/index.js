//导航点击收放特效
myapp.factory("facToggleMenu", function () {
    var factory = {};
    factory.func = function (s, id, $timeout) {
        if (!id)
            return;

        if (s.custom) {
            $("#" + id).css("top", $(event.target).offset().top);
            $("#" + id).css("left", $(event.target).offset().left);
            $(".tag em").css("left", 15);
            $("#" + id).css("width", "auto").css("height", "auto");
            $("#" + id).show().animate({
                top: $(".navbar-fixed-top").height(),
                left: $(event.target).offset().left,
                width: $("#" + id).width() + 15,
                height: $("#" + id).height()
            }, 300);
        } else {
            $("#" + id).animate({
                top: -1 * $("#" + id).height(),
                width: 0,
                height: 0
            }, 300);
            $timeout(function () {
                $("#" + id).hide();
            }, 140);
        }
    };
    return factory;
});

//首页导航栏
myapp.controller("header_nav", function (facToggleMenu, $scope, $timeout, $http, $location, $rootScope, ctrlConfig) {
    $scope.custom = false;
    $scope.hideCro = function (name) {
        $scope.conName = name;
        $scope.NavText = $(event.target).html();
        var id = $(event.target).attr("ng-data-id");
        if ($scope.pre != id) {
            $scope.custom = false;
            facToggleMenu.func($scope, $scope.pre, $timeout);
        }
        $scope.pre = id;
        $scope.custom = !$scope.custom;
        facToggleMenu.func($scope, id, $timeout);
    }
    $scope.navClick = function (nav, item, $rootScope) {
        ctrlConfig.info.nav = nav;
        ctrlConfig.info.item = item;
        $scope.NavText = nav.title + ">>" + item.text;
        $location.path(item.controller);
    }
    $http.post("/Home/NavbarTitles").success(function (data) {
        $scope.navs = data.result;
        for (var i = 0; i < $scope.navs.length; i++) {
            if ($scope.navs[i].items.length == 0)
                continue;
            ctrlConfig.info.nav = $scope.navs[i];
            ctrlConfig.info.item = $scope.navs[i].items[0];
            $scope.NavText = $scope.navs[i].items[0].text;
            break;
        }
    });
    $rootScope.$on("$routeChangeStart", function () {
        //alert("route is change !");
    });
});

myapp.service("ctrlConfig", function () {
    this.info = {

    };
});

$(document).click(function () {
    var id = this.id;
    if (!id)
        return;
    if ($(this).closest(".tag").length == 0) {
        $("#" + id).animate({
            top: -1 * $("#" + id).height(),
            width: 0,
            height: 0
        }, 300);
        $timeout(function () {
            $("#" + id).hide();
        }, 140);
    }
});

function dataConvert(input,ctrlConfig, url) {
    if (input === "" || url === "")
        return;
    var con_1 = input;
    $.ajax({
        url: url,
        data: { data: con_1, ctrl: ctrlConfig.info.item },
        dataType : "text",
        type: "post",
        success: function (data) {
            $("#result_div").html(data);
        },
        error: function (a,b,c) {
            var s = "";
        }
    });
}

function ConvertCtrl($scope, ctrlConfig) {
    $scope.Act = function (dataId) {
        var input = $("#" + dataId).html();
        dataConvert(input, ctrlConfig, ctrlConfig.info.item.controller);
    };
}

function FormaterCtrl($scope) {

}

function DateActCtrl($scope) {

}