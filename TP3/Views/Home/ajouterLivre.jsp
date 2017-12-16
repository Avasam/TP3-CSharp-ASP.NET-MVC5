<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

        <title>Ajouter un livre</title>

        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Roboto:300" rel="stylesheet">
        <link href="<c:url value="/resources/css/custom.css" />" rel="stylesheet">
    </head>

    <body>
        <div class="container">

            <nav class="navbar navbar-default">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <a class="navbar-brand" href="/">Livres</a>
                    </div>
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="ajouterLivre">Ajouter un livre</a></li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li class="active pull-right"><a href="members/logout">Déconnexion</a></li>
                    </ul>
                </div>
            </nav>

            <div class="col-xs-offset-1 col-xs-10" style="border-style:solid;">

                <form class="container-fluid login-form" action="ajouterLivre" method="post">
                    <div class="row">
                        <div class="form-group">
                            <label>Ajouter un Livre</label>
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="isbn">ISBN:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="isbn" id="isbn" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="author">Auteur:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="author" id="author" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="title">Titre:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="title" id="title" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="nb_pages">Nombre de pages:</label>
                        <div class="form-group col-xs-7">
                            <input type="number" class="form-control" name="nb_pages" id="nb_pages" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="edition">Edition:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="edition" id="edition" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="year">Année:</label>
                        <div class="form-group col-xs-7">
                            <input type="number" maxlength="4" class="form-control" value="2017" name="year" id="year" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="language">Langue:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="language" id="language" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="description">Description:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="description" id="description" required />
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-xs-5" for="keywords">Mots clés:</label>
                        <div class="form-group col-xs-7">
                            <input type="text" class="form-control" name="keywords" id="keywords" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col-xs-12">
                            <button class="form-control">Ajouter le livre</button>
                        </div>
                    </div>
                </form>

            </div>
        </div>
    </body>
</html>
