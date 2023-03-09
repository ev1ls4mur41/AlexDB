<?php
require_once 'db/connect.php';
$id = $_GET['id'];

$sql = mysqli_query($connect, "SELECT * FROM `Вкладчики` WHERE `Код` = '$id'");
$sql = mysqli_fetch_assoc($sql);
?>
<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Добавить Клиента</title>
</head>
<body>
<form action="db/update.php?id=<?=$id?>" method="post">
    <p>ФИО</p>
    <input value="<?=$sql['ФИО']?>" type="text" name="fullname">
    <p>Адрес</p>
    <input value="<?=$sql['Адрес']?>" type="text" name="adress">
    <p>Телефон</p>
    <input value="<?=$sql['Телефон']?>" type="number" name="phonenumber">
    <p>Паспортные данные</p>
    <input value="<?=$sql['Паспортные данные']?>" type="text" name="pasportdata">
    <p>Дата вклада</p>
    <input value="<?=$sql['Дата вклада']?>" type="date" name="dateIn">
    <p>Дата возврата</p>
    <input value="<?=$sql['Дата возврата']?>" type="date" name="dateOut">
    <p>Код вклада</p>
    <input value="<?=$sql['Код вклада']?>" type="number" name="contributionID">
    <p>Сумма вклада</p>
    <input value="<?=$sql['Сумма вклада']?>" type="number" name="contributionVal">
    <p>Сумма возврата</p>
    <input value="<?=$sql['Сумма возврата']?>" type="number" name="contributionIn">
    <p>Отметка о возврате вклада</p>
    <input value="<?=$sql['Отметка о возврате вклада']?>" type="number" name="contributionCheck">
    <p>Код сотрудника</p>
    <input value="<?=$sql['Код сотрудника']?>" type="number" name="emploeeID">
    <button type="submit">Обновить данные клиента</button>
</form>
</body>
</html>