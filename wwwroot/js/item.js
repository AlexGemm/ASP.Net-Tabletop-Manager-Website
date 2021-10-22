$(document).ready(function () {

    $("#infpp").hide();
    $("#infpd").hide();

    $("#powc").val("Attack: 0d0 Damagetype (Range 0ft/0ft); Property, Property, Property \r\n-");

    $("#infp").click(function () {
        $("#infpp").toggle(250);
    });
    $("#infd").click(function () {
        $("#infpd").toggle(250);
    });

});
