/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.livres.model;

/**
 *
 * @author usager
 */
public class Livre {
    
    private String ISBN;
    private String Author;
    private String Title;
    private int NB_Pages;
    private String Edition;
    private int Year;
    private String Language;
    private String Description;
    private String Keywords;

    public void setKeywords(String Keywords) {
        this.Keywords = Keywords;
    }

    public String getKeywords() {
        return Keywords;
    }
    
    public void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    public void setAuthor(String Author) {
        this.Author = Author;
    }

    public void setTitle(String Title) {
        this.Title = Title;
    }

    public void setNB_Pages(int NB_Pages) {
        this.NB_Pages = NB_Pages;
    }

    public void setEdition(String Edition) {
        this.Edition = Edition;
    }

    public void setYear(int Year) {
        this.Year = Year;
    }

    public void setLanguage(String Languge) {
        this.Language = Languge;
    }

    public void setDescription(String Description) {
        this.Description = Description;
    }

    public String getISBN() {
        return ISBN;
    }

    public String getAuthor() {
        return Author;
    }

    public String getTitle() {
        return Title;
    }

    public int getNB_Pages() {
        return NB_Pages;
    }

    public String getEdition() {
        return Edition;
    }

    public int getYear() {
        return Year;
    }

    public String getLanguage() {
        return Language;
    }

    public String getDescription() {
        return Description;
    }
    
}
