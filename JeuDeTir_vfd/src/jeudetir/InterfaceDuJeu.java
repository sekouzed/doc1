/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.awt.Graphics;
import java.awt.Image;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import javax.swing.JPanel;


/**
 *
 * @author sekouzed
 */
public class InterfaceDuJeu extends javax.swing.JFrame {

    /**
     * Creates new form InterfaceDuJeu
     */;
    public static Jeu jeu;EffetSonor sonDeFond;
    public InterfaceDuJeu() {
        initComponents();
        setLocationRelativeTo(null);
            jeu =new Jeu();
        show();
        sonDeFond=new EffetSonor("son/fond2.wav", true);
        sonDeFond.start();
    }
    
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        fondAcceuil = new JPanel(){
            @Override
            public void paintComponent(Graphics g) 
            {
                ImageIcon imageDeFond = new ImageIcon(getClass().getResource("/jeudetir/image/fond1.jpg"));
                Image img = imageDeFond.getImage();
                g.drawImage(img, 0, 0, null);
            }
        };
        titre = new javax.swing.JLabel();
        nouveauJeu = new javax.swing.JLabel();
        continuerJeu = new javax.swing.JLabel();
        auteur = new javax.swing.JLabel();
        logo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(new java.awt.Color(0, 0, 0));
        setMaximumSize(new java.awt.Dimension(800, 559));
        setMinimumSize(new java.awt.Dimension(800, 559));
        setPreferredSize(new java.awt.Dimension(800, 559));
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                formKeyPressed(evt);
            }
        });

        fondAcceuil.setMaximumSize(new java.awt.Dimension(800, 559));
        fondAcceuil.setMinimumSize(new java.awt.Dimension(800, 559));
        fondAcceuil.setPreferredSize(new java.awt.Dimension(800, 559));

        titre.setIcon(new javax.swing.ImageIcon(getClass().getResource("/jeudetir/image/titre.png"))); // NOI18N

        nouveauJeu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/jeudetir/image/nouvo.png"))); // NOI18N
        nouveauJeu.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        nouveauJeu.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                nouveauJeuMousePressed(evt);
            }
        });

        continuerJeu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/jeudetir/image/continu.png"))); // NOI18N
        continuerJeu.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        continuerJeu.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mousePressed(java.awt.event.MouseEvent evt) {
                continuerJeuMousePressed(evt);
            }
        });

        auteur.setIcon(new javax.swing.ImageIcon(getClass().getResource("/jeudetir/image/auteur.png"))); // NOI18N

        logo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/jeudetir/image/avion.png"))); // NOI18N

        javax.swing.GroupLayout fondAcceuilLayout = new javax.swing.GroupLayout(fondAcceuil);
        fondAcceuil.setLayout(fondAcceuilLayout);
        fondAcceuilLayout.setHorizontalGroup(
            fondAcceuilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(fondAcceuilLayout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(nouveauJeu, javax.swing.GroupLayout.PREFERRED_SIZE, 209, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(continuerJeu)
                .addGap(175, 175, 175))
            .addGroup(fondAcceuilLayout.createSequentialGroup()
                .addContainerGap(29, Short.MAX_VALUE)
                .addComponent(logo, javax.swing.GroupLayout.PREFERRED_SIZE, 223, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(fondAcceuilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(fondAcceuilLayout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(titre, javax.swing.GroupLayout.PREFERRED_SIZE, 412, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(163, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, fondAcceuilLayout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(auteur, javax.swing.GroupLayout.PREFERRED_SIZE, 310, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(81, 81, 81))))
        );
        fondAcceuilLayout.setVerticalGroup(
            fondAcceuilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(fondAcceuilLayout.createSequentialGroup()
                .addGroup(fondAcceuilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(fondAcceuilLayout.createSequentialGroup()
                        .addGap(56, 56, 56)
                        .addComponent(auteur, javax.swing.GroupLayout.PREFERRED_SIZE, 122, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(titre, javax.swing.GroupLayout.PREFERRED_SIZE, 153, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(fondAcceuilLayout.createSequentialGroup()
                        .addGap(31, 31, 31)
                        .addComponent(logo, javax.swing.GroupLayout.PREFERRED_SIZE, 245, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(35, 35, 35)
                .addGroup(fondAcceuilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(continuerJeu, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(nouveauJeu, javax.swing.GroupLayout.PREFERRED_SIZE, 117, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(81, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(fondAcceuil, javax.swing.GroupLayout.DEFAULT_SIZE, 837, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(fondAcceuil, javax.swing.GroupLayout.DEFAULT_SIZE, 589, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

     
    private void nouveauJeuMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_nouveauJeuMousePressed
        if(!nom.isEmpty()){
            sonDeFond.sonDeFont.stop();sonDeFond=null;
            remove(fondAcceuil);
            jeu.nomDuJoueur=nom;
            jeu.start();
        }else
        nom=JOptionPane.showInputDialog(this, "Veillez saisir votre nom", "Nom du joueur", NORMAL);
    }//GEN-LAST:event_nouveauJeuMousePressed

    private void continuerJeuMousePressed(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_continuerJeuMousePressed
       if(!nom.isEmpty()){
            JeuData save=new JeuData();save.joueur="";
            save.selectByJoueur(nom);
            if(!save.joueur.isEmpty()){ 
                 System.out.println("jouer:"+save.joueur+" scor: "+save.score+" vie: "+save.vie+"");
                 sonDeFond.sonDeFont.stop();sonDeFond=null;
                 remove(fondAcceuil);
                 jeu.nomDuJoueur=save.joueur;
                 jeu.score=save.score;
                 jeu.vieDuCanon=save.vie;
                 jeu.start();
            }else{
                 JOptionPane.showMessageDialog(null,"Ce nom n'est pas dans la liste des joueurs");nom="";
            nom=JOptionPane.showInputDialog(this, "Veillez saisir votre nom", "Nom du joueur", NORMAL);
            }
        
        }else
        nom=JOptionPane.showInputDialog(this, "Veillez saisir votre nom", "Nom du joueur", NORMAL);
    }//GEN-LAST:event_continuerJeuMousePressed

    private void formKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyPressed
        // TODO add your handling code here:        System.out.println("tap:"+evt.getKeyCode()+"");
        if(evt.getKeyCode()==37){
            jeu.canonDuJoueur.DeplacerAgauche();
        }
        if(evt.getKeyCode()==38){
            jeu.canonDuJoueur.tirer();
        }
        if(evt.getKeyCode()==39){
            jeu.canonDuJoueur.DeplacerAdroit();
        }
        if(evt.getKeyCode()==32){
            new Thread()
            {
                @Override
                public void run(){
                      for(int i=0;i<50;i++){
                            jeu.canonDuJoueur.tirer(); 
                        try {
                            sleep(50);
                        } catch (InterruptedException ex) {
                            Logger.getLogger(InterfaceDuJeu.class.getName()).log(Level.SEVERE, null, ex);
                        }
                        }
                    }
            }.start();
        }
    }//GEN-LAST:event_formKeyPressed
   String nom;
    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        nom=JOptionPane.showInputDialog(this, "Veillez saisir votre nom", "Nom du joueur", NORMAL);
       
    }//GEN-LAST:event_formWindowOpened

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(InterfaceDuJeu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                new InterfaceDuJeu().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel auteur;
    private javax.swing.JLabel continuerJeu;
    private javax.swing.JPanel fondAcceuil;
    private javax.swing.JLabel logo;
    private javax.swing.JLabel nouveauJeu;
    private javax.swing.JLabel titre;
    // End of variables declaration//GEN-END:variables
}
