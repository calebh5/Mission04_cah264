//This is my calculator app which pushes the grade to the class="display" div
$(document).ready(function () {
    $("#btnSend").click(function () {
        percentage = (($("#gpaAssignments").val() * .5) +
            ($("#gpaGroupProjects").val() * .1) +
            ($("#gpaQuizzes").val() * .1) +
            ($("#gpaMidterm").val() * .1) +
            ($("#gpaFinal").val() * .1) +
            ($("#gpaINTEX").val() * .1))

        //Calculations
        if (percentage >= 94) {
            grade = "A"
        }
        else if (percentage >= 90) {
            grade = "A-"
        }
        else if (percentage >= 87) {
            grade = "B+"
        }
        else if (percentage >= 84) {
            grade = "B"
        }
        else if (percentage >= 80) {
            grade = "B-"
        }
        else if (percentage >= 77) {
            grade = "C+"
        }
        else if (percentage >= 74) {
            grade = "C"
        }
        else if (percentage >= 70) {
            grade = "C-"
        }
        else if (percentage >= 67) {
            grade = "D+"
        }
        else if (percentage >= 64) {
            grade = "D"
        }
        else if (percentage >= 60) {
            grade = "D-"
        }
        else {
            grade = "E"
        }
//display of grade
        $("#gradeDisplay").html(grade)

    });
});


