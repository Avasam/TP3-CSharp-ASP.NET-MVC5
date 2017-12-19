using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TP3.Models;

namespace TP3.Controllers {
    public class MembersController : Controller {
        [AllowAnonymous]
        public ActionResult Login() {
            System.Diagnostics.Debug.WriteLine("Dans login PAS action");
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register() {
            return View();
        }

        [AllowAnonymous]
        public ActionResult LoginAction(string email, string password) {
            System.Diagnostics.Debug.WriteLine("Email: "+email + " Password: " + password);
            Dal dal = new Dal();
            User user = dal.FindUserByEmail(email);
            if (user == null || password == null || !password.Equals(user.Password)) {
                System.Diagnostics.Debug.WriteLine("Login échoué");
                // Si le login a échoué
                return RedirectToAction("Login", "Members");
            } else {
                System.Diagnostics.Debug.WriteLine("Login réussit");
                FormsAuthentication.SetAuthCookie(user.Email, true);
                Roles.CreateRole(user.Role);
                Roles.AddUserToRole(user.Email, user.Role);
                return RedirectToAction("Index", "Home");
            }

        }

        [AllowAnonymous]
        public ActionResult RegisterAction(string username, string password, string email) {
            Dal dal = new Dal();
            if (dal.CreateUser(username, password, email)) {
                // Si le register a fonctionné
                return RedirectToAction("Login", "Members");
            } // Si le register a échoué
            return RedirectToAction("Register", "Members");
        }

        [Authorize]
        public ActionResult LogoutAction() {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Members");
        }

    }
}