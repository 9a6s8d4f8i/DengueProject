

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Vitoria : MonoBehaviour
{

    public static bool vitoria;
    public RectTransform panel;
    public Vector3 encima, centrodatela;
    public new GameObject camera;

    private void Start()
    {
        panel.position = new Vector3(panel.position.x, camera.transform.position.y + 10, panel.position.z);
        vitoria = false;
    }


    private void Update()
    {
        centrodatela = new Vector3(panel.position.x, camera.transform.position.y / 2, panel.position.z);
        encima = new Vector3(panel.position.x, camera.transform.position.y + 10, panel.position.z);
        if (!vitoria)
        {

            panel.position = encima;
        }
        else
        {
           
            panel.position = Vector3.Lerp(panel.position, centrodatela, Time.deltaTime * 10);
        }
    }



}

