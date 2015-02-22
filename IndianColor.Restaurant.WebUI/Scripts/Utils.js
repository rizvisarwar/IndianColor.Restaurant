var Utils = {
    ShowAboutUs: function () {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "Home/About",
            type: "GET",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#PageContent').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    },

    ShowMenu: function () {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "FoodMenuItem/FoodList",
            type: "GET",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#PageContent').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    },

    ShowHome: function () {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "Home/Home",
            type: "GET",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#PageContent').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    },

    ShowContact: function () {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "Home/Contact",
            type: "GET",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#PageContent').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    }
}