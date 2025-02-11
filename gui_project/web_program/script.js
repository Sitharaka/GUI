var addButtonVar = document.getElementById("addButton");
var addDialogVar = document.getElementById("addTaskDialog");

addButtonVar.onclick = function()
{
    addDialogVar.showModal();
}

var removeButtonVar = document.getElementById("removeButton");
var removeDialogVar = document.getElementById("removeTaskDialog");

removeButtonVar.onclick = function()
{
    removeDialogVar.showModal();
}