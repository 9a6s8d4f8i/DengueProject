using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiPernilongo : MonoBehaviour {
    
    public int hitsdados;
    public AudioClip estralo;
    
  
    

 

    private void OnMouseDown()
    {
        if (!Derrota.gameover && !Vitoria.vitoria)
        {
            if (!MusicasFundo.pause)
        {
            
                if (this.CompareTag("Boss"))
                {
                    Pontuacao.inst.playAudio(estralo);

                    hitsdados++;
                }
                else if (this.CompareTag("Mosquito"))
                {

                    Pontuacao.inst.playAudio(estralo);
                    InstanciaPernilongo.pernilongosNatela--;
                    DestroyObject(this.gameObject);
                }
            }

            
        }
       


    }
    void Update () {
		if(hitsdados==20)
        {
            InstanciaPernilongo.pernilongosNatela--;
            Destroy(this.gameObject);
        }
	}
     
 
}
