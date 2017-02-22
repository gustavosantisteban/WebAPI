var model = {
    view: ko.observable("Bienvenido"),
    rsvp: {
        Nombre: ko.observable(""),
        Email: "",
        FueAtendido: ko.observable("true")
    },
    attendees: ko.observableArray([])
}

var showForm = function() {
    model.view("form");
}

var sendRsvp = function () {
    $.ajax("/api/rsvp", {
        type: "POST",
        data: {
            Nombre: model.rsvp.Nombre(),
            Email: model.rsvp.Email,
            FueAtendido: model.rsvp.FueAtendido()
        },
        success: function() {
            getAtendidos();
        }
    });
};

var getAtendidos = function () {
    $.ajax("/api/rsvp", {
        type: "GET",
        success: function (data) {
            model.attendees.removeAll();
            model.attendees.push.apply(model.attendees, data.map(function (rsvp) {
                return rsvp.Nombre;
            }));
            model.view("Gracias");
        }
    });
}

$(document).ready(function () {
    ko.applyBindings();
});