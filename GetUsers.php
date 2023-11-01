<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "testdb1";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
die("Connection failed: " . $conn->connect_error);

}

echo "CONNECTED SUCCESSFULLY". "<br>";

$sql = "SELECT id, username, password FROM users";
$result = $conn->query($sql);

if ($result->num_rows > 0){
    while($row = $result->fetch_assoc()){
        echo "username: " . $row['username'] . "<br>". " password: " . $row['password']. "<br>";
    }
} else {
    echo "0 results";
}
$conn->close();
?>
