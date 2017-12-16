<%--
    Document   : connexion
    Created on : 2017-12-04, 14:54:01
    Author     : usager
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

        <title>Connexion</title>

        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Roboto:300" rel="stylesheet">
        <link href="<c:url value="/resources/css/custom.css" />" rel="stylesheet">
    </head>

    <body>
        <div class="login-page">
            <div class="form">

              <form class="login-form" action="login" method="post">
                <input type="email" placeholder="Adresse courriel" name="email" required/>
                <input type="password" placeholder="Mot de passe" name="password" required/>
                <button type='submit'>Se connecter</button>
                <p class="message">Nouvel utilisateur? <a href="register">Créer un Compte</a></p>
              </form>
            </div>
        </div>
    </body>
</html>
