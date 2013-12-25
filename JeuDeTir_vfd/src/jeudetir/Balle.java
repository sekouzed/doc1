/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import javax.swing.JLabel;

/**
 *
 * @author sekouzed
 */
public abstract class Balle extends JLabel {
   protected int x,y,dx=2,dy=10,a,b,largeur=15,longueur=40;
   protected Thread deplacer;
    
    public void lancer(int x, int y ) {
        dx=(InterfaceDuJeu.jeu.canonDuJoueur.x-x)/40;
        dy=(InterfaceDuJeu.jeu.canonDuJoueur.y-y)/40;
        this.x = x;this.y = y;
        deplacer.start();
    }
    
    public void detruire() {
       deplacer.interrupt();
       InterfaceDuJeu.jeu.terainDeJeu.remove(this);
       InterfaceDuJeu.jeu.terainDeJeu.repaint();
    }
}
