/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.livres.controller;

import com.livres.model.Livre;
import com.livres.model.User;
import com.livres.services.LivreService;
import java.util.List;
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
public class BooksController {

    private LivreService livreService;

    public void setLivreService(LivreService livreService)
    {
        this.livreService = livreService;
    }

    //@ResponseBody
    @RequestMapping("/")
    public String welcome(ModelMap model, HttpSession session)  {
        System.out.println("In controller BooksController");
        User user = (User)session.getAttribute("User");
        //si l'utilisateur est connecté
        if (user != null) {
            System.out.println("(user != null)");
            List<Livre> listeDeLivre = livreService.obtenirListeLivre();
            System.out.println("Taille de la liste de livres: "+listeDeLivre.size());
            model.put("listeDeLivre", listeDeLivre);
            return "index";
        } else {
            System.out.println("do a redirect");
            return "redirect:/members/login";
        }
    }

    @RequestMapping(value = "/ajouterLivre",method = RequestMethod.GET)
    public String ajouterLivrePage(ModelMap model, HttpSession session ) {
        System.out.println("In controller BooksController.ajouterLivrePage");
        User user = (User)session.getAttribute("User");

        if (user != null) {
            return "ajouterLivre";
        }
        return "redirect:/members/login";
    }

    @RequestMapping(value = "/ajouterLivre",method = RequestMethod.POST)
    public String ajouterLivre(ModelMap model, HttpSession session,
            @RequestParam("isbn") String isbn,
            @RequestParam("author") String author,
            @RequestParam("title") String title,
            @RequestParam("nb_pages") int nb_pages,
            @RequestParam("edition") String edition,
            @RequestParam("year") int year,
            @RequestParam("language") String language,
            @RequestParam("description") String description,
            @RequestParam("keywords") String keywords) {
        System.out.println("In controller BooksController.ajouterLivre");


        User user = (User)session.getAttribute("User");

        if (user != null) {

            if(livreService.ajouterLivre(isbn,author,title,nb_pages,edition, year,language,description,keywords)){
                System.out.println("Redirecting to /");
                // Si le livre est ajouté avec succès
                return "redirect:/";
            }
            System.out.println("Redirecting to /ajouterLivre");
            // Si l'ajout du livre échoue
            return "redirect:/ajouterLivre";
        }
        System.out.println("Redirecting to /members/login");
        // Si l'utilisateur n'est pas connecté
        return "redirect:/members/login";


    }



    //@ResponseBody
//    @RequestMapping(method = RequestMethod.GET, value="/", params={"nom"})
//    public String convert(@RequestParam("nom") String nom, ModelMap model) {
//        model.addAttribute("message", "1 "+nom+" vaut "+converterService.getTaux(nom)+" $CAN");
//        return "convert";
//    }
}
