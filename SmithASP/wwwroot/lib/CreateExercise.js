var $ = function (id) {
    return document.getElementById(id);
}

var d = function () {
    var tableData = this.parentNode;
    var tableRow = tableData.parentNode;
    var muscleGroupControl = document.getElementById("MuscleGroup");
    var option = document.createElement("option");
    option.text = tableRow.cells[0].getElementsByTagName("input")[0].value;
    option.value = tableRow.cells[2].getElementsByTagName("input")[0].value;
    muscleGroupControl.append(option);
    tableRow.remove();

}

$("AddMuscleGroup").onclick = function () {
    var muscleGroupControl = document.getElementById("MuscleGroup");
    var muscleGroup = muscleGroupControl.options[muscleGroupControl.selectedIndex].text;
    var muscleGroupID = muscleGroupControl.options[muscleGroupControl.selectedIndex].value;
    muscleGroupControl.remove(muscleGroupControl.selectedIndex);
    var table = document.getElementById("ExerciseMuscleGroupTable");
    var row = table.insertRow(table.length);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    cell1.innerHTML = "<input type='text' id='muscle' value='"+ muscleGroup +"' disabled/>";
    cell2.innerHTML = "<button type='button' id='deleteBtn" + muscleGroupID + "' > Delete</button > ";
    cell3.innerHTML = "<input type='hidden' id='muscleId' name='muscleId' value='" + muscleGroupID + "'></input>";
    var deleteButton = $("deleteBtn" + muscleGroupID);
    deleteButton.onclick = d;
};

