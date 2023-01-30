//This is my calculator app which pushes the grade to the class="display" div
$("#btnSend").click(function () {
        $("div").html(($("#gpaAssignments").val() * .5) +
        ($("#gpaGroupProjects").val() * .1) +
        ($("#gpaQuizzes").val() * .1) +
        ($("#gpaMidterm").val() * .1) +
        ($("#gpaFinal").val() * .1) +
        ($("#gpaINTEX").val() * .1));

    $('#display').append(str);
})