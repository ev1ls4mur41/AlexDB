<?php
require_once 'connect.php';

$id = $_GET['Код'];

$fullname = $_POST['ФИО'];
$address = $_POST['Адрес'];
$phonenumber = $_POST['Телефон'];
$pasportdata = $_POST['Паспортные данные'];
$dateIn = $_POST['Дата вклада'];
$dateOut = $_POST['Дата возврата'];
$contributionID = $_POST['Код вклада'];
$contributionVal = $_POST['Cумма вклада'];
$contributionIn = $_POST['Cумма возврата'];
$contributionCheck = $_POST['Отметка о возврате вклада'];
$emploeeID = $_POST['Код сотрудника'];

mysqli_query($connect, "UPDATE `Вкладчики` SET `ФИО` = '$fullname', `Адрес` = '$address', `Телефон` =
    '$phonenumber', `Паспортные данные` = '$pasportdata', `Дата вклада` = '$dateIn' , `Дата возврата` = '$dateOut', `Код вклада` = '$contributionID', `Cумма вклада` = '$contributionVal', `Cумма возврата` = '$contributionIn', `Отметка о возврате вклада` = '$contributionCheck', `Код сотрудника` = '$emploeeID'
     WHERE `Код` = '$id'");

header('Location: ../contributor.php');