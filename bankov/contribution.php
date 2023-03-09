<?php
require_once 'db/connect.php';

$sql = mysqli_query($connect, "SELECT * FROM `Вклады`");
$sql = mysqli_fetch_all($sql);
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="assets/css/style.css">
    <title>Вклады</title>
</head>
<body>
<h3>Таблица "Вклады"</h3>
<table>
    <tr>
        <th>Код</th>
        <th>Код вклада</th>
        <th>Наименование вклада</th>
        <th>Минимальный срок вклада</th>
        <th>Минимальный сумма вклада</th>
        <th>Код валюты</th>
        <th>Процентная ставка</th>
        <th>Дополнительные условия</th>
    </tr>
    <?php
    foreach ($sql as $value)
    {
        ?>
        <tr>
            <td><?=$value[0]?></td>
            <td><?=$value[1]?></td>
            <td><?=$value[2]?></td>
            <td><?=$value[3]?></td>
            <td><?=$value[4]?></td>
            <td><?=$value[5]?></td>
            <td><?=$value[6]?></td>
            <td><?=$value[7]?></td>
        </tr>
        <?php
    }
    ?>
</table>
</body>
</html>