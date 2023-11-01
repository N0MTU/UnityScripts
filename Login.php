<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "testdb";


//variables from user
$loginuser = $_POST["loginuser"];
$loginpass = $_POST["loginpass"];

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
die("Connection failed: " . $conn->connect_error);

}

echo "CONNECTED SUCCESSFULLY". "<br>";
// Get user password
$sql = "SELECT password FROM users WHERE username = '" . $loginuser . "'";

$result = $conn->query($sql);

if ($result->num_rows > 0){
    while($row = $result->fetch_assoc()){
        if($row["password"] == $loginpass){
            echo "Login Successful";

            //get user data
            
            
        }
        else {
            echo "Login Failed";
        }  
    }
} else {
    echo "0 results";
}
$conn->close();
?>
