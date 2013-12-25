/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

/**
 *
 * @author sekouzed
 */
public class JeuDeTir {
    
    public static InterfaceDuJeu Interface;
    public static void finDuJeu(){
        Interface.jeu.stop();Interface.jeu=null;
        Interface.dispose();
        Interface=new InterfaceDuJeu();
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Interface=new InterfaceDuJeu();
        
    }
}
