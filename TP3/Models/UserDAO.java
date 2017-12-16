/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.livres.dao;

import com.livres.model.User;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

/**
 *
 * @author usager
 */
public class UserDAO extends DAO<User> {

    @Override
    public boolean create(User x) {
        String req = "INSERT INTO user (`USERNAME` , `PASSWORD` , `EMAIL`) VALUES (?, ?, ?)";
        PreparedStatement stm = null;
        try {
            stm = connexion.getInstance().prepareStatement(req);
            stm.setString(1,x.getUsername());
            stm.setString(2,x.getPassword());
            stm.setString(3,x.getEmail());
            int n= stm.executeUpdate();
            if (n>0) {
                    stm.close();
                    return true;
            }
        }
        catch (SQLException exp) {
            exp.printStackTrace();
        }
        finally {
            if (stm!=null)
            try {
                    stm.close();
            } catch (SQLException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
            }
        }
        return false;
    }

    public User FindByUsername(String username) {
        PreparedStatement stm = null;
        ResultSet r = null;
        try {
            String req="SELECT * FROM user WHERE USERNAME = ?";
            stm = connexion.getInstance().prepareStatement(req);
            stm.setString(1,username);
            r = stm.executeQuery();
            if(r.next()){
                User u = new User();
                u.setUsername(r.getString("USERNAME"));
                u.setUsername(r.getString("PASSWORD"));
                u.setUsername(r.getString("EMAIL"));
                r.close();
                stm.close();
                return u;
            }
        }
        catch(SQLException exp) {
            exp.printStackTrace();
        }
        finally {
            if (stm!=null) {
                try {
                    r.close();
                    stm.close();
                }
                catch(SQLException e) {
                    e.printStackTrace();
                }
            }
        }
        return null;
    }

    public User FindByEmail(String email) {
        PreparedStatement stm = null;
        ResultSet r = null;
        try {
            String req="SELECT * FROM user WHERE EMAIL = ?";
            stm = connexion.getInstance().prepareStatement(req);
            stm.setString(1,email);
            System.out.println(stm);
            r = stm.executeQuery();
            System.out.println(r);
            if(r.next()){
                System.out.println("test");
                User u = new User();
                u.setUsername(r.getString("USERNAME"));
                u.setPassword(r.getString("PASSWORD"));
                u.setEmail(r.getString("EMAIL"));
                r.close();
                stm.close();
                return u;
            }
        }
        catch(SQLException exp) {
            exp.printStackTrace();
        }
        finally {
            if (stm!=null) {
                try {
                    r.close();
                    stm.close();
                }
                catch(SQLException e) {
                    e.printStackTrace();
                }
            }
        }
        return null;
    }

    @Override
    public User read(int id) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public User read(String id) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public boolean update(User x) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public boolean delete(User x) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<User> findAll() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
