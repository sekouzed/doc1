/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.awt.Font;
import java.awt.Rectangle;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author sekouzed
 */
public class BalleCanon extends Balle {
    boolean deplacerAgauche;ImageIcon img1,img2;
    public BalleCanon(boolean deplacerAgauche){
       largeur=20;longueur=23;this.deplacerAgauche=deplacerAgauche;
       img1=new ImageIcon(getClass().getResource("/jeudetir/image/rocket1.png"));img2=new ImageIcon(getClass().getResource("/jeudetir/image/rocket2.png"));
       if(deplacerAgauche)
           deplacerGauche();
       else 
           deplacerDroite();
       this.setBounds(x, y, largeur, longueur);
       InterfaceDuJeu.jeu.terainDeJeu.add(this);
       InterfaceDuJeu.jeu.terainDeJeu .repaint();
    }
    
    public void deplacerGauche(){
       this.setIcon(img1);//dx=2;dy=3;
       deplacer =new Thread(){
       @Override
        public void run(){
            while( y+longueur > 0){
                for (Avion A : InterfaceDuJeu.jeu.listeDesAvions) {
                      if(new Rectangle(A.x, A.y, A.largeur, A.longueur).intersects( new Rectangle(x, y,largeur,longueur))) {
                          
                             InterfaceDuJeu.jeu.score+=10;
                             A.detruire();
                             InterfaceDuJeu.jeu.listeDesAvions.remove(A);
                             
                InterfaceDuJeu.jeu.terainDeJeu.remove(InterfaceDuJeu.jeu.monScore);
                InterfaceDuJeu.jeu.monScore=new JLabel(InterfaceDuJeu.jeu.nomDuJoueur+", score : "+InterfaceDuJeu.jeu.score);
                InterfaceDuJeu.jeu.monScore.setFont((new Font("Monotype Corsiva", 1, 20)));
                InterfaceDuJeu.jeu.monScore.setBounds(15,30, 400, 50);InterfaceDuJeu.jeu.terainDeJeu.add(InterfaceDuJeu.jeu.monScore,1);
                
                             detruire();
                      }
                    }
                  x-=2; y-=3;  setLocation(x, y);
                    try { sleep(15); }catch (InterruptedException e) {}
                }
               detruire();
       }
    };
    }
    
     public void deplacerDroite(){
       this.setIcon(img2);
       deplacer =new Thread(){
       @Override
        public void run(){
            while( y+longueur > 0){
                for (Avion A : InterfaceDuJeu.jeu.listeDesAvions) {
                      if(new Rectangle(A.x, A.y, A.largeur, A.longueur).intersects( new Rectangle(x, y,largeur,longueur))) {
                          
                             InterfaceDuJeu.jeu.score+=10;
                             A.detruire();
                             InterfaceDuJeu.jeu.listeDesAvions.remove(A);
                                           
                InterfaceDuJeu.jeu.terainDeJeu.remove(InterfaceDuJeu.jeu.monScore);
                InterfaceDuJeu.jeu.monScore=new JLabel(InterfaceDuJeu.jeu.nomDuJoueur+", score : "+InterfaceDuJeu.jeu.score);
                InterfaceDuJeu.jeu.monScore.setFont((new Font("Monotype Corsiva", 1, 20)));
                InterfaceDuJeu.jeu.monScore.setBounds(15,30, 400, 50);InterfaceDuJeu.jeu.terainDeJeu.add(InterfaceDuJeu.jeu.monScore,1);
                
                             detruire();
                      }
                    }
                  x+=2;  y-=3;  setLocation(x, y);

                    try { sleep(15); }catch (InterruptedException e) {}
                }
               detruire();
       }
    };    
    }
}
