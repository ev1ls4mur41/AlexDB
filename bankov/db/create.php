<?php
require_once 'connect.php';

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

mysqli_query($connect, "INSERT INTO `Вкладчики` (`ФИО`, `Дата рождения`, `Пол`, `Адрес`, `Телефон`,
            `Паспортные данные`, `Дата вклада`, `Дата возврата`, `Код вклада`, `Cумма вклада`, `Cумма возврата`, `Отметка о возврате вклада`, `Код сотрудника`) VALUES ('$fullname', '$address', '$phonenumber', '$pasportdata', '$dateIn',
            '$dateOut', '$contributionID', '$contributionVal', '$contributionIn', '$contributionCheck', '$emploeeID')");

header('Location: ../contributor.php');