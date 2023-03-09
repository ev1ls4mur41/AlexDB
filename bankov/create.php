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
    <form action="db/create.php" method="post">
        <p>ФИО</p>
        <input type="text" name="fullname">
        <p>Дата рождения</p>
        <input type="date" name="birthday">
        <p>Пол</p>
        <input type="text" name="pol">
        <p>Адрес</p>
        <input type="text" name="address">
        <p>Телефон</p>
        <input type="text" name="phoneNumber">
        <p>Пас. данные</p>
        <input type="number" name="passport">
        <button type="submit">Создать клиента</button>
    </form>
</body>
</html>