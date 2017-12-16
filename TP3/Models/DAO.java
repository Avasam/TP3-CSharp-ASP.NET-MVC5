/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.livres.dao;

import com.livres.jdbc.Connexion;
import java.util.List;

/**
 *
 * @author usager
 * @param <T>
 */
public abstract class DAO<T> {
	protected Connexion connexion;

	public void setConnexion(Connexion connexion) {
		this.connexion = connexion;
	}

	public abstract boolean create(T x);    //INSERT
	public abstract T read(int id);         //SELECT
	public abstract T read(String id);      //SELECT
	public abstract boolean update(T x);    //UPDATE
	public abstract boolean delete(T x);    //DELETE
	public abstract List<T> findAll();      //SELECT
}
