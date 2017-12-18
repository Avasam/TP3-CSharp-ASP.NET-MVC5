using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3.Models;

namespace TP3.Controllers {
    public class MembersController : Controller {
        public ActionResult Login() {
            System.Diagnostics.Debug.WriteLine("Dans login PAS action");
            if (Session["User"] == null) {
                // Si l'utilisateur n'est pas déjà connecté
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register() {
            if (Session["User"] == null) {
                // Si l'utilisateur n'est pas déjà connecté
                return View();
            } // Si l'utilisateur est déjà connecté
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LoginAction(string email, string password) {
            System.Diagnostics.Debug.WriteLine("Email: "+email + " Password: " + password);
            if (Session["User"] == null) {
                Dal dal = new Dal();
                User user = dal.FindUserByEmail(email);
                if (user == null || password == null || !password.Equals(user.Password)) {
                    System.Diagnostics.Debug.WriteLine("Login échoué");
                    // Si le login a échoué
                    return RedirectToAction("Login", "Members");
                } else {
                    System.Diagnostics.Debug.WriteLine("Login réussit");
                    Session.Add("User", user);
                }
            } // Si l'utilisateur est logged in
            return RedirectToAction("Index", "Home");
        }

        public ActionResult RegisterAction(string username, string password, string email) {
            if (Session["User"] == null) {
                Dal dal = new Dal();
                if (dal.CreateUser(username, password, email)) {
                    // Si le register a fonctionné
                    return RedirectToAction("Login", "Members");
                } // Si le register a échoué
                return RedirectToAction("Register", "Members");
            } // Si l'utilisateur est déjà connecté
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LogoutAction() {
            Session.Abandon();
            return RedirectToAction("Login", "Members");
        }

    }
}