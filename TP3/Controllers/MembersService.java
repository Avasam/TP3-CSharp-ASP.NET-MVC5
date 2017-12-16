/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.livres.services;

import com.livres.dao.UserDAO;
import com.livres.model.User;
import javax.servlet.http.HttpSession;


/**
 *
 * @author Moumene
 */
public class MembersService {

    private UserDAO dao;

    public void setDao(UserDAO dao) {
        this.dao = dao;
    }

    public boolean login(String email, String password, HttpSession session) {
        System.out.println("email:"+email);
        System.out.println("password:"+password);
        User user = dao.FindByEmail(email);
        System.out.println("user:"+user);
        if (user != null && password != null && password.equals(user.getPassword())) {
            session.setAttribute("User", user);
            return true;
        }
        return false;
    }

    public boolean register(String username, String email, String password) {
        User user = new User();
        user.setEmail(email);
        user.setPassword(password);
        user.setUsername(username);

        return dao.create(user);
    }

    public void logout(HttpSession session) {
        session.invalidate();
    }

}
