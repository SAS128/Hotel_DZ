<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Hotel.aspx.cs" Inherits="Hotel.Login_Hotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <p>Вход в отель</p>
        </div>
        <div>
            <label>Ваше имя:</label><input type="text" id="name" runat="server"/>
        </div>
        <div>
            <label>Логин</label><input type="text" id="login" runat="server"/>
        </div>
         <div>
            <label>Пароль</label><input type="text" id="password" runat="server"/>
        </div>
         -  <div>
            <label>Укажите ваш статус входа</label>
            <select id="Logical_parts" runat="server">
                <option value="">Админ</option>
                <option value="true">Пользователь</option>
            </select>
        </div>
    </form>
</body>
</html>
