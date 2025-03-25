var addButtonVar = document.getElementById("addButton");
var addDialogVar = document.getElementById("addTaskDialog");
var addFormVar = document.getElementById("addTaskForm");
var daySelectorVar = document.getElementById("daySelector1");
var taskInputVar = document.getElementById("taskInput");
var closeAddDialogVar = document.getElementById("closeButon1");
var removeButtonVar = document.getElementById("removeButton");
var removeDialogVar = document.getElementById("removeTaskDialog");

console.log("Add Button:", addButtonVar);
console.log("Add Dialog:", addDialogVar);
console.log("Remove Button:", removeButtonVar);
console.log("Remove Task:", removeDialogVar);

addButtonVatr.onclick = function()
{
    addDialogVar.showModal();
}

closeAddDialogVar.onclick = function()
{
    addDialogVar.close();
}
removeButtonVar.onclick = function()
{
    removeDialogVar.showModal();
}