/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author sekouzed
 */
public class Canon extends JLabel{
    int x=0,y=420,dx=10,largeur=55,longueur=60,limiteTrajetDroite,limiteTrajetGauche;
    ImageIcon img1,img2;boolean deplacerAgauche;
    public Canon() {
        limiteTrajetDroite=InterfaceDuJeu.jeu.terainDeJeu.getWidth()-5;limiteTrajetGauche=5;
        y=InterfaceDuJeu.jeu.terainDeJeu.size().height-65;
        x=InterfaceDuJeu.jeu.terainDeJeu.size().width/2;
        img1=new ImageIcon(getClass().getResource("/jeudetir/image/canon1.png"));img2=new ImageIcon(getClass().getResource("/jeudetir/image/canon2.png"));
        this.setIcon(img1);deplacerAgauche=true;
        this.setBounds(x, y, largeur, longueur);
        InterfaceDuJeu.jeu.terainDeJeu.add(this);
        InterfaceDuJeu.jeu.terainDeJeu.repaint();
    }
    public void DeplacerAdroit(){  
        this.setIcon(img2);deplacerAgauche=false;
       if(x+largeur < limiteTrajetDroite){
            x += dx;  
        }else {
            x=limiteTrajetDroite-largeur;
        }
        this.setLocation(x, y);
    }
    public void DeplacerAgauche(){  
        this.setIcon(img1);deplacerAgauche=true;
       if(x > limiteTrajetGauche){
            x -= dx;  
        }else {
            x=limiteTrajetGauche;
        }
        
        this.setLocation(x, y);
    }
   
    public void tirer(){
        try {
            EffetSonor sonDeTir=new EffetSonor("son/gun.wav", false);
            BalleCanon b= new BalleCanon(deplacerAgauche);
            sonDeTir.start();
            if(deplacerAgauche)
                b.lancer(x+2, y);
            else
                b.lancer(x+32, y);
        }
        catch (Exception e) {}
    }
    
    public void detruire() {
        Explossion boom=new Explossion(x, y);
        boom.start();
       InterfaceDuJeu.jeu.terainDeJeu.remove(this);
       InterfaceDuJeu.jeu.terainDeJeu.repaint();
    }
}
