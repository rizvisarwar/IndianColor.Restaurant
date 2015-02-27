var Utils = {
    AddFoodMenuItem: function (name, category, description, price) {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "AddFoodMenuItem",
            type: "POST",
            data: "{ name:'" + name
        + "', category:'" + category + "', description:'"
        + description + "', price:'" + price
        + "' }",
            contentType: "application/json; charset=utf-8",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#ItemAddResult').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    },

    GetFoodMenuItemNames: function () {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "GetFoodMenuItemNames",
            type: "GET",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#FoodMenuItemNames').empty().html(response);
                $("#dropdownEditFoodMenu option:contains(" + name + ")").attr('selected', 'selected');
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    },

    SetFoodMenuItemData: function (name) {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "SetFoodMenuItemData",
            type: "POST",
            data: "{ name:'" + name + "' }",
            contentType: "application/json; charset=utf-8",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#FoodItemData').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("error");
                $("body").css("cursor", "default");
            }
        });
    },

    RemoveFoodMenuItem: function (name, category, description, price) {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "RemoveFoodMenuItem",
            type: "POST",
            data: "{ name:'" + name
        + "', category:'" + category + "', description:'"
        + description + "', price:'" + price
        + "' }",
            contentType: "application/json; charset=utf-8",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#ItemEditResult').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(response);
                $("body").css("cursor", "default");
            }
        });
    },

    UpdateFoodMenuItem: function (name, category, description, price) {
        $("body").css("cursor", "progress");
        $.ajax({
            url: "UpdateFoodMenuItem",
            type: "POST",
            data: "{ name:'" + name
        + "', category:'" + category + "', description:'"
        + description + "', price:'" + price
        + "' }",
            contentType: "application/json; charset=utf-8",
            success: function (response, status, xhr) {
                $("body").css("cursor", "default");
                $('#ItemEditResult').empty().html(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(response);
                $("body").css("cursor", "default");
            }
        });
    }
}