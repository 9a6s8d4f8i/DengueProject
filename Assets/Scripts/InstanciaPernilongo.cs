using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstanciaPernilongo : MonoBehaviour {

    public GameObject pernilongo;
    public GameObject bocaGarrafa;
    public GameObject chefe;
    private float tempoInstancia;
    public Light luzsol;
    private int cont=0;
    public static int pernilongosNatela=1;
    
  
    private void Start()
    {
        Instantiate(pernilongo, new Vector2(bocaGarrafa.transform.position.x, bocaGarrafa.transform.position.y), bocaGarrafa.transform.rotation);
    }
    
    void Update () {
       

        if(!Derrota.gameover && !Vitoria.vitoria)
        {
            if (luzsol.intensity == 0)
            {
                tempoInstancia += Time.deltaTime;
                cont++;
                if (cont == 1)
                {
                    pernilongosNatela++;
                    Instantiate(chefe, new Vector2(bocaGarrafa.transform.position.x, bocaGarrafa.transform.position.y), bocaGarrafa.transform.rotation);
                }

                else if (tempoInstancia >= 2)
                {
                    pernilongosNatela++;
                    Instantiate(pernilongo, new Vector2(bocaGarrafa.transform.position.x, bocaGarrafa.transform.position.y), bocaGarrafa.transform.rotation);
                    tempoInstancia = 0;
                }

            }
            else
            {
                tempoInstancia += Time.deltaTime;
                if (tempoInstancia >= 0.7f)
                {
                    pernilongosNatela++;
                    Instantiate(pernilongo, new Vector2(bocaGarrafa.transform.position.x, bocaGarrafa.transform.position.y), bocaGarrafa.transform.rotation);
                   
                    tempoInstancia = 0;
                }
            }
        }
    
      
		
	}
}
