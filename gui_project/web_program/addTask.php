<?php
  include("database.php");

  if($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['day']) && isset($_POST['task']))
  {

     if (!empty($day) && !empty($task))
     {
        $dayColumn = ucfirst(strtolower($day));
        $day = $_POST['day'];
        $task = $_POST['task'];

        $query = "INSERT INTO tasks ($dayColumn) VALUES (?)";
        $stmt = $connection->prepare($query);
        $stmt->blind_param("s", $task);
        if ($stmt->execute())
        {
           echo"task added succesfully to $day";
        }
        else
        {
          echo"Error: ".$connection->error;
        }
        $stmt->close();
      }
      else
      {
        echo"please fill both files";
      }
      exit;
  }
?>