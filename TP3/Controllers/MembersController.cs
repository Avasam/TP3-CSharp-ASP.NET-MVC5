using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP3.Controllers {
    public class MembersController : Controller {
        public ActionResult Login() {
            return View();
        }

        public ActionResult Register() {
            return View();
        }

        public void Logout() {
        }

        // Services
        //public bool Login(string email, string password, HttpSession session) {
        //    Console.WriteLine("email:" + email);
        //    Console.WriteLine("password:" + password);
        //    User user = dao.FindByEmail(email);
        //    Console.WriteLine("user:" + user);
        //    if (user != null && password != null && password.Equals(user.password)) {
        //        session.setAttribute("User", user);
        //        return true;
        //    }
        //    return false;
        //}

        //public bool Register(string username, string email, string password) {
        //    User user = new User(email, password, username);

        //    return dao.create(user);
        //}

        //public void Logout(HttpSession session) {
        //    session.invalidate();
        //}

    }
}