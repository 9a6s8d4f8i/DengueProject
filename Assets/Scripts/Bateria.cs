using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bateria : MonoBehaviour {

    public int estadoBateria;
    public Image[] bateria= new Image[5];
    public void Start()
    {
        estadoBateria = 0;
    }

    public bool BotaoEnable(int estado)
    {
        
        if (bateria[estado].enabled)
        { 
        return true;
        }
        
        return false;
    }

    public void AlteraEstado()
    {
       
        bateria[estadoBateria].enabled = false;
        estadoBateria++;
        bateria[estadoBateria].enabled = true;

    }


}
