/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jeudetir;

import java.applet.Applet;
import java.applet.AudioClip;
import java.net.URL;

/**
 *
 * @author sekouzed
 */
public class EffetSonor extends Thread{
    public AudioClip sonDeFont;
    boolean lectureEnBoucle;
    public EffetSonor(String fichier,boolean lectureEnBoucle){
        this.lectureEnBoucle=lectureEnBoucle;
        URL u1 =JeuDeTir.class.getResource(fichier);
        sonDeFont= Applet.newAudioClip(u1);
    }
    @Override
    public void run(){
        if(lectureEnBoucle)
            sonDeFont.loop();
        else
            sonDeFont.play();
    }
}
