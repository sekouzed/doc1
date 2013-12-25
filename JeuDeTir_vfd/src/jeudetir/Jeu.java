/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.awt.BorderLayout;
import java.awt.Cursor;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.util.ArrayList;
import java.util.List;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JProgressBar;
import javax.swing.Timer;
import sun.java2d.Disposer;

/**
 *
 * @author sekouzed
 */
public class Jeu  extends Thread{
    InterfaceDuJeu nouvelInterface;
    public JPanel terainDeJeu ;
    public String nomDuJoueur;
    public Canon canonDuJoueur;
    public int score=0,vieDuCanon=50,tempDuJeu=60;
    static AvionGauche enemi1;   static AvionDroite enemi2;
    public List<Avion> listeDesAvions;
    static ActionListener actionChrono;
    public EffetSonor sonDeFond;
    static Timer topChrono;boolean pause=false;
    public JProgressBar vieProgress,chrono;
    public JLabel infoVie, infoChrono, monScore,meilleurScore,touslesScores,quitter, lab;
    
    public void JeuInit(int vie,int temps) {
        nouvelInterface=JeuDeTir.Interface;
        terainDeJeu = new JPanel(){
            @Override
            public void paintComponent(Graphics g) 
            {
               ImageIcon imageDeFond = new ImageIcon(getClass().getResource("/jeudetir/image/fond2.jpg"));
                Image img = imageDeFond.getImage();
                g.drawImage(img, 0, 0, null);
            }
        };
        vieDuCanon=vie;tempDuJeu=temps;
        nouvelInterface.add(terainDeJeu);
     
        nouvelInterface.setLayout(new BorderLayout());
        nouvelInterface.add(terainDeJeu, BorderLayout.CENTER);
        nouvelInterface.pack ();

        terainDeJeu.removeAll();
        listeDesAvions=new ArrayList<>();
        
        
        
        infoVie=new JLabel("Vie du canon");
        infoVie.setBounds(15,25, 100, 15);terainDeJeu.add(infoVie);
        vieProgress=new JProgressBar(0, 0, 50);vieProgress.setValue(vieDuCanon);
        vieProgress.setBounds(10,25, 200, 15);terainDeJeu.add(vieProgress);
        
        infoChrono=new JLabel("Temps");
        infoChrono.setBounds(15,7, 100, 15);terainDeJeu.add(infoChrono);
        chrono=new JProgressBar(0, 0, tempDuJeu);chrono.setValue(tempDuJeu);
        chrono.setBounds(10, 7, terainDeJeu.getWidth()-20, 15);terainDeJeu.add(chrono);
        
       
        monScore=new JLabel(nomDuJoueur+", score : "+score);
        monScore.setFont((new Font("Monotype Corsiva", 1, 20)));
        monScore.setBounds(15,30, 400, 50);terainDeJeu.add(monScore,1);
        
        meilleurScore=new JLabel(new ImageIcon(getClass().getResource("/jeudetir/image/hScore.png")));
        meilleurScore.setBounds(terainDeJeu.getWidth()-491,25, 178, 30);terainDeJeu.add(meilleurScore);
        meilleurScore.setCursor(new Cursor(java.awt.Cursor.HAND_CURSOR));
        meilleurScore.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(java.awt.event.MouseEvent evt) {
                JeuData h=new JeuData();
                h.meilleurScore();
                JOptionPane.showMessageDialog(null,"Joueur : "+h.joueur+"   vie : "+h.vie+"    score : "+h.score,"Meilleur score",JOptionPane.OK_OPTION);
            }
        });
        
        touslesScores=new JLabel(new ImageIcon(getClass().getResource("/jeudetir/image/allScore.png")));
        touslesScores.setBounds(terainDeJeu.getWidth()-303,25, 172, 30);terainDeJeu.add(touslesScores);
        touslesScores.setCursor(new Cursor(java.awt.Cursor.HAND_CURSOR));
        touslesScores.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(java.awt.event.MouseEvent evt) {
                TableScores scoreT=new TableScores();
                scoreT.show();
            }
        });
        
        
        quitter=new JLabel(new ImageIcon(getClass().getResource("/jeudetir/image/quitter.png")));
        quitter.setBounds(terainDeJeu.getWidth()-121,25, 111, 30);terainDeJeu.add(quitter);
        quitter.setCursor(new Cursor(java.awt.Cursor.HAND_CURSOR));
        quitter.addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(java.awt.event.MouseEvent evt) {
                int n=JOptionPane.showConfirmDialog(null, "Voulez-vous enregistrer la partie", "Enregistrement de la partie",JOptionPane.YES_NO_OPTION);
                
                if (n == JOptionPane.YES_OPTION){
                      JeuData save=new JeuData();
                      save.score=score;
                      save.vie=vieDuCanon;
                      save.joueur=nomDuJoueur;
                      save.insert();
                }
                sonDeFond.sonDeFont.stop();sonDeFond=null;//tempDuJeu=0;
                JeuDeTir.finDuJeu();
            }
        });
        
        
        
        terainDeJeu.repaint();
        
        
        canonDuJoueur=new Canon();
        sonDeFond=new EffetSonor("son/fond1.wav", true);
        sonDeFond.start();
        
        actionChrono= new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) { tempDuJeu--;  }
        };
        
        
        topChrono=new Timer(1000, actionChrono);
        topChrono.start();
    }
    
    
    public void run(){
            JeuInit(vieDuCanon,60);
            while(tempDuJeu>0){
                if(!pause){
                    if(((int)(Math.random() * 2) + 1)==1){
                        enemi1 = new AvionGauche();
                        listeDesAvions.add(enemi1);
                        enemi1.demarrer();
                    }
                    else{
                        enemi2 = new AvionDroite();
                        listeDesAvions.add(enemi2);
                        enemi2.demarrer();
                    }
                    try {
                        sleep((int)(Math.random() * 3000) + 500);
                    } catch (InterruptedException ex) {}
                   chrono.setValue(tempDuJeu);
                }
            }
            
            canonDuJoueur.detruire();canonDuJoueur=null;
            topChrono.stop();
            JOptionPane.showMessageDialog(terainDeJeu,
                    "Fin du Jeu !!\nVous avez descendu "+score/10+" avion(s)"+
                    "\nvotre score est "+score);
        }
}
