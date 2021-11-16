var enemyTracker = '<div class="row"><input type="number" class="form-control stats-input input-color mr-4" value="0"/><button onclick="addSpells($(this))" class="btn btn-danger mr-2">Add Spells</button></div><div><button onclick="deleteEnemy($(this))" class="btn btn-danger ml-3">Remove</button></div></div>';

//Find out how to figure out what type of button was pressed and then make changes to the html of the div it is in.

$(document).ready(function () {

    var enemynum = 1;

    $("#addbtn").click(function () {
        $("#list").append('<div><p class="mt-3">Enemy ' + enemynum + ':</p><div class="row mt-1">' + enemyTracker + '</div></div>');
        enemynum++;
    });

});

function deleteEnemy(btn) {

    btn.parent().parent().parent().remove();

}

function addSpells(btn) {

    btn.parent().append('<input type="number" class="form-control stats-input input-color ml-2" value="0" />');
    btn.parent().append('<button onclick="addSpells($(this))" class="btn btn-danger ml-3 mr-2">Add Spells</button>');
    btn.remove();

}