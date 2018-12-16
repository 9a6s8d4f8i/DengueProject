using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GerenciaLanterna : MonoBehaviour {

    public bool ligada;
    public Light luzLanterna;
    public float tempo=0;
    public Bateria bat;
    public int contador = 0;
    // Use this for initialization

    private void Start()
    {
        ligada = false;
        luzLanterna.intensity = 0;


    }
    
   public void  OnMouseDown()
    {
       
        if (!bat.BotaoEnable(4))
        {
            if (ligada == true)
            {
                ligada = false;
                luzLanterna.intensity = 0;

            }
           else
            {
                ligada = true;
                luzLanterna.intensity = 5;
            }

        }
        else
        {
            ligada = false;
            luzLanterna.intensity = 0;
        }
       
    }
    void Update()
    {
       if(ligada==true)
        {
            tempo += Time.deltaTime;
            if(contador!=4)
            {
                if (tempo >= 3)
                {
                       bat.AlteraEstado();
                        tempo = 0;
                        contador++;
                    
                  

                }
            }
            else
            {
                ligada = false;
                luzLanterna.intensity = 0;
            }


        }
       

    }
}
