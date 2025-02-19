<?php

 $db_server = "localhost";
 $db_user = "root";
 $db_password = "";
 $db_name = "task_manager";
 $connection = "";

 $connection = mysqli_connect( $db_server, $db_user, $db_password, $db_name);

 if ($connection)
 {
    echo"Connected!";
 }
else
{
    echo"Can not connect!";
}



?>