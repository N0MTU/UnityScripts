<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "recapdb";


//variables from user
$loginuser = $_POST["loginuser"];
$loginpass = $_POST["loginpass"];

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
die("Connection failed: " . $conn->connect_error);

}

echo "CONNECTED SUCCESSFULLY FUCKING HELL YEAH IDIOTS". "<br>";
// Get user password
$sql = "SELECT username FROM users WHERE username = '" . $loginuser . "'";

$result = $conn->query($sql);

if ($result->num_rows > 0){
   echo "User already exists";
    }
 else {
    echo "Creating user...";
    $sql2 = "INSERT INTO users (username, password) VALUES ('" . $loginuser . "', '" . $loginpass . "')";
    if ($conn->query($sql2) === TRUE){
        echo "New user created!";
    } else {
        echo "Error: User not created... " . $sql2 . "<br>" . $conn->error;
    }
}
$conn->close();
?>
