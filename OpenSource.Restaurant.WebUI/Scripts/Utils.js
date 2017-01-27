var Utils = {
    MakeActive: function (title) {
        var selector = '.nav li';
        $(selector).removeClass('active');
        if (title == "About") {
            $('#navAbout').addClass('active');
        }
        else if (title == "Home") {
            $('#navHome').addClass('active');
        }
        else if (title == "Reservations") {
            $('#navReservations').addClass('active');
        }
        else if (title == "Contact") {
            $('#navLocation').addClass('active');
        }
    },
}