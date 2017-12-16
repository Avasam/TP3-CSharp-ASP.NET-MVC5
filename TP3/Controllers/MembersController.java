/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.livres.controller;

import com.livres.model.User;
import com.livres.services.MembersService;
import javax.servlet.http.HttpSession;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

/**
 *
 * @author Moumene
 */
@Controller
public class MembersController {
    private MembersService membersService;
    public void setMembersService(MembersService membersService) {
        this.membersService = membersService;
    }

    @RequestMapping(value = "/login", method = RequestMethod.GET)
    public String pageLogin(ModelMap model, HttpSession session)  {
        System.out.println("In controller MembersController.pageLogin");

        User user = (User)session.getAttribute("User");
        if (user == null) {
            // Si l'utilisateur n'est pas déjà connecté
            return "login";
        }
        return "redirect:/";

    }

    @RequestMapping(value = "/login", method = RequestMethod.POST)
    public String login(ModelMap model, HttpSession session,
            @RequestParam("email") String email,
            @RequestParam("password") String password)  {
        System.out.println("In controller MembersController.login");

        User user = (User)session.getAttribute("User");
        if (user == null) {
            if (!membersService.login(email, password, session)){
                System.out.println("Login échoué");
                // Si le login a échoué
                return "redirect:/members/login";
            } else {
                System.out.println("Login réussit");
            }
        } // Si l'utilisateur est logged in
        return "redirect:/";

    }

    @RequestMapping(value = "/register", method = RequestMethod.GET)
    public String pageRegister(ModelMap model, HttpSession session)  {
        System.out.println("In controller MembersController.pageRegister");

        User user = (User)session.getAttribute("User");
        if (user == null) {
            // Si l'utilisateur n'est pas déjà connecté
            return "register";
        } // Si l'utilisateur est déjà connecté
        return "redirect:/";

    }

    @RequestMapping(value = "/register", method = RequestMethod.POST)
    public String register(ModelMap model, HttpSession session,
            @RequestParam("username") String username,
            @RequestParam("email") String email,
            @RequestParam("password") String password)  {
        System.out.println("In controller MembersController.register");

        User user = (User)session.getAttribute("User");
        if (user == null) {
            if(membersService.register(username, email, password)) {
                // Si le register a fonctionné
                return "redirect:/members/login";
            } // Si le register a échoué
            return "redirect:/members/register";
        } // Si l'utilisateur est déjà connecté
        return "redirect:/";

    }

    @RequestMapping("/logout")
    public String logout(ModelMap model, HttpSession session)  {
        System.out.println("In controller MembersController.logout");

        membersService.logout(session);
        return "redirect:/members/login";

    }


    //@ResponseBody
    @RequestMapping("/")
    public String welcome(ModelMap model, HttpSession session)  {
        System.out.println("In controller MembersController.welcome");

        return "redirect:/members/login";
    }

}
