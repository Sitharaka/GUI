<?php
    require_once"database.php";

    try {
       $query = "SELECT * FROM tasks";
       $stmt = $pdo->prepare($query);
       $stmt->execute();
       $tasks = $stmt->fetchAll(PDO::FETCH_ASSOC);

       $tasksByDay = [
        'Monday' => [],
        'Tuesday' => [],
        'Wednesday' => [],
        'Thursday' => [],
        'Friday' => [],
        'Saturday' => [],
        'Sunday' => []
    ];

    foreach ($tasks as $task) {
      if (!empty($task['Monday'])) $tasksByDay['Monday'][] = $task['Monday'];
      if (!empty($task['Tuesday'])) $tasksByDay['Tuesday'][] = $task['Tuesday'];
      if (!empty($task['Wednesday'])) $tasksByDay['Wednesday'][] = $task['Wednesday'];
      if (!empty($task['Thursday'])) $tasksByDay['Thursday'][] = $task['Thursday'];
      if (!empty($task['Friday'])) $tasksByDay['Friday'][] = $task['Friday'];
      if (!empty($task['Saturday'])) $tasksByDay['Saturday'][] = $task['Saturday'];
      if (!empty($task['Sunday'])) $tasksByDay['Sunday'][] = $task['Sunday'];
    }

    $tasksByDay['Monday'] = array_unique($tasksByDay['Monday']);
    $tasksByDay['Tuesday'] = array_unique($tasksByDay['Tuesday']);
    $tasksByDay['Wednesday'] = array_unique($tasksByDay['Wednesday']);
    $tasksByDay['Thursday'] = array_unique($tasksByDay['Thursday']);
    $tasksByDay['Friday'] = array_unique($tasksByDay['Friday']);
    $tasksByDay['Saturday'] = array_unique($tasksByDay['Saturday']);
    $tasksByDay['Sunday'] = array_unique($tasksByDay['Sunday']);
    
    } catch (PDOException $e) {
      echo "Error fetching tasks: " . $e->getMessage();
       $tasksByDay = ['Monday' => [], 'Tuesday' => [], 'Wednesday' => [], 'Thursday' => [], 'Friday' => [], 'Saturday' => [], 'Sunday' => []];
    }
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
        <tr>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Monday'])); ?></td>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Tuesday'])); ?></td>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Wednesday'])); ?></td>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Thursday'])); ?></td>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Friday'])); ?></td>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Saturday'])); ?></td>
          <td><?php echo implode('<br>', array_map('htmlspecialchars', $tasksByDay['Sunday'])); ?></td>
        </tr>
      </table>   
      
      <dialog id="addTaskDialog">
        <h2>Add New Tasks</h2>
        <form action="addTask.php" id="addTaskForm" method="post" action="">
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