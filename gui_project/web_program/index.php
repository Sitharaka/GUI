<?php
   include("database.php");
   include("addTask.php");
?>
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>
        Task Manager
    </title>
  </head>
  <body>
      <header>
        <h1>
            WEEKLY TASK MANAGER
        </h1>
        <div class="ButtonSet1">
            <button type="button" id="addButton">Add task</button>
            <button type="button" id="removeButton">Remove task</button>
        </div>
      </header>

      <table class="table1">
        <tr>
        <th>Monday</th>
        <th>Tuestday</th>
        <th>Wednesday</th>
        <th>Thursday</th>
        <th>Friday</th>
        <th>Saturday</th>
        <th>Sunday</th>
        </tr>
      </table>
      
      <dialog id="addTaskDialog">
        <h2>Add New Tasks</h2>
        <form id="addTaskForm" method="post" action="">
        <p>
          <select id="daySelector1" name="day">
             <option value="Monday">Monday</option>
             <option value="Tuesday">Tuesday</option>
             <option value="Wednesday">Wednesday</option>
             <option value="Thursday">Thursday</option>
             <option value="Friday">Friday</option>
             <option value="Saturday">Saturday</option>
             <option value="Sunday">Sunday</option>
          </select>
        </p>
        <p>
          <input type="text" id="taskInput" name="task" value="add task">
        </p>
        <button id="submitButton">Add</button>
        <button id="closeButton1">Close</button>
        </form>
      </dialog>

      <dialog id="removeTaskDialog">
        <h2>Remove Tasks</h2>
        <p>
          <select id="daySelector2" name="Days">
            <option value="Monday">Monday</option>
            <option value="Tuesday">Tuesday</option>
            <option value="Wednesday">Wednesday</option>
            <option value="Thursday">Thursday</option>
            <option value="Friday">Friday</option>
            <option value="Saturday">Saturday</option>
            <option value="Sunday">Sunday</option>
         </select>
        </p>
        <form method="dialog">
          <button>Remove</button>
          <button>Close</button>
        </form>
      </dialog>

      <script src="script.js"></script>

<!--Edit test comment-->
<!--Edit test comment 2-->
  </body>
</html>