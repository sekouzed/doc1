/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JLabel;
import javax.swing.Timer;

/**
 *
 * @author sekouzed
 */
public abstract class Avion extends JLabel {
    protected int x=0,y=25,dx=5, largeur=120,longueur=120;
    protected Thread deplacer;
     
    ActionListener tirerPerformer = new ActionListener() {
        @Override
        public void actionPerformed(ActionEvent evt) {tirer(); }
    };
    Timer delaiDeTir=new Timer((int)(Math.random() * 5000) + 1000, tirerPerformer);
    
    private void tirer(){
        try {
            BalleAvion b= new BalleAvion();
            b.lancer(x+60, y+60);
        }
        catch (Exception e) {}
    }
    
    
    public void demarrer(){ 
       delaiDeTir.start(); deplacer.start();
    }
    
    public void detruire() {
        delaiDeTir.stop(); deplacer.interrupt();
        Explossion boom=new Explossion(x, y+10);
        boom.start();
        InterfaceDuJeu.jeu.terainDeJeu.remove(this);
        InterfaceDuJeu.jeu.terainDeJeu.repaint();
    }
}
