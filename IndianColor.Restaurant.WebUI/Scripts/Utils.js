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
                toastr.success('New food menu item "' + name + '" added.')
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                toastr.error('Could not add menu item "' + name + '"!');
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
                toastr.warning('Food menu item "' + name + '" removed!');
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                toastr.error('Could not remove menu item "' + name + '"!');
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
                toastr.success('Food menu item "' + name + '" updated!');
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                toastr.error('Could not update menu item "' + name + '"!');
                $("body").css("cursor", "default");
            }
        });
    }
}