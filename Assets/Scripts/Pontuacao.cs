using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pontuacao : MonoBehaviour {


    public AudioSource sons;
   
    public static Pontuacao inst = null; //criar singleton
    public int Pontos;
    public Text TextoErro;
    public Text qtdPernilongos;
    private void Awake()
    {
        TextoErro.text = 0.ToString();
        if (inst == null)
            inst = this;
        else if(inst!= null)
        {
            Destroy(gameObject);
        }
        
    }

    private void Update()
    {
        qtdPernilongos.text = InstanciaPernilongo.pernilongosNatela.ToString() + " Pernilongos Na tela";
        if(InstanciaPernilongo.pernilongosNatela == 20)
        {
            Derrota.gameover = true;
        }
    }

    public void playAudio(AudioClip som)
    {
        sons.clip = som;
        sons.Play();
    }

    public void adicionaPonto(int pts)
    {
        this.Pontos = this.Pontos - pts ;
        TextoErro.text = this.Pontos.ToString() + " Erros";

        if(this.Pontos == 20)
        {
            Derrota.gameover = true;
        }

    }


  


}
