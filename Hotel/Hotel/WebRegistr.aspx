﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRegistr.aspx.cs" Inherits="Hotel.WebRegistr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div>
            <h1>Регестрация</h1>
        </div>
        <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
        <div>
            <label>Логин:</label><input type="text" id="login" runat="server"/>
        </div>
        <div>
            <label>Пароль:</label><input type="text" id="password" runat="server"/>
        </div>
        <div>
            <label>Телефон:</label><input type="text" id="phone" runat="server"/>
        </div>
        <div>
            <label>Email:</label><input type="text" id="email" runat="server"/>
        </div>
        <div>
            <button type="submit">Подтвердить</button>
        </div>
    </form>
</body>
</html>
