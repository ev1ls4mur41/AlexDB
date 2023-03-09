<?php
require_once 'connect.php';

$id = $_GET['Код'];

mysqli_query($connect,"DELETE FROM `Вкладчики` WHERE `Код читателя` = '$id'");

header('Location: ../contributor.php');
