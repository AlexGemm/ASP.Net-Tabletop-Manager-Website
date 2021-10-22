$(document).ready(function () {

    $(".int-input").val(0);
    $(".stats-input").val(0);

    $("#infnsad").hide();
    $("#infpd").hide();
    $("#inflad").hide();
    $("#infscd").hide();

    $("#hidensa").click(function () {
        $("#nsac").val("None");
        $("#nsarow").hide(500);
    });

    $("#infnsa").click(function () {
        $("#infnsad").toggle(250);
    });

    $("#hidep").click(function () {
        $("#pc").val("None");
        $("#prow").hide(500);
    });

    $("#infp").click(function () {
        $("#infpd").toggle(250);
    });

    $("#hidela").click(function () {
        $("#lac").val("None");
        $("#larow").hide(500);
    });

    $("#infla").click(function () {
        $("#inflad").toggle(250);
    });

    $("#hidesc").click(function () {
        $("#scc").val("None");
        $("#scrow").hide(500);
    });

    $("#infsc").click(function () {
        $("#infscd").toggle(250);
    });

    //Preset the create statblock page.
    $("#bac").val("Attack Name: 0d0 + 0 (+0 to hit)(Range 0ft / 0ft) Damage Type; Property, Property, Property \r\n- (Extra notes on the attack go here)");
    $("#nsac").val("Resources: (Resource Name) 0 \r\n - Ability Name (Charges/TimePeriod): Ability Details (Duration)");
    $("#pc").val("- Effect Name: Effect details.");
    $("#lac").val("Legendary Resistances: (Charges/Day) \r\nLegendary Actions Charges: (0)\r\n- Legendary Action Name (Cost): Details");
    $("#scc").val("Spell Slots: 1 (0), 2 (0), 3 (0), 4 (0), 5 (0), 6 (0), 7 (0), 8 (0), 9 (0)\r\n- Spell Name (spell level)(action type)(range): Spell description.");
    $("#enc").val("- ");
    $("#sc").val("0 Passive Perception");

    //Add linebreaks to the index page.
    $("#bai").html($("#bai").html().replaceAll('\r\n', "<br>"));
    $("#nsai").html($("#nsai").html().replaceAll('\r\n', "<br>"));
    $("#pi").html($("#pi").html().replaceAll('\r\n', "<br>"));
    $("#lai").html($("#lai").html().replaceAll('\r\n', "<br>"));
    $("#sci").html($("#sci").html().replaceAll('\r\n', "<br>"));
    $("#eni").html($("#eni").html().replaceAll('\r\n', "<br>"));

});
