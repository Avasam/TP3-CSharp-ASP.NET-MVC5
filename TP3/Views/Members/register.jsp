<%--
    Document   : CreerCompte
    Created on : 2017-12-08, 12:26:57
    Author     : usager
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

        <title>S'enregistrer</title>

        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Roboto:300" rel="stylesheet">
        <link href="<c:url value="/resources/css/custom.css" />" rel="stylesheet">
    </head>

    <body>
        <div class="login-page">
            <div class="form">
              </form>
              <form class="login-form" action ="register" method="post">
                <input type="email" placeholder="Adresse courriel" name="email" required/>
                <input type="text" placeholder="Nom d'utilisateur" name="username" required/>
                <input type="password" placeholder="Mot de passe" name="password" required/>
                <button id="register">Créer le compte</button>
                <p class="message">Déjà un compte? <a href="login">Se connecter</a></p>
              </form>
            </div>
        </div>
    </body>
</html>
