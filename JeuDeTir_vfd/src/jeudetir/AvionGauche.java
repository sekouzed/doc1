/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import javax.swing.ImageIcon;

/**
 *
 * @author sekouzed
 */
public class AvionGauche extends Avion {//*******************Avion qui sort a gauche
    public AvionGauche() {
        this.x=-largeur;this.y =(int)(Math.random() *  80) + 30;this.dx = (int)(Math.random() *  6) + 4;
        this.setIcon(new ImageIcon(getClass().getResource("/jeudetir/image/avionGauche.png")));
        this.setBounds(x, y, largeur, longueur);
        InterfaceDuJeu.jeu.terainDeJeu.add(this);
        InterfaceDuJeu.jeu.terainDeJeu.repaint();
        
       deplacer=new Thread() {
        @Override
        public void run() {
            try {
              while (!interrupted() &&  InterfaceDuJeu.jeu.canonDuJoueur!=null) {
                if(x< InterfaceDuJeu.jeu.terainDeJeu.getWidth()){
                     x += dx;
                 }
                else {
                        x=-largeur;    y=(int)(Math.random() * 80) + 20;
                    }
                setLocation(x, y);sleep(60);
              }
              detruire();
            }
            catch (InterruptedException e) {}
        }
    };
    }
}
