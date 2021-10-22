$(document).ready(function () {

    $("#hidensa").click(function () {
        $("#nsac").val("None");
        $("#nsarow").hide(500);
    });

    $("#hidep").click(function () {
        $("#pc").val("None");
        $("#prow").hide(500);
    });

    //Preset the create statblock page.
    $("#bac").val("Attack Name: 0d0 Damagetype(Range 0ft / 0ft); Property, Property, Property \r\n- (Extra notes on the attack go here)");
    $("#nsac").val("Resources: (Resource Name) 0 \r\n - Ability Name (Charges/TimePeriod): Ability Details (Duration)");
    $("#pc").val("- Effect Name: Effect details.");
    $("#lac").val("Legendary Resistances: (Charges/Day) \r\nLegendary Actions Charges: (0)\r\n- Legendary Action Name (Cost): Details");
    $("#scc").val("Spell Slots: 1 (0), 2 (0), 3 (0), 4 (0), 5 (0), 6 (0), 7 (∅), 8 (0), 9 (0)\r\n- Spell Name (spell level)(action type)(range): Spell description.");
    $("#enc").val("- ");

    //Add linebreaks to the index page.
    $("#bai").html($("#bai").html().replaceAll('\r\n', "<br>"));
    $("#nsai").html($("#nsai").html().replaceAll('\r\n', "<br>"));
    $("#pi").html($("#pi").html().replaceAll('\r\n', "<br>"));
    $("#lai").html($("#lai").html().replaceAll('\r\n', "<br>"));
    $("#sci").html($("#sci").html().replaceAll('\r\n', "<br>"));
    $("#eni").html($("#eni").html().replaceAll('\r\n', "<br>"));

});
