var addButtonVar = document.getElementById("addButton");
var addDialogVar = document.getElementById("addTaskDialog");
var addFormVar = document.getElementById("addTaskForm");
var daySelectorVar = document.getElementById("daySelector1");
var taskInputVar = document.getElementById("taskInput");
var closeAddDialogVar = document.getElementById("closeButon1");

addButtonVar.onclick = function()
{
    addDialogVar.showModal();
}

closeAddDialogVar.onclick = function()
{
    addDialogVar.close();
}

/*addFormVar.onsubmit = function(event)
{
    event.preventDefault();

    let day = daySelectorVar.value;
    let task = taskInputVar.value;

    fetch('',
         {
           method: 'POST',
           headers: 
           {
             'content-type': 'application/x-www-form-urlencoded' 
           },
           body: 'day=' + encodedURIComponent(day) + '&task=' + encodedURIComponent(task)
         })
    

}*/



var removeButtonVar = document.getElementById("removeButton");
var removeDialogVar = document.getElementById("removeTaskDialog");

removeButtonVar.onclick = function()
{
    removeDialogVar.showModal();

}