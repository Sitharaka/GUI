var addButtonVar = document.getElementById("addButton");
var addDialogVar = document.getElementById("addTaskDialog");
var addFormVar = document.getElementById("addTaskForm");
var daySelectorVar = document.getElementById("daySelector1");
var taskInputVar = document.getElementById("taskInput");
var closeAddDialogVar = document.getElementById("closeButon1");
var removeButtonVar = document.getElementById("removeButton");
var removeDialogVar = document.getElementById("removeTaskDialog");

addButtonVar.onclick = function()
{
    addDialogVar.showModal();
}

closeAddDialogVar.onclick = function()
{
    addDialogVar.close();
}


removeDialogVar.onclick = function()
{
    removeDialogVar.showModal();
}