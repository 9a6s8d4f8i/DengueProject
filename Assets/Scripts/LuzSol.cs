using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzSol : MonoBehaviour
{

    public Light luz;
    public int alteraEstado;
    public float tempoespera;
  
    private void Start()
    {
        luz.intensity = 1.9f;
        alteraEstado = -1;
      }
    // Update is called once per frame
    void Update()
    {
        if (!Derrota.gameover && !Vitoria.vitoria)
        {
            if (luz.intensity == 0)
            {
                tempoespera += Time.deltaTime;
                if (tempoespera <= 10)
                {

                    alteraEstado = 0;
                }
                else
                    alteraEstado = 1;
            }


            else if (luz.intensity > 2f)
            {
               
                   Vitoria.vitoria = true;          
            }

            luz.intensity += (float)0.05 * alteraEstado * Time.deltaTime;

        }

        }


}

