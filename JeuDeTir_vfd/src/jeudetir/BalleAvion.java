/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.awt.Rectangle;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

/**
 *
 * @author sekouzed
 */
public class BalleAvion extends Balle {
    int limiteBAS,limiteHAUT=0,limiteGAUCHE=0,limiteDROIT;
    public BalleAvion() {
        dx=5;dy=10;largeur=15;longueur=14;limiteDROIT=InterfaceDuJeu.jeu.terainDeJeu.getWidth();limiteBAS=InterfaceDuJeu.jeu.terainDeJeu.getHeight()-20;
        this.setIcon(new ImageIcon(getClass().getResource("/jeudetir/image/missil.gif")));
        this.setBounds(x, y, largeur, longueur);
        InterfaceDuJeu.jeu.terainDeJeu.add(this);
        InterfaceDuJeu.jeu.terainDeJeu .repaint();
    
        deplacer =new Thread(){
       @Override
        public void run(){
            while (y+longueur < limiteBAS && InterfaceDuJeu.jeu.canonDuJoueur!=null){
                    if(new Rectangle(InterfaceDuJeu.jeu.canonDuJoueur.x, InterfaceDuJeu.jeu.canonDuJoueur.y, InterfaceDuJeu.jeu.canonDuJoueur.largeur,InterfaceDuJeu.jeu.canonDuJoueur.longueur).intersects( new Rectangle(x, y,largeur,longueur))) {
                        
                        InterfaceDuJeu.jeu.vieProgress.setValue(InterfaceDuJeu.jeu.vieDuCanon--);
                        Explossion boom=new Explossion(InterfaceDuJeu.jeu.canonDuJoueur.x, InterfaceDuJeu.jeu.canonDuJoueur.y);
                        boom.start();
                        
                        if(InterfaceDuJeu.jeu.vieDuCanon==0){
                            InterfaceDuJeu.jeu.canonDuJoueur.detruire();InterfaceDuJeu.jeu.canonDuJoueur=null;
                            JOptionPane.showMessageDialog(InterfaceDuJeu.jeu.terainDeJeu,"Vous avez perdu!");
                            InterfaceDuJeu.jeu.tempDuJeu=0;
                          }
                      }
                    x+=dx; y +=dy; setLocation(x, y);
                    try { sleep(80); }catch (InterruptedException e) {}
                }
        Explossion boom=new Explossion(x-50, y-50);
        boom.start();
        detruire();
       }
    };
    }
}
