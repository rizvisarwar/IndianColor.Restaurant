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
    }
}