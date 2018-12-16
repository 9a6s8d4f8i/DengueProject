using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erro : MonoBehaviour {

    public AudioClip falha;
    public AudioClip gameOver;

     void OnMouseDown()
    {
        if(!Derrota.gameover && !Vitoria.vitoria)
        {
            if (!MusicasFundo.pause)
            {
                Pontuacao.inst.playAudio(falha);
                Pontuacao.inst.adicionaPonto(-1);
                if (Pontuacao.inst.Pontos == 20)
                {
                    this.GameOver();
                }
            }
        }
       
         
        
    }
    public void GameOver()
    {
        Pontuacao.inst.playAudio(gameOver);
    }
}
