<?php
  if($_SERVER["REQUEST_METHOD"]=="POST")
  {
	  $day = $_POST["day"];
	  $task = $_POST["task"];
	  $null = null;
	  
	  try
	  {
		require_once"database.php";
		$query = "INSERT INTo tasks (Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday) VALUES (?, ?, ?, ?, ?, ?, ?);";
		$stmt = $pdo->prepare($query);

        if ($day == "Monday")
        {
			$stmt -> execute([$task, $null, $null, $null, $null, $null, $null]);
		}
        else if($day == "Tuesday")
        {
			$stmt -> execute([$null, $task, $null, $null, $null, $null, $null]);
		}
        else if($day == "Wednesday")
        {
			$stmt -> execute([$null, $null, $task, $null, $null, $null, $null]);
		}
        else if($day == "Thursday")
        {
			$stmt -> execute([$null, $null, $null, $task, $null, $null, $null]);
		}
        else if($day == "Friday")
        {
			$stmt -> execute([$null, $null, $null, $null, $task, $null, $null]);
		}
        else if($day == "Saturday")
        {
			$stmt -> execute([$null, $null, $null, $null, $null, $task, $null]);
		}
		else
		{
			$stmt -> execute([$null, $null, $null, $null, $null, $null, $task]);
			
		}
          	
        $stmt = null;
        $pdo = null;
        header("location: ../Task_manager/index.php");	
        die();		
	  }
	  catch(PDOException $e)
	  {
		  die("Querry failed: " . $e->getMessage());
	  }
  }
  else
  {
	  header("location: ../Task_manager/index.php");	
  }
?>