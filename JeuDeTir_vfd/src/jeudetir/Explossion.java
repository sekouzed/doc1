/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author sekouzed
 */
public class Explossion extends Thread{
    JLabel exp;// int x, y;
    public Explossion(int x,int y){
       // this.x=x;this.y=y;
        exp=new JLabel(new ImageIcon(getClass().getResource("/jeudetir/image/explosion2.gif")));
        exp.setBounds(x, y, 100, 88);
        InterfaceDuJeu.jeu.terainDeJeu.add(exp,1);
    }
    
    @Override
    public void run(){
        EffetSonor sonExpl=new EffetSonor("son/explosion.wav", false);
        sonExpl.start();
        try {
            sleep(1000);
        } catch (InterruptedException ex) {
            Logger.getLogger(Explossion.class.getName()).log(Level.SEVERE, null, ex);
        }
        InterfaceDuJeu.jeu.terainDeJeu.remove(exp);
        InterfaceDuJeu.jeu.terainDeJeu.repaint();
    }
}
