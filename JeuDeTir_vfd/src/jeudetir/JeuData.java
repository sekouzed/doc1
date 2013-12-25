/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author sekouzed
 */
public class JeuData {
    private Connection dbCon ;
    private Statement stmt;
    
    public String joueur;
    public int score;
    public int vie;
    
    
    public void insert(){
        try {
            Class.forName("com.mysql.jdbc.Driver");
            dbCon= DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/jeudetir","root","");
            stmt =dbCon.createStatement();
            
            int rs=stmt.executeUpdate("INSERT INTO `jeudetir`.`info` (`id`, `joueur`, `score`, `vie`) VALUES (NULL, \""+joueur+"\", '"+score+"', '"+vie+"');");
            
            stmt.close();
            dbCon.close();
        } catch (SQLException | ClassNotFoundException ex) {
            Logger.getLogger(JeuData.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public String[][]  selectAll(){
        String[][] dataTable= new String[50][3];
        int it=0;
        try {
               Class.forName("com.mysql.jdbc.Driver");
               dbCon= DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/jeudetir","root","");
               stmt =dbCon.createStatement();
               try (ResultSet rs = stmt.executeQuery("SELECT * FROM `jeudetir`.`info` ORDER BY `info`.`score` DESC")) {
                    //dataTable= new String[20][3];
                   // System.out.println();
                   while(rs.next()) {
                      dataTable[it][0] =rs.getString("joueur");
                      dataTable[it][1] =""+rs.getInt("score");
                      dataTable[it][2] =""+rs.getInt("vie");
                        it++;
                       }
               }  
               stmt.close();
               dbCon.close();
           } catch (SQLException | ClassNotFoundException ex) {
               Logger.getLogger(JeuData.class.getName()).log(Level.SEVERE, null, ex);
           }
            return dataTable;
    }
     public void selectByJoueur(String leJoueur){
     try {
            Class.forName("com.mysql.jdbc.Driver");
            dbCon= DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/jeudetir","root","");
            stmt =dbCon.createStatement();
            ResultSet rs;
            rs = stmt.executeQuery("SELECT * FROM `jeudetir`.`info` WHERE `info`.`joueur`='"+leJoueur+"'");
            if(rs.next()) {
                 joueur=rs.getString("joueur");
                 score=rs.getInt("score");
                 vie=rs.getInt("vie");
                }
            stmt.close();
            dbCon.close();
        } catch (SQLException | ClassNotFoundException ex) {
            Logger.getLogger(JeuData.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public void meilleurScore(){
     try {
            Class.forName("com.mysql.jdbc.Driver");
            dbCon= DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/jeudetir","root","");
            stmt =dbCon.createStatement();
            ResultSet rs;
            rs = stmt.executeQuery("SELECT * FROM `jeudetir`.`info` ORDER BY `info`.`score` DESC LIMIT 0,1");
            while(rs.next()) {
                 joueur=rs.getString("joueur");
                 score=rs.getInt("score");
                 vie=rs.getInt("vie");
                }
            stmt.close();
            dbCon.close();
        } catch (SQLException | ClassNotFoundException ex) {
            Logger.getLogger(JeuData.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
